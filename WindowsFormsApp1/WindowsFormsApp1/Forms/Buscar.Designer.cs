namespace WindowsFormsApp1
{
    partial class Buscar
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
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btfilter = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btfilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmantenimiento
            // 
            this.dgvmantenimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvmantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmantenimiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvmantenimiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvmantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmantenimiento.Location = new System.Drawing.Point(0, 36);
            this.dgvmantenimiento.Name = "dgvmantenimiento";
            this.dgvmantenimiento.Size = new System.Drawing.Size(853, 443);
            this.dgvmantenimiento.TabIndex = 20;
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(86, 6);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(724, 24);
            this.txtnom.TabIndex = 16;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // btfilter
            // 
            this.btfilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btfilter.Image = global::WindowsFormsApp1.Properties.Resources._102_filter;
            this.btfilter.Location = new System.Drawing.Point(816, 5);
            this.btfilter.Name = "btfilter";
            this.btfilter.Size = new System.Drawing.Size(25, 25);
            this.btfilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btfilter.TabIndex = 21;
            this.btfilter.TabStop = false;
            this.btfilter.Tag = "1";
            this.toolTip1.SetToolTip(this.btfilter, "Filtrar por Nombre, Codigo, Descripcion.");
            this.btfilter.Click += new System.EventHandler(this.btfilter_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informacion";
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 479);
            this.Controls.Add(this.btfilter);
            this.Controls.Add(this.dgvmantenimiento);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btfilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btfilter;
        private System.Windows.Forms.DataGridView dgvmantenimiento;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}