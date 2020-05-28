using System;
using System.Data;
using System.Windows.Forms;

namespace DEAC_2EP
{
    public partial class VerPed : UserControl
    {
        public VerPed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No debe estar vacio!");
            }
            else
            {
                try
                {
                    var dt = ConexionBDD.ExecuteQuery($"SELECT pro.idProducto, dir.idAddress" +
                                                      "FROM PRODUCTO pro, DIRECCION dir, ORDEN or" +
                                                      $"WHERE pro.idProducto = '{textBox1.Text}'" +
                                                      $"AND dir.idAddress = or.idAddress");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error!");
                }
            }
        }
    }
}