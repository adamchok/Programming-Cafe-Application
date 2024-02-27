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

namespace APU_Programming_Cafe.Student
{
    public partial class frmPayment : UserControl
    {
        string connectionString;
        string StudentID;
        public frmPayment(string connString, string studentID)
        {
            connectionString = connString;
            StudentID = studentID;
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            btnRefreshFee.PerformClick();
        }

        private void btnRefreshFee_Click(object sender, EventArgs e)
        {
            paymentDatePicker.Format = DateTimePickerFormat.Custom;
            paymentDatePicker.CustomFormat = "dd-MM-yyyy";
            paymentDatePicker.Value = DateTime.Today;
            lblRMPaid.Text = "";
            lblRMBalance.Text = "";
            txtboxInvoice.Text = "";
            lblCurrentInvoiceNumber.Text = string.Empty;
            lblStatus.Text = string.Empty;
            cboIntake.Items.Clear();
            cboModuleCode.Items.Clear();
            cboPaymentMonth.Items.Clear();
            cboIntake.Enabled = false;
            cboPaymentMonth.Enabled = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string fetchModuleCode = "SELECT ModuleCode FROM Payment WHERE StudentID = @studentID;";
            SqlCommand insertModuleCode = new SqlCommand(fetchModuleCode, connection);
            insertModuleCode.Parameters.AddWithValue("@studentID", StudentID);

            SqlDataReader reader = insertModuleCode.ExecuteReader();
            while (reader.Read())
            {
                string moduleCode = reader.GetString(0);

                if (!cboModuleCode.Items.Contains(moduleCode))
                {
                    cboModuleCode.Items.Add(moduleCode);
                }
            }
            reader.Close();
            connection.Close();
        }

        private void cboModuleCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRMBalance.Text = string.Empty;
            lblRMPaid.Text = string.Empty;
            lblCurrentInvoiceNumber.Text = string.Empty;
            lblStatus.Text = string.Empty;
            cboIntake.Enabled = false;
            cboPaymentMonth.Enabled = false;


            if (cboModuleCode.SelectedIndex > -1)
            {
                string ModuleCode = cboModuleCode.SelectedItem.ToString();

                cboIntake.Items.Clear();
                cboPaymentMonth.Items.Clear();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string fetchOutStandingFee = "SELECT SUM(PaymentAmount) FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Validated = 'No';";
                SqlCommand insertOutStandingFee = new SqlCommand(fetchOutStandingFee, connection);
                insertOutStandingFee.Parameters.AddWithValue("@studentID", StudentID);
                insertOutStandingFee.Parameters.AddWithValue("@moduleCode", ModuleCode);
                SqlDataReader outStandingFeeReader = insertOutStandingFee.ExecuteReader();
                while (outStandingFeeReader.Read())
                {
                    if (!outStandingFeeReader.IsDBNull(0))
                    {
                        decimal balance = outStandingFeeReader.GetDecimal(0);
                        lblRMBalance.Text = $"RM {balance}";
                    }
                    else
                    {
                        lblRMBalance.Text = "RM 0";
                    }
                }
                outStandingFeeReader.Close();

                string fetchPaidFee = "SELECT SUM(PaymentAmount) FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Validated = 'Yes';";
                SqlCommand insertPaidFee = new SqlCommand(fetchPaidFee, connection);
                insertPaidFee.Parameters.AddWithValue("@studentID", StudentID);
                insertPaidFee.Parameters.AddWithValue("@moduleCode", ModuleCode);
                object paidFee = insertPaidFee.ExecuteScalar();
                if (paidFee != null && paidFee != DBNull.Value)
                {
                    decimal result = Convert.ToDecimal(paidFee);
                    lblRMPaid.Text = $"RM {result}";
                }
                else
                {
                    lblRMPaid.Text = "RM 0";
                }

                string fetchIntake = "SELECT Intake FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode";
                SqlCommand insertIntake = new SqlCommand(fetchIntake, connection);
                insertIntake.Parameters.AddWithValue("@studentID", StudentID);
                insertIntake.Parameters.AddWithValue("@moduleCode", ModuleCode);
                SqlDataReader intakeReader = insertIntake.ExecuteReader();
                while (intakeReader.Read())
                {
                    string intake = intakeReader.GetString(0);
                    if (!cboIntake.Items.Contains(intake))
                    {
                        cboIntake.Items.Add(intake);
                    }
                }
                intakeReader.Close();
                cboIntake.Enabled = true;
            }
            else
            {
                lblRMBalance.Text = string.Empty;
                lblRMPaid.Text = string.Empty;
                lblCurrentInvoiceNumber.Text = string.Empty;
                lblStatus.Text = string.Empty;
                cboIntake.Items.Clear();
                cboPaymentMonth.Items.Clear();
                cboIntake.Enabled = false;
                cboPaymentMonth.Enabled = false;
            }
        }

