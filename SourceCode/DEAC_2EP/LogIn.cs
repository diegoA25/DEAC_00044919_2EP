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
            current = new MenuPrincipal();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            var users = ConexionBDD.ExecuteQuery("SELECT nomUser FROM PUBLIC.USER");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = usersCombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT tipoUser FROM USER WHERE nomCom = '{comboBox1.SelectedItem.ToString()}'";

            var dt = ConexionBDD.ExecuteQuery(query);

            if (dt.Equals("Administrador"))
            {
                tableLayoutPanel1.Controls.Remove(current);
                current = new MenuPrincipal();
                tableLayoutPanel1.Controls.Add(current);
            }
            else if (dt.Equals("Comun"))
            {
                tableLayoutPanel1.Controls.Remove(current);
                current = new MenuPrincipalComun();
                tableLayoutPanel1.Controls.Add(current);
            }
        }
    }
}