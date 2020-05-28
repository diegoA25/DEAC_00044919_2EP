namespace DEAC_2EP
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.44513F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.55487F));
      this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.88331F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.11669F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 617);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.button1.Location = new System.Drawing.Point(3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(394, 92);
      this.button1.TabIndex = 0;
      this.button1.Text = "Log In";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.button2.BackColor = System.Drawing.Color.White;
      this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button2.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.button2.Location = new System.Drawing.Point(403, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(405, 92);
      this.button2.TabIndex = 1;
      this.button2.Text = "Register";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(811, 617);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
  }
}

