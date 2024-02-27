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
    public partial class ValidatePaymentAndAssign : UserControl
    {
        string connectionString;
        string paymentEvidence = "";

        public ValidatePaymentAndAssign(string connString)
        {
            connectionString = connString;
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int ErrorCount = 0;
            string Error = "";

            if (lblStudentID.Text == string.Empty)
            {
                ErrorCount++;
                Error += "Error: No student selected to assign trainer and validate payment. Please try again.\n";
            }
            if (cboTrainerID.SelectedIndex == -1)
            {
                ErrorCount++;
                Error += "Error: No trainer selected to assign student with. Please try again.\n";
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                if (paymentEvidence == "")
                {
                    MessageBox.Show("Error: Selected student did not provide evidence of payment. Thus, unable to validate his/her payment.\n");
                }
                else
                {
                    Students assignStudentWithTrainer = new Students(lblStudentID.Text, lblModuleCode.Text, cboTrainerID.SelectedItem.ToString().Substring(0, 8), paymentEvidence);
                    assignStudentWithTrainer.Intake = lblIntake.Text;

                    bool validationSuccessful = assignStudentWithTrainer.validatePayment(connectionString);
                    bool assignTrainerIDSuccessful = assignStudentWithTrainer.assignTrainer(connectionString);

                    if (validationSuccessful == true && assignTrainerIDSuccessful == true)
                    {
                        MessageBox.Show("Payment validated and trainer assigned successfully.");
                        btnRefresh.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error: Unable to validate payment or assign trainer. Please try again.");
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblStudentID.Text = string.Empty;
            lblStudentName.Text = string.Empty;
            lblModuleCode.Text = string.Empty;
            lblIntake.Text = string.Empty;
            cboTrainerID.Text = string.Empty;
            cboTrainerID.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string displayPaymentQuery = "SELECT Payment.StudentID, Student.Name, Payment.ModuleCode, Payment.Intake, Payment.PaymentMonth, Payment.PaymentAmount, Payment.InvoiceNumber, Payment.PaymentDate, Payment.Validated FROM Payment INNER JOIN Student ON Payment.StudentID = Student.StudentID;";
            SqlDataAdapter adapter = new SqlDataAdapter(displayPaymentQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridTrainerList.DataSource = dataTable;
            datagridTrainerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ValidatePaymentAndAssign_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            btnRefresh.PerformClick();
        }

        private void ValidatePaymentAndAssign_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void datagridTrainerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cboTrainerID.SelectedIndex = -1;
                cboTrainerID.Items.Clear();
                DataGridViewRow selectedRow = datagridTrainerList.Rows[e.RowIndex];
                string studentID = selectedRow.Cells["StudentID"].Value.ToString();
                string studentName = selectedRow.Cells["Name"].Value.ToString();
                string moduleCode = selectedRow.Cells["ModuleCode"].Value.ToString();
                string intake = selectedRow.Cells["Intake"].Value.ToString();
                paymentEvidence = selectedRow.Cells["InvoiceNumber"].Value.ToString();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string fetchTrainerIDQuery = "SELECT DISTINCT Trainer_Module.TrainerID, Trainer.Name FROM Trainer_Module INNER JOIN Trainer ON Trainer_Module.TrainerID = Trainer.TrainerID WHERE Trainer_Module.ModuleCode = @moduleCode";
                SqlCommand fetchTrainerID = new SqlCommand(fetchTrainerIDQuery, connection);
                fetchTrainerID.Parameters.AddWithValue("@moduleCode", moduleCode);
                SqlDataReader readerTrainerID = fetchTrainerID.ExecuteReader();
                while (readerTrainerID.Read())
                {
                    string trainerID = readerTrainerID.GetString(0);
                    string trainerName = readerTrainerID.GetString(1);
                    if (!cboTrainerID.Items.Contains(trainerID + " " + trainerName))
                    {
                        cboTrainerID.Items.Add(trainerID + " " + trainerName);
                    }
                }
                readerTrainerID.Close();
                connection.Close();

                lblStudentID.Text = studentID;
                lblStudentName.Text = studentName;
                lblModuleCode.Text = moduleCode;
                lblIntake.Text = intake;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (lblStudentID.Text == string.Empty)
            {
                MessageBox.Show("Error: No student selected to assign trainer and validate payment. Please try again.");
            }
            else
            {
                if (paymentEvidence == "")
                {
                    MessageBox.Show("Error: Selected student did not provide evidence of payment. Thus, unable to validate nor reject his/her payment.\n");
                }
                else
                {
                    Students rejectPayment = new Students(lblStudentID.Text, lblModuleCode.Text, paymentEvidence);
                    rejectPayment.Intake = lblIntake.Text;
                    string rejectionSuccessful = rejectPayment.rejectPayment(connectionString);
                    if (rejectionSuccessful == "true")
                    {
                        MessageBox.Show("Payment successfully rejected.");
                        btnRefresh.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(rejectionSuccessful);
                        MessageBox.Show("Error: Unable to reject payment. Please try again.");
                    }
                }
            }
        }
    }
}
