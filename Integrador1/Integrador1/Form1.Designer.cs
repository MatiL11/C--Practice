namespace Integrador1
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.dgvAutosDePersona = new System.Windows.Forms.DataGridView();
            this.btnMostrarAutos = new System.Windows.Forms.Button();
            this.btnAutosDePersona = new System.Windows.Forms.Button();
            this.dgvAutosConDueño = new System.Windows.Forms.DataGridView();
            this.btnAutosConDueño = new System.Windows.Forms.Button();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnBorrarPersona = new System.Windows.Forms.Button();
            this.btnBorrarAuto = new System.Windows.Forms.Button();
            this.btnModificarPersona = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignarAuto = new System.Windows.Forms.Button();
            this.lblTotalPrecioAutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDePersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosConDueño)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(374, 12);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(414, 110);
            this.dgvPersonas.TabIndex = 0;
            // 
            // dgvAutosDePersona
            // 
            this.dgvAutosDePersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosDePersona.Location = new System.Drawing.Point(374, 128);
            this.dgvAutosDePersona.Name = "dgvAutosDePersona";
            this.dgvAutosDePersona.Size = new System.Drawing.Size(414, 110);
            this.dgvAutosDePersona.TabIndex = 2;
            // 
            // btnMostrarAutos
            // 
            this.btnMostrarAutos.Location = new System.Drawing.Point(374, 360);
            this.btnMostrarAutos.Name = "btnMostrarAutos";
            this.btnMostrarAutos.Size = new System.Drawing.Size(75, 36);
            this.btnMostrarAutos.TabIndex = 3;
            this.btnMostrarAutos.Text = "Mostrar Autos";
            this.btnMostrarAutos.UseVisualStyleBackColor = true;
            this.btnMostrarAutos.Click += new System.EventHandler(this.btnMostrarAutos_Click);
            // 
            // btnAutosDePersona
            // 
            this.btnAutosDePersona.Location = new System.Drawing.Point(455, 360);
            this.btnAutosDePersona.Name = "btnAutosDePersona";
            this.btnAutosDePersona.Size = new System.Drawing.Size(75, 36);
            this.btnAutosDePersona.TabIndex = 4;
            this.btnAutosDePersona.Text = "Autos De La Persona";
            this.btnAutosDePersona.UseVisualStyleBackColor = true;
            this.btnAutosDePersona.Click += new System.EventHandler(this.btnAutosDePersona_Click);
            // 
            // dgvAutosConDueño
            // 
            this.dgvAutosConDueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosConDueño.Location = new System.Drawing.Point(374, 244);
            this.dgvAutosConDueño.Name = "dgvAutosConDueño";
            this.dgvAutosConDueño.Size = new System.Drawing.Size(414, 110);
            this.dgvAutosConDueño.TabIndex = 5;
            // 
            // btnAutosConDueño
            // 
            this.btnAutosConDueño.Location = new System.Drawing.Point(536, 360);
            this.btnAutosConDueño.Name = "btnAutosConDueño";
            this.btnAutosConDueño.Size = new System.Drawing.Size(75, 36);
            this.btnAutosConDueño.TabIndex = 6;
            this.btnAutosConDueño.Text = "Autos Con Dueño";
            this.btnAutosConDueño.UseVisualStyleBackColor = true;
            this.btnAutosConDueño.Click += new System.EventHandler(this.btnAutosConDueño_Click);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(11, 147);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarPersona.TabIndex = 7;
            this.btnAgregarPersona.Text = "Agregar Persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(11, 213);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarAuto.TabIndex = 8;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // btnBorrarPersona
            // 
            this.btnBorrarPersona.Location = new System.Drawing.Point(92, 147);
            this.btnBorrarPersona.Name = "btnBorrarPersona";
            this.btnBorrarPersona.Size = new System.Drawing.Size(75, 36);
            this.btnBorrarPersona.TabIndex = 9;
            this.btnBorrarPersona.Text = "Borrar Persona";
            this.btnBorrarPersona.UseVisualStyleBackColor = true;
            this.btnBorrarPersona.Click += new System.EventHandler(this.btnBorrarPersona_Click);
            // 
            // btnBorrarAuto
            // 
            this.btnBorrarAuto.Location = new System.Drawing.Point(92, 213);
            this.btnBorrarAuto.Name = "btnBorrarAuto";
            this.btnBorrarAuto.Size = new System.Drawing.Size(75, 36);
            this.btnBorrarAuto.TabIndex = 10;
            this.btnBorrarAuto.Text = "Borrar Auto";
            this.btnBorrarAuto.UseVisualStyleBackColor = true;
            this.btnBorrarAuto.Click += new System.EventHandler(this.btnBorrarAuto_Click);
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Location = new System.Drawing.Point(173, 147);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(75, 36);
            this.btnModificarPersona.TabIndex = 11;
            this.btnModificarPersona.Text = "Modificar Persona";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            this.btnModificarPersona.Click += new System.EventHandler(this.btnModificarPersona_Click);
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(173, 213);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(75, 36);
            this.btnModificarAuto.TabIndex = 12;
            this.btnModificarAuto.Text = "Modificar Auto";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            this.btnModificarAuto.Click += new System.EventHandler(this.btnModificarAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Menu Autos";
            // 
            // btnAsignarAuto
            // 
            this.btnAsignarAuto.Location = new System.Drawing.Point(254, 147);
            this.btnAsignarAuto.Name = "btnAsignarAuto";
            this.btnAsignarAuto.Size = new System.Drawing.Size(75, 36);
            this.btnAsignarAuto.TabIndex = 15;
            this.btnAsignarAuto.Text = "Asignar Auto";
            this.btnAsignarAuto.UseVisualStyleBackColor = true;
            this.btnAsignarAuto.Click += new System.EventHandler(this.btnAsignarAuto_Click);
            // 
            // lblTotalPrecioAutos
            // 
            this.lblTotalPrecioAutos.AutoSize = true;
            this.lblTotalPrecioAutos.Location = new System.Drawing.Point(170, 12);
            this.lblTotalPrecioAutos.Name = "lblTotalPrecioAutos";
            this.lblTotalPrecioAutos.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPrecioAutos.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalPrecioAutos);
            this.Controls.Add(this.btnAsignarAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarAuto);
            this.Controls.Add(this.btnModificarPersona);
            this.Controls.Add(this.btnBorrarAuto);
            this.Controls.Add(this.btnBorrarPersona);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.btnAutosConDueño);
            this.Controls.Add(this.dgvAutosConDueño);
            this.Controls.Add(this.btnAutosDePersona);
            this.Controls.Add(this.btnMostrarAutos);
            this.Controls.Add(this.dgvAutosDePersona);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDePersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosConDueño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.DataGridView dgvAutosDePersona;
        private System.Windows.Forms.Button btnMostrarAutos;
        private System.Windows.Forms.Button btnAutosDePersona;
        private System.Windows.Forms.DataGridView dgvAutosConDueño;
        private System.Windows.Forms.Button btnAutosConDueño;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnBorrarPersona;
        private System.Windows.Forms.Button btnBorrarAuto;
        private System.Windows.Forms.Button btnModificarPersona;
        private System.Windows.Forms.Button btnModificarAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignarAuto;
        private System.Windows.Forms.Label lblTotalPrecioAutos;
    }
}

