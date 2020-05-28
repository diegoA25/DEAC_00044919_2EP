using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEAC_2EP
{
  public partial class Form1 : Form
  {
    private UserControl current = null;
    public Form1()
    {
      InitializeComponent();
      current =  new Register();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Remove(current);
      current = new Register();
      tableLayoutPanel1.Controls.Add(current, 0, 1);
      tableLayoutPanel1.SetColumnSpan(current, 2);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Remove(current);
      current = new LogIn();
      tableLayoutPanel1.Controls.Add(current, 0, 1);
      tableLayoutPanel1.SetColumnSpan(current, 2);
    }
  }
}
