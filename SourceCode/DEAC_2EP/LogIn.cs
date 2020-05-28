using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DEAC_2EP
{
    public partial class LogIn : UserControl
    {
        private UserControl current = null;
        public LogIn()
        {
            InitializeComponent();
            current = new MenuPrincipalComun();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            var users = ConexionBDD.ExecuteQuery("SELECT username FROM APPUSER");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = usersCombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new MenuPrincipalComun();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current, 2);
            tableLayoutPanel1.SetRowSpan(current, 2);
        }
    }
}