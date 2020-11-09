namespace WindowsFormsApp1
{
    partial class usuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtnickname = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.cpuesto = new System.Windows.Forms.ComboBox();
            this.csexo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._150_add_user;
            this.pictureBox1.Location = new System.Drawing.Point(274, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Clave de administrador";
            // 
            // txtpass
            // 
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(113, 131);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(215, 20);
            this.txtpass.TabIndex = 17;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtnickname
            // 
            this.txtnickname.Enabled = false;
            this.txtnickname.Location = new System.Drawing.Point(113, 101);
            this.txtnickname.Name = "txtnickname";
            this.txtnickname.Size = new System.Drawing.Size(215, 20);
            this.txtnickname.TabIndex = 16;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(113, 71);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(215, 20);
            this.txtnombre.TabIndex = 15;
            // 
            // adminpass
            // 
            this.adminpass.Location = new System.Drawing.Point(143, 30);
            this.adminpass.Name = "adminpass";
            this.adminpass.Size = new System.Drawing.Size(131, 20);
            this.adminpass.TabIndex = 14;
            this.adminpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cpuesto
            // 
            this.cpuesto.Enabled = false;
            this.cpuesto.FormattingEnabled = true;
            this.cpuesto.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.cpuesto.Location = new System.Drawing.Point(113, 191);
            this.cpuesto.Name = "cpuesto";
            this.cpuesto.Size = new System.Drawing.Size(215, 21);
            this.cpuesto.TabIndex = 27;
            // 
            // csexo
            // 
            this.csexo.Enabled = false;
            this.csexo.FormattingEnabled = true;
            this.csexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.csexo.Location = new System.Drawing.Point(113, 162);
            this.csexo.Name = "csexo";
            this.csexo.Size = new System.Drawing.Size(212, 21);
            this.csexo.TabIndex = 28;
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 293);
            this.Controls.Add(this.csexo);
            this.Controls.Add(this.cpuesto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtnickname);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.adminpass);
            this.Name = "usuario";
            this.Text = "usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtnickname;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox adminpass;
        private System.Windows.Forms.ComboBox cpuesto;
        private System.Windows.Forms.ComboBox csexo;
    }
}