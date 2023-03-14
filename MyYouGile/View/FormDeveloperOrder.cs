
using MyYouGile.Classes;
using MyYouGile.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyYouGile
{
    public partial class FormDeveloperOrder : System.Windows.Forms.Form
    {
        private int projectId;
        private List<Assignment> allAssignedDevelopers = new List<Assignment>();
        public FormDeveloperOrder()
        {
            InitializeComponent();
        }

        public FormDeveloperOrder(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            allAssignedDevelopers = Helper.ModelDB.Assignment.Where(assign =>
            assign.AssignmentProject == projectId &&
            assign.User.Role.RoleName == Helper.Role.Разработчик.ToString()).ToList();
            List<Assignment> assignmentsForDelete = new List<Assignment>();
            foreach(Assignment assignment in allAssignedDevelopers)
            {
                try
                {
                    bool isCommited = (bool)assignment.AssignmentUserIsCommited;
                    if (isCommited == true)
                        assignmentsForDelete.Add(assignment);
                }
                catch { assignmentsForDelete.Add(assignment); }
            }
            foreach(Assignment deleting in assignmentsForDelete)
            {
                allAssignedDevelopers.Remove(deleting);
            }
            GetUsers(allAssignedDevelopers);
        }

        public void GetUsers(List<Assignment> assignments)
        {
            List<User> users = new List<User>();
            foreach (Assignment assignment in assignments)
            {

                User user = Helper.ModelDB.User.Where(u => u.UserID == assignment.AssignmentUser).First();
                Perfomance perfomance = Helper.ModelDB.Perfomance.Where(perfom => perfom.UserID == user.UserID && perfom.PerfomanceStatus == 2).First();
                if (perfomance != null)
                    users.Add(user);

            }
            UpdateGridStage(users);
        }

        public void UpdateGridStage(List<User> users)
        {
            DGVDevelopers.Rows.Clear();
            foreach (User user in users)
            {
                int viewID = DGVDevelopers.Rows.Add();
                DGVDevelopers.Rows[viewID].Cells[0].Tag = user.UserID;
                DGVDevelopers.Rows[viewID].Cells[0].Value = user.UserSurname + " " + user.UserFirstname;
            }
        }

        private void DGVDevelopers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int idUser = int.Parse(DGVDevelopers.Rows[e.RowIndex].Cells[0].Tag.ToString());
            FormStage formStage = new FormStage(projectId, idUser, true);
            this.Hide();
            formStage.ShowDialog();
            this.Show();

        }
    }
}
