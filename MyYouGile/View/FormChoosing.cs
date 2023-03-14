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
using System.Web;
using System.Windows.Forms;

namespace MyYouGile
{
    public partial class FormChoosing : System.Windows.Forms.Form
    {
        private string type;
        private List<Category> categories = new List<Category>();
        private List<User> clients = new List<User>();
        public FormChoosing()
        {
            InitializeComponent();
        }

        public FormChoosing(List<Category> categories)
        {
            InitializeComponent();
            type = "category";
            this.categories.Clear();
            this.categories.AddRange(categories);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(Int32));
            dataTable.Columns.Add("value", typeof(String));
            dataTable.Rows.Add(0, "Все категории");
            foreach (Category category in categories)
            {
                dataTable.Rows.Add(category.CategoryID, category.CategoryName);
            }
            ListBoxElements.DataSource = dataTable;
            ListBoxElements.ValueMember = "id";
            ListBoxElements.DisplayMember = "value";
        }

        public FormChoosing(List<User> clients)
        {
            InitializeComponent();
            type = "client";
            this.clients.Clear();
            this.clients.AddRange(clients);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id",typeof(Int32));
            dataTable.Columns.Add("value", typeof(String));
            dataTable.Rows.Add(0, "Все заказчики");
            foreach(User client in clients)
            {
                dataTable.Rows.Add(client.UserID, client.UserSurname);
            }
            ListBoxElements.DataSource = dataTable;
            ListBoxElements.ValueMember = "id";
            ListBoxElements.DisplayMember = "value";
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case "category":
                    if (ListBoxElements.SelectedIndex < 0)
                        FormProjectList.SelectedCategory = -1;
                    break;
            }
            
            this.Close();
        }

        private void ListBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)ListBoxElements.SelectedItem;
            int id = (int)dataRowView.Row[0];
            
            switch(type)
            {
                case "category":
                    FormProjectList.SelectedCategory = id;break;
                case "client":
                    List<int> projects = new List<int>();
                    List<Assignment> projectsWithClient = Helper.ModelDB.Assignment.Where(assignment => assignment.AssignmentUser == id).ToList();
                    foreach (Assignment assignment in projectsWithClient)
                    {
                        projects.Add(assignment.AssignmentProject);
                    }
                    FormProjectList.SelectedProject = projects;break;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case "category":FormProjectList.SelectedCategory = -1;break;
            }
            this.Close();
        }

        private void TextBoxChoose_TextChanged(object sender, EventArgs e)
        {
            ListBoxElements.Items.Clear();
            ListBoxElements.Items.Add("Все категории");
            string text = TextBoxChoose.Text;
            switch (type)
            {
                case "category":
                    foreach (Category category in categories)
                    {
                        if (!(String.IsNullOrEmpty(text)))
                        {
                            if (!(category.CategoryName.Contains(text)))
                                continue;
                        }
                        ListBoxElements.Items.Add(category.CategoryName);
                    }
                    break;
            }
        }
    }
}
