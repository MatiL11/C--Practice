namespace SociosClubes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarSocio = new System.Windows.Forms.Button();
            this.btnMostrarSocios = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTipoSocio = new System.Windows.Forms.TextBox();
            this.ClubComboBox = new System.Windows.Forms.ComboBox();
            this.MembersDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarSocio
            // 
            this.btnAgregarSocio.Location = new System.Drawing.Point(12, 312);
            this.btnAgregarSocio.Name = "btnAgregarSocio";
            this.btnAgregarSocio.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarSocio.TabIndex = 0;
            this.btnAgregarSocio.Text = "Agregar Socio";
            this.btnAgregarSocio.UseVisualStyleBackColor = true;
            this.btnAgregarSocio.Click += new System.EventHandler(this.btnAgregarSocio_Click);
            // 
            // btnMostrarSocios
            // 
            this.btnMostrarSocios.Location = new System.Drawing.Point(93, 312);
            this.btnMostrarSocios.Name = "btnMostrarSocios";
            this.btnMostrarSocios.Size = new System.Drawing.Size(75, 38);
            this.btnMostrarSocios.TabIndex = 1;
            this.btnMostrarSocios.Text = "Mostrar Miembros";
            this.btnMostrarSocios.UseVisualStyleBackColor = true;
            this.btnMostrarSocios.Click += new System.EventHandler(this.btnMostrarSocios_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 123);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(12, 169);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(156, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // txtTipoSocio
            // 
            this.txtTipoSocio.Location = new System.Drawing.Point(12, 212);
            this.txtTipoSocio.Name = "txtTipoSocio";
            this.txtTipoSocio.Size = new System.Drawing.Size(156, 20);
            this.txtTipoSocio.TabIndex = 4;
            // 
            // ClubComboBox
            // 
            this.ClubComboBox.FormattingEnabled = true;
            this.ClubComboBox.Location = new System.Drawing.Point(12, 76);
            this.ClubComboBox.Name = "ClubComboBox";
            this.ClubComboBox.Size = new System.Drawing.Size(156, 21);
            this.ClubComboBox.TabIndex = 5;
            this.ClubComboBox.SelectedIndexChanged += new System.EventHandler(this.ClubComboBox_SelectedIndexChanged);
            // 
            // MembersDataGridView
            // 
            this.MembersDataGridView.AllowUserToAddRows = false;
            this.MembersDataGridView.AllowUserToDeleteRows = false;
            this.MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersDataGridView.Location = new System.Drawing.Point(174, 76);
            this.MembersDataGridView.Name = "MembersDataGridView";
            this.MembersDataGridView.Size = new System.Drawing.Size(240, 274);
            this.MembersDataGridView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Club";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de socio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MembersDataGridView);
            this.Controls.Add(this.ClubComboBox);
            this.Controls.Add(this.txtTipoSocio);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnMostrarSocios);
            this.Controls.Add(this.btnAgregarSocio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarSocio;
        private System.Windows.Forms.Button btnMostrarSocios;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTipoSocio;
        private System.Windows.Forms.ComboBox ClubComboBox;
        private System.Windows.Forms.DataGridView MembersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

