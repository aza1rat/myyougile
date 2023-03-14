using MyYouGile.Classes;
using MyYouGile.Entities;
using MyYouGile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyYouGile
{
    public partial class FormStage : System.Windows.Forms.Form
    {
        private int projectID;
        private int userID;
        private int selectedStage = -1;
        public FormStage()
        {
            InitializeComponent();
        }

        public FormStage(int projectID, int userID, bool isItManager)
        {
            InitializeComponent();
            TextBoxStage.Visible =
                    TextBoxDateStart.Visible =
                    TextBoxDateEnd.Visible =
                    LabelStage.Visible =
                    LabelDateStart.Visible =
                    LabelDateEnd.Visible = false;
            ButtonSendRequest.Visible =
                ButtonStageAdd.Visible =
                ButtonStageChange.Visible =
                ButtonStageDelete.Visible = false;
            
            if (isItManager)
            {
                LabelStatus.Visible =
                    ComboBoxStatus.Visible = false;
            }
            if (!isItManager)
            {
                ButtonAcceptRequest.Visible =
                    ButtonDeclineRequest.Visible = false;
                ComboBoxStatus.Items.Add("Не выполнено");
                ComboBoxStatus.Items.Add("Выполнено");

            }
            this.projectID = projectID;
            this.userID = userID;
            GetStages();
        }

        public FormStage(int projectID, int userID)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.userID = userID;
            ButtonAcceptRequest.Visible =
                ButtonDeclineRequest.Visible = false;
            LabelStatus.Visible =
                    ComboBoxStatus.Visible = false;
            GetStages();
        }

        public void GetStages()
        {
            List<Perfomance> perfomances = Helper.ModelDB.Perfomance.Where(perfomance => perfomance.UserID == userID
            && perfomance.ProjectID == projectID).ToList();
            List<Stage> stages = new List<Stage>();
            foreach (Perfomance perfomance in perfomances)
            {
                stages.Add(Helper.ModelDB.Stage.Where(stage => stage.StageID == perfomance.StageID).First());
            }
            UpdateGridStage(stages);
        }

        public void UpdateGridStage(List<Stage> stages)
        {
            DGVStages.Rows.Clear();
            foreach (Stage stage in stages)
            {
                int viewID = DGVStages.Rows.Add();
                DGVStages.Rows[viewID].Cells[0].Tag = stage.StageID;
                DGVStages.Rows[viewID].Cells[0].Value = stage.StageName;
                DGVStages.Rows[viewID].Cells[1].Value = stage.StageStart;
                DGVStages.Rows[viewID].Cells[2].Value = stage.StageEnd;
            }
        }

        public Stage ValidateStage()
        {
            Stage stage = new Stage();
            string name;
            DateTime start;
            DateTime end;
            try
            {
                name = TextBoxStage.Text;
                start = DateTime.Parse(TextBoxDateStart.Text);
                end = DateTime.Parse(TextBoxDateEnd.Text);
            }
            catch
            {
                return null;
            }
            if (String.IsNullOrEmpty(name))
                return null;
            if (end < start)
                return null;
            stage.StageName = name;
            stage.StageStart = start;
            stage.StageEnd = end;
            return stage;
        }

        private void ButtonStageAdd_Click(object sender, EventArgs e)
        {
            Stage stage = ValidateStage();
            if (stage is null)
                return;
            stage.StageStatus = false;
            int stageId = Helper.ModelDB.Stage.Count() + 1;
            stage.StageID = stageId;
            Helper.ModelDB.Stage.Add(stage);
            Helper.ModelDB.SaveChanges();
            Perfomance perfomance = new Perfomance()
            {
                StageID = stageId,
                ProjectID = this.projectID,
                UserID = this.userID,
                PerfomanceStatus = Helper.ModelDB.Status.Where(status =>
                status.StatusID == 1).First().StatusID
            };
            Helper.ModelDB.Perfomance.Add(perfomance);
            Helper.ModelDB.SaveChanges();
            GetStages();
        }

        private void DGVStages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                this.selectedStage = -1;
                return;
            }
            this.selectedStage = int.Parse(DGVStages.Rows[e.RowIndex].Cells[0].Tag.ToString());
            Stage stage = Helper.ModelDB.Stage.Where(s => s.StageID == selectedStage).FirstOrDefault();
            TextBoxStage.Text = stage.StageName;
            TextBoxDateStart.Text = stage.StageStart.ToString();
            TextBoxDateEnd.Text = stage.StageEnd.ToString();
        }

        private void ButtonStageChange_Click(object sender, EventArgs e)
        {
            if (selectedStage < 0)
                return;
            Stage stage = ValidateStage();
            if (stage is null)
                return;
            Stage original = Helper.ModelDB.Stage.Where(s => s.StageID == selectedStage).First();
            stage.StageStatus = false;
            stage.StageID = original.StageID;
            Helper.ModelDB.Entry(original).CurrentValues.SetValues(stage);
            Helper.ModelDB.SaveChanges();
            GetStages();
        }

        private void ButtonStageDelete_Click(object sender, EventArgs e)
        {
            if (selectedStage < 0)
                return;
            Stage original = Helper.ModelDB.Stage.Where(s => s.StageID == selectedStage).First();
            Helper.ModelDB.Stage.Remove(original);
            Helper.ModelDB.SaveChanges();
            GetStages();
        }

        private void ButtonSendRequest_Click(object sender, EventArgs e)
        {
            if (DGVStages.Rows.Count == 0)
                return;
            List<Perfomance> perfomances = Helper.ModelDB.Perfomance.Where(perfomance => perfomance.UserID == userID
            && perfomance.ProjectID == projectID).ToList();
            foreach(Perfomance perfomance in perfomances)
            {
                perfomance.PerfomanceStatus = 2;
                Helper.ModelDB.SaveChanges();
            }
            Assignment assignment = new Assignment()
            {
                AssignmentProject = projectID,
                AssignmentUser = userID,
                AssignmentUserIsCommited = false
            };
            Helper.ModelDB.Assignment.Add(assignment);
            Helper.ModelDB.SaveChanges();
            this.Close();
        }

        private void ButtonAcceptRequest_Click(object sender, EventArgs e)
        {
            List<Perfomance> perfomances = Helper.ModelDB.Perfomance.Where(perfomance => perfomance.UserID == userID
            && perfomance.ProjectID == projectID).ToList();
            foreach (Perfomance perfomance in perfomances)
            {
                perfomance.PerfomanceStatus = 4;
                Helper.ModelDB.SaveChanges();
            }
            Assignment assignment = Helper.ModelDB.Assignment.Where(assign => assign.AssignmentUser == userID && assign.AssignmentProject == projectID).First();
            assignment.AssignmentUserIsCommited = true;
            Helper.ModelDB.SaveChanges();
        }

        private void ButtonDeclineRequest_Click(object sender, EventArgs e)
        {
            List<Perfomance> perfomances = Helper.ModelDB.Perfomance.Where(perfomance => perfomance.UserID == userID
            && perfomance.ProjectID == projectID).ToList();
            foreach (Perfomance perfomance in perfomances)
            {
                perfomance.PerfomanceStatus = 3;
                Helper.ModelDB.SaveChanges();
            }
            Assignment assignment = Helper.ModelDB.Assignment.Where(assign => assign.AssignmentUser == userID && assign.AssignmentProject == projectID).First();
            assignment.AssignmentUserIsCommited = false;
            Helper.ModelDB.SaveChanges();
        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedStage < 0)
                return;
            bool isComplete = false ;
            switch(ComboBoxStatus.SelectedItem.ToString())
            {
                case "Выполнено": isComplete = true;break;
                case "Не выполнено": isComplete = false;break;
            }
            Stage stage = Helper.ModelDB.Stage.Where(st => st.StageID == selectedStage).First();
            stage.StageStatus = isComplete;
            Helper.ModelDB.SaveChanges();
        }
    }
}
