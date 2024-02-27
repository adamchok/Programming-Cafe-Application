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
    public partial class ViewIncomeReport : UserControl
    {
        string connectionString;
        public ViewIncomeReport(string connString)
        {
            connectionString = connString;
            InitializeComponent();
        }

        private void btnTrainerID_Click(object sender, EventArgs e)
        {
            if (cboMonth.SelectedIndex != -1 && cboYear.SelectedIndex != -1)
            {
                string month = cboMonth.SelectedItem.ToString();
                string year = cboYear.SelectedItem.ToString();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string trainerMonthlyReportQuery = @"
                SELECT Trainer.TrainerID, SUM(Payment.PaymentAmount) AS TotalImcome
                FROM Trainer
                JOIN Enrolment ON Trainer.TrainerID = Enrolment.TrainerID
                JOIN Payment ON Enrolment.StudentID = Payment.StudentID AND Enrolment.ModuleCode = Payment.ModuleCode
                WHERE Payment.Validated = 'Yes' AND Payment.PaymentMonth = @month AND Payment.Intake LIKE '%' + @year + '%'
                GROUP BY Trainer.TrainerID;
                ";

                SqlCommand trainerMonthlyReport = new SqlCommand(trainerMonthlyReportQuery, connection);
                trainerMonthlyReport.Parameters.AddWithValue("@month", month);
                trainerMonthlyReport.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(trainerMonthlyReport);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                datagridIncomeReport.DataSource = dataTable;
                datagridIncomeReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error: Month and Year is not selected. Both must be selected to generate a monthly income report.");
            }
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            if (cboMonth.SelectedIndex != -1 && cboYear.SelectedIndex != -1)
            {
                string month = cboMonth.SelectedItem.ToString();
                string year = cboYear.SelectedItem.ToString();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string levelMonthlyReportQuery = @"
                SELECT Module.Level, SUM(Payment.PaymentAmount) AS Total_Income
                FROM Module
                JOIN Enrolment ON Module.ModuleCode = Enrolment.ModuleCode
                JOIN Payment ON Enrolment.StudentID = Payment.StudentID AND Enrolment.ModuleCode = Payment.ModuleCode
                WHERE Payment.Validated = 'Yes' AND Payment.PaymentMonth = @month AND Payment.Intake LIKE '%' + @year + '%'
                GROUP BY Module.Level;
                ";

                SqlCommand levelMonthlyReport = new SqlCommand(levelMonthlyReportQuery, connection);
                levelMonthlyReport.Parameters.AddWithValue("@month", month);
                levelMonthlyReport.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(levelMonthlyReport);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                datagridIncomeReport.DataSource = dataTable;
                datagridIncomeReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error: Month and Year is not selected. Both must be selected to generate a monthly income report.");
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            if (cboMonth.SelectedIndex != -1 && cboYear.SelectedIndex != -1)
            {
                string month = cboMonth.SelectedItem.ToString();
                string year = cboYear.SelectedItem.ToString();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string moduleMonthlyReportQuery = @"
                SELECT Module.ModuleName, SUM(Payment.PaymentAmount) AS Total_Income
                FROM Module
                JOIN Enrolment ON Module.ModuleCode = Enrolment.ModuleCode
                JOIN Payment ON Enrolment.StudentID = Payment.StudentID AND Enrolment.ModuleCode = Payment.ModuleCode
                WHERE Payment.Validated = 'Yes' AND Payment.PaymentMonth = @month AND Payment.Intake LIKE '%' + @year + '%'
                GROUP BY Module.ModuleName;
                ";

                SqlCommand moduleMonthlyReport = new SqlCommand(moduleMonthlyReportQuery, connection);
                moduleMonthlyReport.Parameters.AddWithValue("@month", month);
                moduleMonthlyReport.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(moduleMonthlyReport);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                datagridIncomeReport.DataSource = dataTable;
                datagridIncomeReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error: Month and Year is not selected. Both must be selected to generate a monthly income report.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            datagridIncomeReport.DataSource = null;
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            datagridIncomeReport.DataSource = null;
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            this.Visible = false;
        }

        private void ViewIncomeReport_VisibleChanged(object sender, EventArgs e)
        {
            datagridIncomeReport.DataSource = null;
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
        }
    }
}
