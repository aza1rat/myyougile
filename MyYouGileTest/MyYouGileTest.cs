using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyYouGile;
using MyYouGile.Classes;
using System.Windows.Forms;

namespace MyYouGileTest
{
    [TestClass]
    public class MyYouGileTest
    {
        [TestMethod]
        public void Authorize_CanAuthorizedAccountGoToCatalogueForm()
        {
            //Arrange
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "timRepin511";
            string password = "lGwJ41yAwz6J";
            //Act
            FormProjectList formProjectList = formAuthorization.Authorize(login, password);
            Helper.ModelDB.Database.Connection.Close();
            //Assert
            Assert.IsTrue(formProjectList != null);
        }
        [TestMethod]
        public void Authorize_NonAuthorizedAccountCantNotGoToCatalogueForm()
        {
            //Arrange
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = " ";
            string password = " ";
            //Act
            FormProjectList formProjectList = formAuthorization.Authorize(login, password);
            Helper.ModelDB.Database.Connection.Close();
            //Assert
            Assert.IsTrue(formProjectList is null);
        }

        [TestMethod]
        public void ClientChangeProject_CanClientGoToChangingProject()
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "timRepin511";
            string password = "lGwJ41yAwz6J";

            formAuthorization.Authorize(login, password);
            FormProjectList formProjectList = new FormProjectList();
            FormChangeProject formChangeProject = formProjectList.GoToAddProject();

            Assert.IsTrue(formChangeProject != null);
        }

        [TestMethod]
        public void ClientChangeProject_CanClientGoToChangingSelectedProject()
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "timRepin511";
            string password = "lGwJ41yAwz6J";
            formAuthorization.Authorize(login, password);
            FormProjectList formProjectList = new FormProjectList();
            FormChangeProject form = (FormChangeProject) formProjectList.CellContentDoubleClick(5);
            Assert.IsTrue(form != null);
        }

        [TestMethod]
        public void ClientChangeProject_DeveloperCantGoToChangingProject()
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "mamilo321";
            string password = "a1dqRgwIT1d8";
            formAuthorization.Authorize(login, password);
            FormProjectList formProjectList = new FormProjectList();
            Assert.ThrowsException<InvalidCastException>(() => (FormChangeProject)formProjectList.CellContentDoubleClick(5));
        }

        [TestMethod]
        public void ClientChangeProject_CanManagerGoToDeveloperChoosing()
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "vadikRoPot336";
            string password = "YF2xSGKVia4F";
            formAuthorization.Authorize(login, password);
            FormProjectList formProjectList = new FormProjectList();
            FormDeveloperOrder form = (FormDeveloperOrder)formProjectList.CellContentDoubleClick(5);
            Assert.IsTrue(form != null);
        }

        [TestMethod]
        public void ClientChangeProject_DeveloperCantGoToDeveloperChoosing()
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "mamilo321";
            string password = "a1dqRgwIT1d8";
            formAuthorization.Authorize(login, password);
            FormProjectList formProjectList = new FormProjectList();
            Assert.ThrowsException<InvalidCastException>(() => (FormChangeProject)formProjectList.CellContentDoubleClick(5));
        }

        [TestMethod]
        public void ClientChangeProject_CanDeveloperGoToStageChangingForm()
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "mamilo321";
            string password = "a1dqRgwIT1d8";
            formAuthorization.Authorize(login, password);
            FormProjectList formProjectList = new FormProjectList();
            FormStage form = (FormStage)formProjectList.CellContentDoubleClick(5);
            Assert.IsTrue(form != null);
        }

        [TestMethod]
        public void ClientChangeProject_ClienCantGoToStageChangingForm()
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            string login = "timRepin511";
            string password = "lGwJ41yAwz6J";
            formAuthorization.Authorize(login, password);
            FormProjectList formProjectList = new FormProjectList();
            Assert.ThrowsException<InvalidCastException>(() => (FormStage)formProjectList.CellContentDoubleClick(5));
        }
    }
}
