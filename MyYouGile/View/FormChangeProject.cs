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
using Microsoft.VisualBasic;
using MyYouGile.Properties;
using System.IO;

namespace MyYouGile
{
    public partial class FormChangeProject : System.Windows.Forms.Form
    {
        private Project currentProject;
        private int selectedItem = 0;
        public FormChangeProject()
        {
            InitializeComponent();
            LabelProjectID.Visible = false;
            TextBoxProjectID.Visible = false;
            UpdateCategory();
            ComboBoxProjectCategory.SelectedIndex = selectedItem;
            PictureBoxProjectImage.Image = Resources.image;
        }

        public FormChangeProject(int id)
        {
            InitializeComponent();
            this.currentProject = Helper.ModelDB.Project.Where(p => p.ProjectID == id).FirstOrDefault();
            TextBoxProjectID.Text = currentProject.ProjectID.ToString();
            TextBoxProjectName.Text = currentProject.ProjectName;
            TextBoxProjectPrice.Text = currentProject.ProjectPrice.ToString();
            RichTextBoxProjectDescription.Text = currentProject.ProjectDescription;
            UpdateCategory();
            ComboBoxProjectCategory.SelectedIndex = selectedItem;
            TextBoxProjectID.Enabled = false;
            try 
            {
                MemoryStream ms = new MemoryStream(currentProject.ProjectImage);
                Bitmap bitmap = (Bitmap)Image.FromStream(ms);
                PictureBoxProjectImage.Image = bitmap;
            }
            catch{ PictureBoxProjectImage.Image = Resources.image; }
        }

        private void PictureBoxProjectImage_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileName = data as string[];
                if (fileName.Length > 0)
                    PictureBoxProjectImage.Image = Image.FromFile(fileName[0]);
            }
        }

        public Project ValidateProject()
        {
            Project project = new Project();
            string name;
            string description;
            int categoryID;
            decimal price;
            Image image;
            try
            {
                name = TextBoxProjectName.Text;
                description = RichTextBoxProjectDescription.Text;
                DataRowView dataRowView = (DataRowView)ComboBoxProjectCategory.SelectedItem;
                categoryID = (int)dataRowView.Row[0];
                price = Decimal.Parse(TextBoxProjectPrice.Text);
                image = PictureBoxProjectImage.Image;
            }
            catch
            {
                return null;
            }
            if (String.IsNullOrEmpty(name))
                return null;
            if (String.IsNullOrEmpty(description))
                return null;
            if (categoryID < 0)
                return null;
            if (price <= 0)
                return null;
            if (image != Resources.image)
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, PictureBoxProjectImage.Image.RawFormat);
                    project.ProjectImage = ms.ToArray();
                }
                catch
                {
                    MemoryStream ms = new MemoryStream();
                    Resources.image.Save(ms, Resources.image.RawFormat);
                    project.ProjectImage = ms.ToArray();
                }
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                Resources.image.Save(ms, Resources.image.RawFormat);
                project.ProjectImage = ms.ToArray();
            }
            project.ProjectName = name;
            project.ProjectDescription = description;
            project.ProjectCategory = categoryID;
            project.ProjectPrice = price;
            return project;
        }


        private void PictureBoxProjectImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void FormChangeProject_Load(object sender, EventArgs e)
        {
            PictureBoxProjectImage.AllowDrop = true;
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введите название новой категории", "Добавление категории", "", Cursor.Position.X, Cursor.Position.Y);
            if (input == "")
                return;
            try
            {
                int categoryID = Helper.ModelDB.Category.Count();
                Category category = new Category();
                category.CategoryID = categoryID + 1;
                category.CategoryName = input;
                Helper.ModelDB.Category.Add(category);
                Helper.ModelDB.SaveChanges();
            }
            catch { };
            UpdateCategory();
        }

        public void UpdateCategory()
        {
            List<Category> categories = Helper.ModelDB.Category.ToList();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(Int32));
            dataTable.Columns.Add("value", typeof(String));
            int selected = 0;
            int categorySelected;
            if (currentProject is null)
                categorySelected = -1;
            else
                categorySelected = currentProject.ProjectCategory;


            foreach (Category category in categories)
            {
                if (category.CategoryID == categorySelected)
                    this.selectedItem = selected;
                dataTable.Rows.Add(category.CategoryID, category.CategoryName);
                selected++;
            }
            ComboBoxProjectCategory.DataSource = dataTable;
            ComboBoxProjectCategory.ValueMember = "id";
            ComboBoxProjectCategory.DisplayMember = "value";
        }

        private void ButtonProjectAdd_Click(object sender, EventArgs e)
        {
            Project project = ValidateProject();
            if (project is null)
                return;
            try
            {
                project.ProjectID = Helper.ModelDB.Project.Count() + 1;
                Helper.ModelDB.Project.Add(project);
                Helper.ModelDB.SaveChanges();
                Assignment assignment = new Assignment();
                assignment.AssignmentProject = project.ProjectID;
                assignment.AssignmentUser = Helper.CurrentUser.UserID;
                Helper.ModelDB.Assignment.Add(assignment);
                Helper.ModelDB.SaveChanges();
            }
            catch
            {
                return;
            }
        }

        private void ButtonProjectUpdate_Click(object sender, EventArgs e)
        {
            Project project = ValidateProject();
            if (project is null)
                return;
            try
            {
                project.ProjectID = currentProject.ProjectID;
                Helper.ModelDB.Entry(currentProject).CurrentValues.SetValues(project);
                Helper.ModelDB.SaveChanges();
            }
            catch
            {
                return;
            }
            
        }
        private void ButtonProjectDelete_Click(object sender, EventArgs e)
        {
            Assignment assignmentForDelete = Helper.ModelDB.Assignment.Where(assign =>
            assign.AssignmentProject == currentProject.ProjectID &&
            assign.User.Role.RoleName == Helper.Role.Разработчик.ToString() &&
            assign.AssignmentUserIsCommited == true).FirstOrDefault();
            if (assignmentForDelete == null)
                return;
            Helper.ModelDB.Project.Remove(currentProject);
            Helper.ModelDB.SaveChanges();
        }

        private void ButtonDefaultImage_Click(object sender, EventArgs e)
        {
            PictureBoxProjectImage.Image = Resources.image;
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string file = dlg.FileName;
                PictureBoxProjectImage.Image = Image.FromFile(file);
            }
        }

        private void ButtonAddManager_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введите логин менеджера", "Добавление менеджера", "", Cursor.Position.X, Cursor.Position.Y);
            if (input == "")
                return;
            try
            {
                Assignment assignment = new Assignment();
                assignment.AssignmentProject = currentProject.ProjectID;
                assignment.AssignmentUser = Helper.ModelDB.User.Where(user => user.UserLogin == input).First().UserID;
                Helper.ModelDB.Assignment.Add(assignment);
                Helper.ModelDB.SaveChanges();
            }
            catch
            {

            }

        }
    }
}
