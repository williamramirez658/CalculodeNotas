namespace CalculoNotas
{
    partial class Trash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trash));
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAlumnosBorrados = new System.Windows.Forms.DataGridView();
            this.menuiconos = new System.Windows.Forms.ToolStrip();
            this.tbsRecuperarAlumno = new System.Windows.Forms.ToolStripButton();
            this.tbsNuevoCodigo = new System.Windows.Forms.ToolStripButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosBorrados)).BeginInit();
            this.menuiconos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.label9.Location = new System.Drawing.Point(57, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estudiantes Eliminados";
            // 
            // dgvAlumnosBorrados
            // 
            this.dgvAlumnosBorrados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAlumnosBorrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlumnosBorrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosBorrados.Location = new System.Drawing.Point(64, 240);
            this.dgvAlumnosBorrados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlumnosBorrados.Name = "dgvAlumnosBorrados";
            this.dgvAlumnosBorrados.RowHeadersVisible = false;
            this.dgvAlumnosBorrados.RowHeadersWidth = 51;
            this.dgvAlumnosBorrados.Size = new System.Drawing.Size(1179, 242);
            this.dgvAlumnosBorrados.TabIndex = 19;
            // 
            // menuiconos
            // 
            this.menuiconos.BackColor = System.Drawing.Color.White;
            this.menuiconos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuiconos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsRecuperarAlumno,
            this.tbsNuevoCodigo});
            this.menuiconos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuiconos.Location = new System.Drawing.Point(0, 0);
            this.menuiconos.Name = "menuiconos";
            this.menuiconos.Padding = new System.Windows.Forms.Padding(0, 12, 1, 12);
            this.menuiconos.Size = new System.Drawing.Size(1259, 158);
            this.menuiconos.Stretch = true;
            this.menuiconos.TabIndex = 21;
            this.menuiconos.Text = "toolStrip1";
            // 
            // tbsRecuperarAlumno
            // 
            this.tbsRecuperarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbsRecuperarAlumno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsRecuperarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("tbsRecuperarAlumno.Image")));
            this.tbsRecuperarAlumno.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbsRecuperarAlumno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsRecuperarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsRecuperarAlumno.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tbsRecuperarAlumno.Name = "tbsRecuperarAlumno";
            this.tbsRecuperarAlumno.Size = new System.Drawing.Size(132, 132);
            this.tbsRecuperarAlumno.Text = "<";
            this.tbsRecuperarAlumno.ToolTipText = "Recuperar alumno";
            this.tbsRecuperarAlumno.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbsNuevoCodigo
            // 
            this.tbsNuevoCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbsNuevoCodigo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsNuevoCodigo.Enabled = false;
            this.tbsNuevoCodigo.Image = ((System.Drawing.Image)(resources.GetObject("tbsNuevoCodigo.Image")));
            this.tbsNuevoCodigo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsNuevoCodigo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsNuevoCodigo.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tbsNuevoCodigo.Name = "tbsNuevoCodigo";
            this.tbsNuevoCodigo.Size = new System.Drawing.Size(132, 132);
            this.tbsNuevoCodigo.Text = "<";
            this.tbsNuevoCodigo.ToolTipText = "Cambiar codigo";
            this.tbsNuevoCodigo.Click += new System.EventHandler(this.tbsNuevoCodigo_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(932, 169);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(177, 27);
            this.txtCode.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Escriba el código que a recuperar\r\n ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 545);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuiconos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvAlumnosBorrados);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Trash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trash";
            this.Activated += new System.EventHandler(this.Trash_Activated);
            this.Load += new System.EventHandler(this.Trash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosBorrados)).EndInit();
            this.menuiconos.ResumeLayout(false);
            this.menuiconos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAlumnosBorrados;
        private System.Windows.Forms.ToolStrip menuiconos;
        private System.Windows.Forms.ToolStripButton tbsRecuperarAlumno;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tbsNuevoCodigo;
    }
}