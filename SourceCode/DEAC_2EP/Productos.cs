using System;
using System.Windows.Forms;

namespace DEAC_2EP
{
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar vacio este campo!");
            }
            else
            {
                try
                {
                    string sql = $"INSERT INTO PRODUCT(name) VALUES('{textBox1.Text})";
                    ConexionBDD.ExecuteNonQuery(sql);
                    
                    MessageBox.Show("Nuevo producto registrado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar vacio este campo!");
            }
            else
            {
                try
                {
                    string sql = $"DELETE FROM PRODUCT WHERE idProduct='{textBox2.Text}'";
                    ConexionBDD.ExecuteNonQuery(sql);
                    
                    MessageBox.Show("Nuevo producto registrado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }
    }
}