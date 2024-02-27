using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe.Admin
{
    public partial class AdminForm : Form
    {
        string connectionString = "";
        string AdminID;
        string Password;
        AdminProfile adminProfile;
        ValidatePaymentAndAssign validatePaymentAndAssign;
        ViewFeedback viewFeedback;
        ViewIncomeReport viewIncomeReport;
        Trainer_AssignTrainer trainerAssignTrainer;
        Trainer_RegisterNewTrainer trainerRegisterNewTrainer;
        Trainer_DeleteTrainer trainerDeleteTrainer;

        public AdminForm(string connString, string adminID, string password)
        {
            InitializeComponent();

            connectionString = connString;
            AdminID = adminID;
            Password = password;

            adminProfile = new AdminProfile(connectionString, AdminID, Password);
            validatePaymentAndAssign = new ValidatePaymentAndAssign(connectionString);
            viewFeedback = new ViewFeedback(connectionString);
            viewIncomeReport = new ViewIncomeReport(connectionString);
            trainerAssignTrainer = new Trainer_AssignTrainer(connectionString);
            trainerRegisterNewTrainer = new Trainer_RegisterNewTrainer(connectionString);
            trainerDeleteTrainer = new Trainer_DeleteTrainer(connectionString);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string insertAdminInfo = "SELECT AdminID, Name FROM Admin WHERE AdminID = @adminID";
            SqlCommand insertAdminInfoCommand = new SqlCommand(insertAdminInfo, con);
            insertAdminInfoCommand.Parameters.AddWithValue("@adminID", AdminID);
            SqlDataReader rd = insertAdminInfoCommand.ExecuteReader();
            while (rd.Read())
            {
                lblAdminID.Text = rd.GetString(0);
                lblAdminName.Text = rd.GetString(1);
            }
            rd.Close();
            con.Close();


            this.Controls.Add(adminProfile);
            adminProfile.Location = new Point(186, 272);
            adminProfile.Visible = false;

            adminProfile.Clear_and_Reset(AdminID);

            this.Controls.Add(validatePaymentAndAssign);
            validatePaymentAndAssign.Location = new Point(186, 0);
            validatePaymentAndAssign.Visible = false;

            this.Controls.Add(viewFeedback);
            viewFeedback.Location = new Point(186, 0);
            viewFeedback.Visible = false;

            this.Controls.Add(viewIncomeReport);
            viewIncomeReport.Location = new Point(186, 0);
            viewIncomeReport.Visible = false;

            this.Controls.Add(trainerAssignTrainer);
            trainerAssignTrainer.Location = new Point(186, 0);
            trainerAssignTrainer.Visible = false;

            this.Controls.Add(trainerRegisterNewTrainer);
            trainerRegisterNewTrainer.Location = new Point(186, 0);
            trainerRegisterNewTrainer.Visible = false;

            this.Controls.Add(trainerDeleteTrainer);
            trainerDeleteTrainer.Location = new Point(186, 0);
            trainerDeleteTrainer.Visible = false;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            adminProfile.Visible = false;
            validatePaymentAndAssign.Visible = false;
            viewFeedback.Visible = false;
            viewIncomeReport.Visible = false;
            trainerAssignTrainer.Visible = false;
            trainerRegisterNewTrainer.Visible = false;
            trainerDeleteTrainer.Visible = false;
        }

        private void btnIncomeReport_Click(object sender, EventArgs e)
        {
            viewIncomeReport.Visible = true;
            viewIncomeReport.BringToFront();
            adminProfile.Visible = false;
            validatePaymentAndAssign.Visible = false;
            viewFeedback.Visible = false;
            trainerAssignTrainer.Visible = false;
            trainerRegisterNewTrainer.Visible = false;
            trainerDeleteTrainer.Visible = false;
        }

        private void btnValidatePayment_Click(object sender, EventArgs e)
        {
            validatePaymentAndAssign.Visible = true;
            validatePaymentAndAssign.BringToFront();
            adminProfile.Visible = false;
            viewFeedback.Visible = false;
            viewIncomeReport.Visible = false;
            trainerAssignTrainer.Visible = false;
            trainerRegisterNewTrainer.Visible = false;
            trainerDeleteTrainer.Visible = false;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            viewFeedback.Visible = true;
            viewFeedback.BringToFront();
            adminProfile.Visible = false;
            validatePaymentAndAssign.Visible = false;
            viewIncomeReport.Visible = false;
            trainerAssignTrainer.Visible = false;
            trainerRegisterNewTrainer.Visible = false;
            trainerDeleteTrainer.Visible = false;
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            adminProfile.Visible = true;
            adminProfile.BringToFront();
            validatePaymentAndAssign.Visible = false;
            viewFeedback.Visible = false;
            viewIncomeReport.Visible = false;
            trainerAssignTrainer.Visible = false;
            trainerRegisterNewTrainer.Visible = false;
            trainerDeleteTrainer.Visible = false;
        }

        private void btnAssignTrainer_Click(object sender, EventArgs e)
        {
            trainerAssignTrainer.Visible = true;
            trainerAssignTrainer.BringToFront();
            adminProfile.Visible = false;
            validatePaymentAndAssign.Visible = false;
            viewFeedback.Visible = false;
            viewIncomeReport.Visible = false;
            trainerRegisterNewTrainer.Visible = false;
            trainerDeleteTrainer.Visible = false;
        }

        private void btnRegisterTrainer_Click(object sender, EventArgs e)
        {
            trainerRegisterNewTrainer.Visible = true;
            trainerRegisterNewTrainer.BringToFront();
            adminProfile.Visible = false;
            validatePaymentAndAssign.Visible = false;
            viewFeedback.Visible = false;
            viewIncomeReport.Visible = false;
            trainerAssignTrainer.Visible = false;
            trainerDeleteTrainer.Visible = false;
        }

        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            trainerDeleteTrainer.Visible = true;
            trainerDeleteTrainer.BringToFront();
            adminProfile.Visible = false;
            validatePaymentAndAssign.Visible = false;
            viewFeedback.Visible = false;
            viewIncomeReport.Visible = false;
            trainerAssignTrainer.Visible = false;
            trainerRegisterNewTrainer.Visible = false;
        }
    }
}
