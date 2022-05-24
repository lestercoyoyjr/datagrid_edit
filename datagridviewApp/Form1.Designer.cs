
namespace datagridviewApp
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
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.txtEquipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEquipoID,
            this.txtnoEquipo,
            this.txtnombreEquipo,
            this.cbxEstado});
            this.dgvEquipos.Location = new System.Drawing.Point(23, 29);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(1077, 419);
            this.dgvEquipos.TabIndex = 0;
            // 
            // txtEquipoID
            // 
            this.txtEquipoID.DataPropertyName = "equipoID";
            this.txtEquipoID.HeaderText = "No";
            this.txtEquipoID.Name = "txtEquipoID";
            this.txtEquipoID.Visible = false;
            // 
            // txtnoEquipo
            // 
            this.txtnoEquipo.DataPropertyName = "no_equipo";
            this.txtnoEquipo.HeaderText = "No. de Equipo";
            this.txtnoEquipo.Name = "txtnoEquipo";
            // 
            // txtnombreEquipo
            // 
            this.txtnombreEquipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtnombreEquipo.DataPropertyName = "nombre_equipo";
            this.txtnombreEquipo.HeaderText = "Nombre Equipo";
            this.txtnombreEquipo.Name = "txtnombreEquipo";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DataPropertyName = "estadoID";
            this.cbxEstado.HeaderText = "Estado";
            this.cbxEstado.Name = "cbxEstado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 460);
            this.Controls.Add(this.dgvEquipos);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEquipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtnoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtnombreEquipo;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxEstado;
    }
}

