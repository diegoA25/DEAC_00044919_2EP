using System;
using System.Windows.Forms;

namespace DEAC_2EP
{
    public partial class Empresas : UserControl
    {
        public Empresas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("No debe quedar vacio!");
            }
            else
            {
                try
                {
                    string sql =
                        $"INSERT INTO BUSINESS(name, description) VALUES('{textBox3.Text}', '{textBox4.Text}')";
                    ConexionBDD.ExecuteNonQuery(sql);

                    MessageBox.Show("Se agrego una empresa!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("No debe quedar vacio!");
            }
            else
            {
                try
                {
                    string sql = $"DELETE FROM BUSINESS WHERE idBusiness=('{textBox2.Text.ToString()}')";
                    ConexionBDD.ExecuteNonQuery(sql);

                    MessageBox.Show("Empresa Eliminada!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}