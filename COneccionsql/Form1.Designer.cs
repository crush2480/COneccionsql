namespace COneccionsql
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCodAlum = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbAPaterno = new System.Windows.Forms.TextBox();
            this.txbAMaterno = new System.Windows.Forms.TextBox();
            this.txbCodCarrera = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnCargarDatosAlum = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCargarDatosDocente = new System.Windows.Forms.Button();
            this.btnCargarDatosAsignatura = new System.Windows.Forms.Button();
            this.btnCargarDatosCarrera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codgio Alumno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Apellido Materno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Apellido Paterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Codigo de Carrera";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Usuario";
            // 
            // txbCodAlum
            // 
            this.txbCodAlum.Location = new System.Drawing.Point(187, 22);
            this.txbCodAlum.Name = "txbCodAlum";
            this.txbCodAlum.Size = new System.Drawing.Size(100, 20);
            this.txbCodAlum.TabIndex = 6;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(187, 48);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 7;
            // 
            // txbAPaterno
            // 
            this.txbAPaterno.Location = new System.Drawing.Point(187, 74);
            this.txbAPaterno.Name = "txbAPaterno";
            this.txbAPaterno.Size = new System.Drawing.Size(100, 20);
            this.txbAPaterno.TabIndex = 8;
            // 
            // txbAMaterno
            // 
            this.txbAMaterno.Location = new System.Drawing.Point(187, 100);
            this.txbAMaterno.Name = "txbAMaterno";
            this.txbAMaterno.Size = new System.Drawing.Size(100, 20);
            this.txbAMaterno.TabIndex = 9;
            // 
            // txbCodCarrera
            // 
            this.txbCodCarrera.Location = new System.Drawing.Point(549, 56);
            this.txbCodCarrera.Name = "txbCodCarrera";
            this.txbCodCarrera.Size = new System.Drawing.Size(100, 20);
            this.txbCodCarrera.TabIndex = 11;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(549, 30);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbUsuario.TabIndex = 10;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(78, 171);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(755, 355);
            this.dgvDatos.TabIndex = 12;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCargarDatosAlum
            // 
            this.btnCargarDatosAlum.Location = new System.Drawing.Point(78, 137);
            this.btnCargarDatosAlum.Name = "btnCargarDatosAlum";
            this.btnCargarDatosAlum.Size = new System.Drawing.Size(134, 23);
            this.btnCargarDatosAlum.TabIndex = 13;
            this.btnCargarDatosAlum.Text = "Cargar datos de Alumnos";
            this.btnCargarDatosAlum.UseVisualStyleBackColor = true;
            this.btnCargarDatosAlum.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(450, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargarDatosDocente
            // 
            this.btnCargarDatosDocente.Location = new System.Drawing.Point(218, 137);
            this.btnCargarDatosDocente.Name = "btnCargarDatosDocente";
            this.btnCargarDatosDocente.Size = new System.Drawing.Size(134, 23);
            this.btnCargarDatosDocente.TabIndex = 15;
            this.btnCargarDatosDocente.Text = "Cargar datos de Docente";
            this.btnCargarDatosDocente.UseVisualStyleBackColor = true;
            this.btnCargarDatosDocente.Click += new System.EventHandler(this.btnCargarDatosDocente_Click);
            // 
            // btnCargarDatosAsignatura
            // 
            this.btnCargarDatosAsignatura.Location = new System.Drawing.Point(358, 137);
            this.btnCargarDatosAsignatura.Name = "btnCargarDatosAsignatura";
            this.btnCargarDatosAsignatura.Size = new System.Drawing.Size(149, 23);
            this.btnCargarDatosAsignatura.TabIndex = 16;
            this.btnCargarDatosAsignatura.Text = "Cargar datos de Asignaturas";
            this.btnCargarDatosAsignatura.UseVisualStyleBackColor = true;
            this.btnCargarDatosAsignatura.Click += new System.EventHandler(this.btnCargarDatosAsignatura_Click);
            // 
            // btnCargarDatosCarrera
            // 
            this.btnCargarDatosCarrera.Location = new System.Drawing.Point(513, 137);
            this.btnCargarDatosCarrera.Name = "btnCargarDatosCarrera";
            this.btnCargarDatosCarrera.Size = new System.Drawing.Size(149, 23);
            this.btnCargarDatosCarrera.TabIndex = 17;
            this.btnCargarDatosCarrera.Text = "Cargar datos de Carrera";
            this.btnCargarDatosCarrera.UseVisualStyleBackColor = true;
            this.btnCargarDatosCarrera.Click += new System.EventHandler(this.btnCargarDatosCarrera_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1057, 557);
            this.Controls.Add(this.btnCargarDatosCarrera);
            this.Controls.Add(this.btnCargarDatosAsignatura);
            this.Controls.Add(this.btnCargarDatosDocente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCargarDatosAlum);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txbCodCarrera);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbAMaterno);
            this.Controls.Add(this.txbAPaterno);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodAlum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CodAlum;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbCodAlum;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbAPaterno;
        private System.Windows.Forms.TextBox txbAMaterno;
        private System.Windows.Forms.TextBox txbCodCarrera;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnCargarDatosAlum;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCargarDatosDocente;
        private System.Windows.Forms.Button btnCargarDatosAsignatura;
        private System.Windows.Forms.Button btnCargarDatosCarrera;
    }
}

