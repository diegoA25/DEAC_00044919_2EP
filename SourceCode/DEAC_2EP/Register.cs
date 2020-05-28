using System;
using System.Windows.Forms;

namespace DEAC_2EP
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar vacio este campo!");
            }
            else
            {
                try
                {
                    bool dato = false;
                    if (textBox4.Text.Equals("Administrador"))
                    {
                        dato = true;
                    }
                    string sql = $"INSERT INTO APPUSER(fullname, username, password, userType) VALUES('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', {dato})";
                    ConexionBDD.ExecuteNonQuery(sql);
                    
                    MessageBox.Show("Nuevo usuario registrado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }
    }
}