        private void cboIntake_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRMBalance.Text = string.Empty;
            lblRMPaid.Text = string.Empty;
            lblCurrentInvoiceNumber.Text = string.Empty;
            lblStatus.Text = string.Empty;

            if (cboIntake.SelectedIndex > -1)
            {
                string ModuleCode = cboModuleCode.SelectedItem.ToString();
                string Intake = cboIntake.SelectedItem.ToString();

                cboPaymentMonth.Items.Clear();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string fetchOutStandingFee = "SELECT SUM(PaymentAmount) FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake AND Validated = 'No';";
                SqlCommand insertOutStandingFee = new SqlCommand(fetchOutStandingFee, connection);
                insertOutStandingFee.Parameters.AddWithValue("@studentID", StudentID);
                insertOutStandingFee.Parameters.AddWithValue("@moduleCode", ModuleCode);
                insertOutStandingFee.Parameters.AddWithValue("@intake", Intake);
                SqlDataReader outStandingFeeReader = insertOutStandingFee.ExecuteReader();
                while (outStandingFeeReader.Read())
                {
                    if (!outStandingFeeReader.IsDBNull(0))
                    {
                        decimal balance = outStandingFeeReader.GetDecimal(0);
                        lblRMBalance.Text = $"RM {balance}";
                    }
                    else
                    {
                        lblRMBalance.Text = "RM 0";
                    }
                }
                outStandingFeeReader.Close();

                string fetchPaidFee = "SELECT SUM(PaymentAmount) FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake AND Validated = 'Yes';";
                SqlCommand insertPaidFee = new SqlCommand(fetchPaidFee, connection);
                insertPaidFee.Parameters.AddWithValue("@studentID", StudentID);
                insertPaidFee.Parameters.AddWithValue("@moduleCode", ModuleCode);
                insertPaidFee.Parameters.AddWithValue("@intake", Intake);
                object paidFee = insertPaidFee.ExecuteScalar();
                if (paidFee != null && paidFee != DBNull.Value)
                {
                    decimal result = Convert.ToDecimal(paidFee);
                    lblRMPaid.Text = $"RM {result}";
                }
                else
                {
                    lblRMPaid.Text = "RM 0";
                }

                string fetchPaymentMonth = "SELECT PaymentMonth FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake;";
                SqlCommand insertPaymentMonth = new SqlCommand(fetchPaymentMonth, connection);
                insertPaymentMonth.Parameters.AddWithValue("@studentID", StudentID);
                insertPaymentMonth.Parameters.AddWithValue("@moduleCode", ModuleCode);
                insertPaymentMonth.Parameters.AddWithValue("@intake", Intake);
                SqlDataReader paymentMonthReader = insertPaymentMonth.ExecuteReader();
                while (paymentMonthReader.Read())
                {
                    string month = paymentMonthReader.GetString(0);
                    if (!cboPaymentMonth.Items.Contains(month))
                    {
                        cboPaymentMonth.Items.Add(month);
                    }
                }
                paymentMonthReader.Close();
                cboPaymentMonth.Enabled = true;
            }
            else
            {
                lblRMBalance.Text = string.Empty;
                lblRMPaid.Text = string.Empty;
                lblCurrentInvoiceNumber.Text = string.Empty;
                lblStatus.Text = string.Empty;
                cboIntake.Items.Clear();
                cboPaymentMonth.Items.Clear();
                cboIntake.Enabled = false;
                cboPaymentMonth.Enabled = false;
            }
        }

        private void cboPaymentMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRMBalance.Text = string.Empty;
            lblRMPaid.Text = string.Empty;
            lblCurrentInvoiceNumber.Text = string.Empty;
            lblStatus.Text = string.Empty;

            if (cboIntake.SelectedIndex > -1)
            {
                string ModuleCode = cboModuleCode.SelectedItem.ToString();
                string Intake = cboIntake.SelectedItem.ToString();
                string PaymentMonth = cboPaymentMonth.SelectedItem.ToString();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string fetchOutStandingFee = "SELECT SUM(PaymentAmount) FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake AND PaymentMonth = @month AND Validated = 'No';";
                SqlCommand insertOutStandingFee = new SqlCommand(fetchOutStandingFee, connection);
                insertOutStandingFee.Parameters.AddWithValue("@studentID", StudentID);
                insertOutStandingFee.Parameters.AddWithValue("@moduleCode", ModuleCode);
                insertOutStandingFee.Parameters.AddWithValue("@intake", Intake);
                insertOutStandingFee.Parameters.AddWithValue("@month", PaymentMonth);
                SqlDataReader outStandingFeeReader = insertOutStandingFee.ExecuteReader();
                while (outStandingFeeReader.Read())
                {
                    if (!outStandingFeeReader.IsDBNull(0))
                    {
                        decimal balance = outStandingFeeReader.GetDecimal(0);
                        lblRMBalance.Text = $"RM {balance}";
                    }
                    else
                    {
                        lblRMBalance.Text = "RM 0";
                    }
                }
                outStandingFeeReader.Close();

                string fetchPaidFee = "SELECT SUM(PaymentAmount) FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake AND PaymentMonth = @month AND Validated = 'Yes';";
                SqlCommand insertPaidFee = new SqlCommand(fetchPaidFee, connection);
                insertPaidFee.Parameters.AddWithValue("@studentID", StudentID);
                insertPaidFee.Parameters.AddWithValue("@moduleCode", ModuleCode);
                insertPaidFee.Parameters.AddWithValue("@intake", Intake);
                insertPaidFee.Parameters.AddWithValue("@month", PaymentMonth);
                object paidFee = insertPaidFee.ExecuteScalar();
                if (paidFee != null && paidFee != DBNull.Value)
                {
                    decimal result = Convert.ToDecimal(paidFee);
                    lblRMPaid.Text = $"RM {result}";
                }
                else
                {
                    lblRMPaid.Text = "RM 0";
                }

                string fetchInvoiceNumber = "SELECT InvoiceNumber, Validated FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake AND PaymentMonth = @month;";
                SqlCommand insertInvoiceNumber = new SqlCommand(fetchInvoiceNumber, connection);
                insertInvoiceNumber.Parameters.AddWithValue("@studentID", StudentID);
                insertInvoiceNumber.Parameters.AddWithValue("@moduleCode", ModuleCode);
                insertInvoiceNumber.Parameters.AddWithValue("@intake", Intake);
                insertInvoiceNumber.Parameters.AddWithValue("@month", PaymentMonth);
                SqlDataReader invoiceNumberReader = insertInvoiceNumber.ExecuteReader();
                while (invoiceNumberReader.Read())
                {
                    if (invoiceNumberReader.IsDBNull(0))
                    {
                        lblCurrentInvoiceNumber.Text = "No invoice number";
                    }
                    else
                    {
                        string invoiceNumber = invoiceNumberReader.GetString(0);
                        lblCurrentInvoiceNumber.Text = invoiceNumber;
                    }
                    string status = invoiceNumberReader.GetString(1);
                    if (status == "Yes")
                    {
                        lblStatus.Text = "Approved";
                    }
                    else
                    {
                        lblStatus.Text = "Pending";
                    }
                }
                invoiceNumberReader.Close();
            }
            else
            {
                lblRMBalance.Text = string.Empty;
                lblRMPaid.Text = string.Empty;
                lblCurrentInvoiceNumber.Text = string.Empty;
                lblStatus.Text = string.Empty;
                cboIntake.Items.Clear();
                cboPaymentMonth.Items.Clear();
                cboIntake.Enabled = false;
                cboPaymentMonth.Enabled = false;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            int ErrorCount = 0;
            string Error = "";

            if (cboPaymentMonth.SelectedIndex == -1)
            {
                ErrorCount++;
                Error += "Error: PaymentMonth not selected. Please try again.\n";
            }
            else
            {
                if (!lblCurrentInvoiceNumber.Text.Contains("No invoice number") && lblCurrentInvoiceNumber.Text != string.Empty)
                {
                    ErrorCount++;
                    Error += "Error: An invoice number was already inserted. Please contact the admin if there are any errors.\n";
                }
                else
                {
                    if (txtboxInvoice.Text.Length != 10 || !int.TryParse(txtboxInvoice.Text, out _))
                    {
                        ErrorCount++;
                        Error += "Error: Invalid invoice number. It should have a length of exactly 10 integer digits.\n";
                    }
                }
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                Students addStudentFeeEvidence = new Students();
                addStudentFeeEvidence.StudentID = StudentID;
                addStudentFeeEvidence.Intake = cboIntake.SelectedItem.ToString();
                addStudentFeeEvidence.ModuleCode = cboModuleCode.SelectedItem.ToString();
                addStudentFeeEvidence.InvoiceNumber = txtboxInvoice.Text.ToString();
                addStudentFeeEvidence.PaymentMonth = cboPaymentMonth.SelectedItem.ToString();
                addStudentFeeEvidence.PaymentDate = paymentDatePicker.Value.ToString("yyyy-MM-dd");

                string addSuccessful = addStudentFeeEvidence.addPaymentInfo(connectionString);
                if (addSuccessful.Contains("updated"))
                {
                    MessageBox.Show(addSuccessful);
                    btnRefreshFee.PerformClick();
                }
                else
                {
                    MessageBox.Show(addSuccessful);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnRefreshFee.PerformClick();
        }
    }
}
