using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APU_Programming_Cafe.Login;

namespace APU_Programming_Cafe.Trainer
{
    public partial class TrainerForm : Form
    {
        public TrainerForm()
        {
            InitializeComponent();
        }

        private void TrainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {




            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            
        }
    }
}
