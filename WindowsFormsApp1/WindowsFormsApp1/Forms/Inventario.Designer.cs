namespace WindowsFormsApp1
{
    partial class Inventario
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
            this.components = new System.ComponentModel.Container();
            this.dgvmantenimiento = new System.Windows.Forms.DataGridView();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.PictureBox();
            this.btedit = new System.Windows.Forms.PictureBox();
            this.btadd = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cgenerico = new System.Windows.Forms.CheckBox();
            this.mtxtfecha = new System.Windows.Forms.MaskedTextBox();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.cbempack = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmantenimiento
            // 
            this.dgvmantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmantenimiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvmantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmantenimiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvmantenimiento.Location = new System.Drawing.Point(0, 229);
            this.dgvmantenimiento.Name = "dgvmantenimiento";
            this.dgvmantenimiento.Size = new System.Drawing.Size(800, 221);
            this.dgvmantenimiento.TabIndex = 20;
            this.dgvmantenimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmantenimiento_CellContentClick);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(426, 51);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 19;
            this.txtcant.Tag = "4";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(423, 20);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 18;
            this.txtprecio.Tag = "3";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(38, 80);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(326, 130);
            this.txtdesc.TabIndex = 17;
            this.txtdesc.Tag = "2";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(73, 33);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(243, 20);
            this.txtnom.TabIndex = 16;
            this.txtnom.Tag = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // btdelete
            // 
            this.btdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdelete.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_bin_96px;
            this.btdelete.Location = new System.Drawing.Point(753, 188);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(35, 35);
            this.btdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btdelete.TabIndex = 21;
            this.btdelete.TabStop = false;
            this.toolTip1.SetToolTip(this.btdelete, "Eliminar");
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btedit.Image = global::WindowsFormsApp1.Properties.Resources.icons8_edit_file_96px;
            this.btedit.Location = new System.Drawing.Point(712, 188);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(35, 35);
            this.btedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btedit.TabIndex = 22;
            this.btedit.TabStop = false;
            this.toolTip1.SetToolTip(this.btedit, "Editar");
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btadd
            // 
            this.btadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btadd.Image = global::WindowsFormsApp1.Properties.Resources.icons8_add_96px;
            this.btadd.Location = new System.Drawing.Point(671, 188);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(35, 35);
            this.btadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btadd.TabIndex = 23;
            this.btadd.TabStop = false;
            this.toolTip1.SetToolTip(this.btadd, "Agregar");
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informacion";
            // 
            // tcodigo
            // 
            this.tcodigo.Location = new System.Drawing.Point(73, 8);
            this.tcodigo.Name = "tcodigo";
            this.tcodigo.Size = new System.Drawing.Size(100, 20);
            this.tcodigo.TabIndex = 24;
            this.tcodigo.Tag = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo de Empaque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ubicacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Fecha Exp";
            // 
            // cgenerico
            // 
            this.cgenerico.AutoSize = true;
            this.cgenerico.Location = new System.Drawing.Point(374, 118);
            this.cgenerico.Name = "cgenerico";
            this.cgenerico.Size = new System.Drawing.Size(61, 17);
            this.cgenerico.TabIndex = 29;
            this.cgenerico.Tag = "6";
            this.cgenerico.Text = "Original";
            this.cgenerico.UseVisualStyleBackColor = true;
            // 
            // mtxtfecha
            // 
            this.mtxtfecha.Location = new System.Drawing.Point(649, 49);
            this.mtxtfecha.Mask = "00/00/0000";
            this.mtxtfecha.Name = "mtxtfecha";
            this.mtxtfecha.Size = new System.Drawing.Size(97, 20);
            this.mtxtfecha.TabIndex = 31;
            this.mtxtfecha.Tag = "8";
            this.mtxtfecha.ValidatingType = typeof(System.DateTime);
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(646, 23);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(100, 20);
            this.txtubicacion.TabIndex = 32;
            this.txtubicacion.Tag = "7";
            // 
            // cbempack
            // 
            this.cbempack.FormattingEnabled = true;
            this.cbempack.Location = new System.Drawing.Point(468, 80);
            this.cbempack.Name = "cbempack";
            this.cbempack.Size = new System.Drawing.Size(121, 21);
            this.cbempack.TabIndex = 33;
            this.cbempack.Tag = "5";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbempack);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.mtxtfecha);
            this.Controls.Add(this.cgenerico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tcodigo);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.dgvmantenimiento);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btdelete;
        private System.Windows.Forms.PictureBox btedit;
        private System.Windows.Forms.PictureBox btadd;
        private System.Windows.Forms.DataGridView dgvmantenimiento;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cgenerico;
        private System.Windows.Forms.MaskedTextBox mtxtfecha;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.ComboBox cbempack;
    }
}