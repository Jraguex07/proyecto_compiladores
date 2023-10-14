
namespace compilador_v1._0
{
    partial class frmPalabrasReservadas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGrabarDatos = new System.Windows.Forms.Button();
            this.txtPalabraReservada = new System.Windows.Forms.TextBox();
            this.txtIdPalabraReservada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.txtEliminarPalabraReservada = new System.Windows.Forms.TextBox();
            this.txtBorrarIdPalabraReservada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPalabraReservada = new System.Windows.Forms.DataGridView();
            this.timerPalabras = new System.Windows.Forms.Timer(this.components);
            this.conexionbdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionbdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblResultado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalabraReservada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionbdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionbdBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(44, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 386);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiarDatos);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnGrabarDatos);
            this.tabPage1.Controls.Add(this.txtPalabraReservada);
            this.tabPage1.Controls.Add(this.txtIdPalabraReservada);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar o Modificar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(110, 280);
            this.btnLimpiarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(147, 51);
            this.btnLimpiarDatos.TabIndex = 4;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id Palabra Reservada:";
            // 
            // btnGrabarDatos
            // 
            this.btnGrabarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarDatos.Location = new System.Drawing.Point(110, 224);
            this.btnGrabarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabarDatos.Name = "btnGrabarDatos";
            this.btnGrabarDatos.Size = new System.Drawing.Size(147, 48);
            this.btnGrabarDatos.TabIndex = 3;
            this.btnGrabarDatos.Text = "Grabar Datos";
            this.btnGrabarDatos.UseVisualStyleBackColor = true;
            this.btnGrabarDatos.Click += new System.EventHandler(this.btnGrabarDatos_Click);
            // 
            // txtPalabraReservada
            // 
            this.txtPalabraReservada.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabraReservada.Location = new System.Drawing.Point(89, 169);
            this.txtPalabraReservada.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalabraReservada.Name = "txtPalabraReservada";
            this.txtPalabraReservada.Size = new System.Drawing.Size(183, 28);
            this.txtPalabraReservada.TabIndex = 2;
            // 
            // txtIdPalabraReservada
            // 
            this.txtIdPalabraReservada.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPalabraReservada.Location = new System.Drawing.Point(223, 75);
            this.txtIdPalabraReservada.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPalabraReservada.Name = "txtIdPalabraReservada";
            this.txtIdPalabraReservada.Size = new System.Drawing.Size(65, 28);
            this.txtIdPalabraReservada.TabIndex = 1;
            this.txtIdPalabraReservada.TextChanged += new System.EventHandler(this.txtIdPalabraReservada_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escribe la Palabra Reservada:";
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.label1);
            this.Eliminar.Controls.Add(this.btnEliminarDatos);
            this.Eliminar.Controls.Add(this.txtEliminarPalabraReservada);
            this.Eliminar.Controls.Add(this.txtBorrarIdPalabraReservada);
            this.Eliminar.Controls.Add(this.label2);
            this.Eliminar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(4, 25);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminar.Size = new System.Drawing.Size(350, 357);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id Palabra Reservada:";
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDatos.Location = new System.Drawing.Point(94, 228);
            this.btnEliminarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(147, 48);
            this.btnEliminarDatos.TabIndex = 3;
            this.btnEliminarDatos.Text = "Eliminar Datos";
            this.btnEliminarDatos.UseVisualStyleBackColor = true;
            this.btnEliminarDatos.Click += new System.EventHandler(this.btnEliminarDatos_Click);
            // 
            // txtEliminarPalabraReservada
            // 
            this.txtEliminarPalabraReservada.AcceptsTab = true;
            this.txtEliminarPalabraReservada.Enabled = false;
            this.txtEliminarPalabraReservada.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminarPalabraReservada.Location = new System.Drawing.Point(94, 172);
            this.txtEliminarPalabraReservada.Margin = new System.Windows.Forms.Padding(4);
            this.txtEliminarPalabraReservada.Name = "txtEliminarPalabraReservada";
            this.txtEliminarPalabraReservada.Size = new System.Drawing.Size(183, 28);
            this.txtEliminarPalabraReservada.TabIndex = 2;
            // 
            // txtBorrarIdPalabraReservada
            // 
            this.txtBorrarIdPalabraReservada.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrarIdPalabraReservada.Location = new System.Drawing.Point(228, 78);
            this.txtBorrarIdPalabraReservada.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrarIdPalabraReservada.Name = "txtBorrarIdPalabraReservada";
            this.txtBorrarIdPalabraReservada.Size = new System.Drawing.Size(65, 28);
            this.txtBorrarIdPalabraReservada.TabIndex = 1;
            this.txtBorrarIdPalabraReservada.TextChanged += new System.EventHandler(this.txtBorrarIdPalabraReservada_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Palabra Reservada a Eliminar:";
            // 
            // dgvPalabraReservada
            // 
            this.dgvPalabraReservada.AllowUserToAddRows = false;
            this.dgvPalabraReservada.AllowUserToDeleteRows = false;
            this.dgvPalabraReservada.AllowUserToOrderColumns = true;
            this.dgvPalabraReservada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalabraReservada.Location = new System.Drawing.Point(417, 93);
            this.dgvPalabraReservada.Name = "dgvPalabraReservada";
            this.dgvPalabraReservada.ReadOnly = true;
            this.dgvPalabraReservada.RowHeadersWidth = 51;
            this.dgvPalabraReservada.RowTemplate.Height = 24;
            this.dgvPalabraReservada.Size = new System.Drawing.Size(387, 365);
            this.dgvPalabraReservada.TabIndex = 10;
            // 
            // timerPalabras
            // 
            this.timerPalabras.Enabled = true;
            this.timerPalabras.Interval = 500;
            this.timerPalabras.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // conexionbdBindingSource
            // 
            this.conexionbdBindingSource.DataSource = typeof(compilador_v1._0.conexion_bd);
            // 
            // conexionbdBindingSource1
            // 
            this.conexionbdBindingSource1.DataSource = typeof(compilador_v1._0.conexion_bd);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Gold;
            this.lblResultado.Location = new System.Drawing.Point(271, 32);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(477, 37);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Mantenimiento de Palabras Reservadas";
            // 
            // timer1
            // 
  
            // 
            // frmPalabrasReservadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(858, 502);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvPalabraReservada);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPalabrasReservadas";
            this.Text = "Mantenimiento de Palabras Reservadas";
            this.Load += new System.EventHandler(this.frmPalabrasReservadas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalabraReservada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionbdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionbdBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGrabarDatos;
        private System.Windows.Forms.TextBox txtPalabraReservada;
        private System.Windows.Forms.TextBox txtIdPalabraReservada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.TextBox txtEliminarPalabraReservada;
        private System.Windows.Forms.TextBox txtBorrarIdPalabraReservada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPalabraReservada;
        private System.Windows.Forms.BindingSource conexionbdBindingSource;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.BindingSource conexionbdBindingSource1;
        private System.Windows.Forms.Timer timerPalabras;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Timer timer1;
    }
}