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
    public partial class Trainer_DeleteTrainer : UserControl
    {
        string connectionString;

        public Trainer_DeleteTrainer(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void RefreshTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Trainer.TrainerID, Trainer.Name, Trainer.ContactNumber, Trainer.Email, Trainer_Module.ModuleCode FROM Trainer INNER JOIN Trainer_Module ON Trainer.TrainerID = Trainer_Module.TrainerID", con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridTrainerList.DataSource = dataTable;
            datagridTrainerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Clear()
        {
            listSelectedTrainers.Items.Clear();
        }

        List<string> ToBeRemovedTrainer = new List<string>();

        private void Trainer_DeleteTrainer_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void datagridTrainerList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridTrainerList.Rows[e.RowIndex];

            string trainerName = selectedRow.Cells["Name"].Value.ToString();
            string trainerID = selectedRow.Cells["TrainerID"].Value.ToString();

            if (!listSelectedTrainers.Items.Contains(trainerID + " " + trainerName))
            {
                listSelectedTrainers.Items.Add(trainerID + " " + trainerName);
            }
        }

        private void listSelectedTrainers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listSelectedTrainers.Items.Remove(listSelectedTrainers.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (datagridTrainerList.Rows.Count != 0)
            {
                if (listSelectedTrainers.Items.Count == 0)
                {
                    MessageBox.Show("Error: No trainer selected to remove.");
                }
                else
                {
                    bool Error = false;
                    ToBeRemovedTrainer.Clear();

                    foreach (string Trainer in listSelectedTrainers.Items)
                    {
                        ToBeRemovedTrainer.Add(Trainer.ToString().Substring(0, 8));
                    }

                    foreach (string toBeRemovedTrainer in ToBeRemovedTrainer)
                    {
                        Trainers removeTrainer = new Trainers(toBeRemovedTrainer);
                        removeTrainer.DeleteTrainer(connectionString, out Error);
                    }

                    if (Error == true)
                    {

                        MessageBox.Show("Removal Unsuccessful.");
                        RefreshTable();
                        Clear();
                    }
                    else
                    {
                        foreach (string toBeRemoveUser in ToBeRemovedTrainer)
                        {
                            LoginUsers removeUser = new LoginUsers(toBeRemoveUser);
                            removeUser.removeUser(connectionString);
                        }
                        MessageBox.Show("The Trainer(s) you have selected have been removed successfully.");
                        RefreshTable();
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no trainer with assigned module. Please assign trainers with module(s).");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Clear();
            this.Visible = false;
        }

        private void Trainer_DeleteTrainer_VisibleChanged(object sender, EventArgs e)
        {
            RefreshTable();
            Clear();
        }
    }
}
