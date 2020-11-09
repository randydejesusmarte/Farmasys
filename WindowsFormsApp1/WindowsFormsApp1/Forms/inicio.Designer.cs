namespace WindowsFormsApp1
{
    partial class inicio
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
            this.screen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btfact = new System.Windows.Forms.Button();
            this.btinventario = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btinicio = new System.Windows.Forms.Button();
            this.drager = new System.Windows.Forms.Panel();
            this.pimini = new System.Windows.Forms.PictureBox();
            this.pisize = new System.Windows.Forms.PictureBox();
            this.piclose = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.drager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.AutoSize = true;
            this.screen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screen.Controls.Add(this.panel1);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(136, 34);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(837, 479);
            this.screen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 479);
            this.panel1.TabIndex = 4;
            // 
            // welcom
            // 
            this.welcom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcom.AutoSize = true;
            this.welcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcom.Location = new System.Drawing.Point(250, 147);
            this.welcom.Name = "welcom";
            this.welcom.Size = new System.Drawing.Size(0, 73);
            this.welcom.TabIndex = 0;
            this.welcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btfact);
            this.panel2.Controls.Add(this.btinventario);
            this.panel2.Controls.Add(this.btbuscar);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btinicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 513);
            this.panel2.TabIndex = 2;
            // 
            // btfact
            // 
            this.btfact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfact.Location = new System.Drawing.Point(1, 169);
            this.btfact.Name = "btfact";
            this.btfact.Size = new System.Drawing.Size(132, 45);
            this.btfact.TabIndex = 11;
            this.btfact.Text = "FACTURACION";
            this.btfact.UseVisualStyleBackColor = true;
            this.btfact.Click += new System.EventHandler(this.btfact_Click);
            // 
            // btinventario
            // 
            this.btinventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinventario.Location = new System.Drawing.Point(1, 220);
            this.btinventario.Name = "btinventario";
            this.btinventario.Size = new System.Drawing.Size(132, 45);
            this.btinventario.TabIndex = 11;
            this.btinventario.Text = "INVENTARIO";
            this.btinventario.UseVisualStyleBackColor = true;
            this.btinventario.Click += new System.EventHandler(this.btinventario_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscar.Location = new System.Drawing.Point(1, 271);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(132, 45);
            this.btbuscar.TabIndex = 11;
            this.btbuscar.Text = "BUSCAR";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources._141_user_1;
            this.pictureBox4.Location = new System.Drawing.Point(1, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // btinicio
            // 
            this.btinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinicio.Location = new System.Drawing.Point(1, 118);
            this.btinicio.Name = "btinicio";
            this.btinicio.Size = new System.Drawing.Size(132, 45);
            this.btinicio.TabIndex = 11;
            this.btinicio.Text = "INICIO";
            this.btinicio.UseVisualStyleBackColor = true;
            this.btinicio.Click += new System.EventHandler(this.btinicio_Click);
            // 
            // drager
            // 
            this.drager.Controls.Add(this.pimini);
            this.drager.Controls.Add(this.pisize);
            this.drager.Controls.Add(this.piclose);
            this.drager.Dock = System.Windows.Forms.DockStyle.Top;
            this.drager.Location = new System.Drawing.Point(136, 0);
            this.drager.Name = "drager";
            this.drager.Size = new System.Drawing.Size(837, 34);
            this.drager.TabIndex = 3;
            this.drager.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drager_MouseDown);
            // 
            // pimini
            // 
            this.pimini.Dock = System.Windows.Forms.DockStyle.Right;
            this.pimini.Image = global::WindowsFormsApp1.Properties.Resources._095_inbox;
            this.pimini.Location = new System.Drawing.Point(732, 0);
            this.pimini.Name = "pimini";
            this.pimini.Size = new System.Drawing.Size(35, 34);
            this.pimini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pimini.TabIndex = 2;
            this.pimini.TabStop = false;
            this.pimini.Click += new System.EventHandler(this.pimini_Click);
            // 
            // pisize
            // 
            this.pisize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pisize.Enabled = false;
            this.pisize.Image = global::WindowsFormsApp1.Properties.Resources._123_expand;
            this.pisize.Location = new System.Drawing.Point(767, 0);
            this.pisize.Name = "pisize";
            this.pisize.Size = new System.Drawing.Size(35, 34);
            this.pisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pisize.TabIndex = 1;
            this.pisize.TabStop = false;
            this.pisize.Click += new System.EventHandler(this.pisize_Click);
            // 
            // piclose
            // 
            this.piclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.piclose.Image = global::WindowsFormsApp1.Properties.Resources._058_power_button;
            this.piclose.Location = new System.Drawing.Point(802, 0);
            this.piclose.Name = "piclose";
            this.piclose.Size = new System.Drawing.Size(35, 34);
            this.piclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclose.TabIndex = 0;
            this.piclose.TabStop = false;
            this.piclose.Click += new System.EventHandler(this.piclose_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 513);
            this.Controls.Add(this.welcom);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.drager);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.drager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel drager;
        private System.Windows.Forms.PictureBox piclose;
        private System.Windows.Forms.PictureBox pisize;
        private System.Windows.Forms.PictureBox pimini;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btinicio;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button btinventario;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label welcom;
        private System.Windows.Forms.Button btfact;
    }
}