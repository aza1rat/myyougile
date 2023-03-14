using MyYouGile.Classes;
using MyYouGile.Entities;
using MyYouGile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyYouGile
{
    public partial class FormProjectList : System.Windows.Forms.Form
    {
        private const string upArrow = "↑";
        private const string downArrow = "↓";
        public static int SelectedCategory = 0;
        public static List<int> SelectedProject = new List<int>();
        private List<Project> projects;
        public FormProjectList()
        {
            InitializeComponent();
            UpdateProjectList();
            if (Helper.UserRole != Helper.Role.Заказчик)
                ButtonToAddProject.Visible = false;

        }

        public void UpdateProjectList()
        {
            List<string> parameters = new List<string>();
            String sqlCommand = "Select * From Project ";
            if (SelectedCategory > 0 && SelectedProject.Count > 0)
            {
                parameters.Add("ProjectCategory = " + SelectedCategory + " AND");
            }
            if (SelectedCategory > 0 && SelectedProject.Count == 0)
            {
                parameters.Add("ProjectCategory = " + SelectedCategory + " ");
            }
            if (SelectedProject.Count > 0)
            {
                for (int i = 0; i < SelectedProject.Count; i++)
                {
                    parameters.Add("ProjectID = " + SelectedProject[i] + " ");
                    if (i < SelectedProject.Count - 1)
                        parameters.Add("OR ");
                }
            }
            

            if (parameters.Count > 0)
            {
                sqlCommand += "WHERE ";
                for (int i = 0; i < parameters.Count; i++)
                {
                    sqlCommand += parameters[i];
                }
            }

            switch(ButtonListCostSort.Text)
            {
                case upArrow:sqlCommand += "ORDER BY ProjectPrice ASC";break;
                case downArrow:sqlCommand += "ORDER BY ProjectPrice DESC";break;
            }
            projects = Helper.ModelDB.Project.SqlQuery(sqlCommand).ToList();
            UpdateDataGrid();
        }

        private bool IsHaveLetter(string str, string letters)
        {
            if (String.IsNullOrEmpty(str))
                return true;
            return str.Contains(letters);
        }

        public void UpdateDataGrid()
        {
            int displayedCount = 0;
            DGVProject.Rows.Clear();
            foreach (Project project in projects)
            {
                if (!(IsHaveLetter(project.ProjectName, TextBoxSearch.Text)))
                    continue;
                int viewID = DGVProject.Rows.Add();
                DGVProject.Rows[viewID].Height = 120;
                if (project.ProjectImage != null)
                {
                    MemoryStream ms = new MemoryStream(project.ProjectImage);
                    Bitmap bitmap = (Bitmap)Image.FromStream(ms);
                    DGVProject.Rows[viewID].Cells[0].Value = bitmap;
                }
                else
                    DGVProject.Rows[viewID].Cells[0].Value = (Bitmap)Resources.image;

                List<User> clients = GetClients(project.ProjectID);
                string allClients = "";
                foreach (User client in clients)
                {
                    allClients += client.UserSurname + " " + client.UserFirstname + " \n";
                }
                DGVProject.Rows[viewID].Cells[0].Tag = project.ProjectID;
                DGVProject.Rows[viewID].Cells[1].Value += "Название проекта: " + project.ProjectName +
                    Environment.NewLine + "Заказчики проекта: " + Environment.NewLine + allClients +
                    Environment.NewLine + "Категория: " + project.Category.CategoryName +
                    Environment.NewLine + "Цена: " + project.ProjectPrice + Environment.NewLine + "Пройденные стадии реализации: " +
                    GetCompeteStage(project.ProjectID);
                displayedCount++;
            }
            LabelProjectDisplay.Text = $"Показано: {displayedCount} из {Helper.ModelDB.Project.ToList().Count}";
        }

        private List<User> GetClients(int projectId)
        {
            List<Assignment> assignments = Helper.ModelDB.Assignment.Where(assign => assign.AssignmentProject == projectId).ToList();
            List<User> clients = new List<User>();
            foreach(Assignment assignment in assignments)
            {
                if (assignment.User.Role.RoleName == Helper.Role.Заказчик.ToString())
                    clients.Add(assignment.User);
            }
            return clients;
        }

        public string GetCompeteStage(int projectID)
        {
            string answer = "-";
            Assignment assignment = Helper.ModelDB.Assignment.Where(assign => assign.AssignmentProject == projectID &&
            assign.User.Role.RoleName == Helper.Role.Разработчик.ToString() && assign.AssignmentUserIsCommited == true).FirstOrDefault();
            if (assignment is null)
                return answer;
            List<Perfomance> perfomances = Helper.ModelDB.Perfomance.Where(perfoman => perfoman.UserID == assignment.AssignmentUser &&
            perfoman.ProjectID == projectID).ToList();
            foreach (Perfomance perfomance in perfomances)
            {
                if (perfomance.Stage.StageStatus == true)
                    answer += perfomance.Stage.StageName + "\n";
            }
            return answer;
        }

        private void ButtonProjectListBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonListCategory_Click(object sender, EventArgs e)
        {
            List<Category> categories = Helper.ModelDB.Category.ToList();
            FormChoosing formChoosing = new FormChoosing(categories);
            formChoosing.ShowDialog();
            UpdateProjectList();
        }

        private void ButtonListCostSort_Click(object sender, EventArgs e)
        {
            switch (ButtonListCostSort.Text)
            {
                case upArrow: ButtonListCostSort.Text = downArrow; break;
                case downArrow: ButtonListCostSort.Text = upArrow; break;
            }
            UpdateProjectList();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateProjectList();
        }

        private void ButtonListClient_Click(object sender, EventArgs e)
        {
            FormChoosing formChoosing = new FormChoosing(Helper.ModelDB.User.Where(u => u.Role.RoleName == "Заказчик").ToList());
            formChoosing.ShowDialog();
            UpdateProjectList();
        }

        public Form CellContentDoubleClick(int rowIndex)
        {
            if (rowIndex < 0)
                return null;
            int idProject = int.Parse(DGVProject.Rows[rowIndex].Cells[0].Tag.ToString());
            if (Helper.UserRole == Helper.Role.Менеджер)
            {
                if (CanBeManage(idProject))
                {
                    FormDeveloperOrder formDeveloperOrder = new FormDeveloperOrder(idProject);
                    return formDeveloperOrder;
                }
                return null;
            }
            if (Helper.UserRole == Helper.Role.Заказчик)
            {
                if (CanBeEdited(idProject))
                {
                    FormChangeProject formChangeProject = new FormChangeProject(idProject);
                    return formChangeProject;
                }
                return null;
            }
            if (Helper.UserRole == Helper.Role.Разработчик)
            {
                if (!(CanBeWatched(idProject)))
                    return null;
                FormStage formStage = new FormStage(idProject, Helper.CurrentUser.UserID);
                return formStage;
            }
            return null;
        }


        private void DGVProject_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = CellContentDoubleClick(e.RowIndex);
            if (form != null)
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            UpdateProjectList();
            
        }

        public bool CanBeManage(int idProject)
        {
            Assignment assignment = Helper.ModelDB.Assignment.Where(assign => assign.AssignmentProject == idProject && assign.AssignmentUser == Helper.CurrentUser.UserID).FirstOrDefault();
            if (assignment is null)
                return false;
            User user = Helper.ModelDB.User.Where(u => u.UserID == assignment.AssignmentUser).FirstOrDefault();
            if (user.Role.RoleName == Helper.Role.Менеджер.ToString())
                return true;
            return false;
        }

        public bool CanBeEdited(int idProject)
        {
            Assignment assignment = Helper.ModelDB.Assignment.Where(assign => assign.AssignmentProject == idProject && assign.AssignmentUser == Helper.CurrentUser.UserID).FirstOrDefault();
            if (assignment is null)
                return false;
            User user = Helper.ModelDB.User.Where(u => u.UserID == assignment.AssignmentUser).FirstOrDefault();
            if (user.Role.RoleName == Helper.Role.Заказчик.ToString())
                return true;
            return false;
            
        }

        public bool CanBeWatched(int idProject)
        {
            Perfomance perfomance = Helper.ModelDB.Perfomance.Where(perf => perf.UserID == Helper.CurrentUser.UserID &&
            perf.ProjectID == idProject).FirstOrDefault();
            if (perfomance is null)
                return true;
            if (perfomance.Status.StatusName == "На рассмотрении")
                return false;
            return true;
        }

        public FormChangeProject GoToAddProject()
        {
            if (Helper.UserRole != Helper.Role.Заказчик)
                return null;
            FormChangeProject formChangeProject = new FormChangeProject();
            return formChangeProject;
        }

        private void ButtonToAddProject_Click(object sender, EventArgs e)
        {
            FormChangeProject formChangeProject = GoToAddProject();
            if (formChangeProject != null)
            {
                this.Hide();
                formChangeProject.ShowDialog();
                this.Show();
                UpdateProjectList();
            }
        }
    }
}
