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
    public partial class FormAuthorization : System.Windows.Forms.Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            Helper.ModelDB.Database.Connection.Open();
            Helper.ModelDB.Role.ToList();
            MessageBox.Show("Успешное подключение", "Подключение к БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Helper.ModelDB.Database.Connection.Close();
        }

        public FormProjectList Authorize(string login, string password)
        {
            User user = Helper.ModelDB.User.Where(u => u.UserLogin == login && u.UserPassword == password).FirstOrDefault();
            if (user is null)
                return null;
            else
            {
                Helper.CurrentUser = user;
                Helper.GetRole(Helper.CurrentUser.Role.RoleName);
            }
            FormProjectList formProjectList = new FormProjectList();
            return formProjectList;
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;
            FormProjectList formProjectList = Authorize(login, password);
            if (formProjectList != null)
            {
                this.Hide();
                formProjectList.ShowDialog();
                this.Show();
            }
        }
    }
}
