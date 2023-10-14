namespace compilador_v1._0
{
    partial class frmTablaSimbolos
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvTablaSimbolos = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTabla = new System.Windows.Forms.TextBox();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGrabarDatos = new System.Windows.Forms.Button();
            this.txtTipoToken = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.lblBorrarIdTabla = new System.Windows.Forms.Label();
            this.txtBorrarIdTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.txtBorrarTipoToken = new System.Windows.Forms.TextBox();
            this.txtBorrarIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerTablaSimbolos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Gold;
            this.lblResultado.Location = new System.Drawing.Point(157, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(415, 37);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Mantenimiento Tabla de Simbolos";
            // 
            // dgvTablaSimbolos
            // 
            this.dgvTablaSimbolos.AllowUserToAddRows = false;
            this.dgvTablaSimbolos.AllowUserToDeleteRows = false;
            this.dgvTablaSimbolos.AllowUserToOrderColumns = true;
            this.dgvTablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSimbolos.Location = new System.Drawing.Point(379, 114);
            this.dgvTablaSimbolos.Name = "dgvTablaSimbolos";
            this.dgvTablaSimbolos.ReadOnly = true;
            this.dgvTablaSimbolos.RowHeadersWidth = 51;
            this.dgvTablaSimbolos.RowTemplate.Height = 24;
            this.dgvTablaSimbolos.Size = new System.Drawing.Size(387, 365);
            this.dgvTablaSimbolos.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(6, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 386);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtIdTabla);
            this.tabPage1.Controls.Add(this.btnModificarDatos);
            this.tabPage1.Controls.Add(this.btnLimpiarDatos);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnGrabarDatos);
            this.tabPage1.Controls.Add(this.txtTipoToken);
            this.tabPage1.Controls.Add(this.txtIdentificador);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id de Tabla:";
            // 
            // txtIdTabla
            // 
            this.txtIdTabla.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTabla.Location = new System.Drawing.Point(90, 60);
            this.txtIdTabla.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdTabla.Name = "txtIdTabla";
            this.txtIdTabla.Size = new System.Drawing.Size(80, 28);
            this.txtIdTabla.TabIndex = 1;
            this.txtIdTabla.TextChanged += new System.EventHandler(this.txtIdTabla_TextChanged);
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatos.Location = new System.Drawing.Point(165, 243);
            this.btnModificarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(164, 48);
            this.btnModificarDatos.TabIndex = 5;
            this.btnModificarDatos.Text = "Modificar Datos";
            this.btnModificarDatos.UseVisualStyleBackColor = true;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(113, 299);
            this.btnLimpiarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(147, 51);
            this.btnLimpiarDatos.TabIndex = 6;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Identificador:";
            // 
            // btnGrabarDatos
            // 
            this.btnGrabarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarDatos.Location = new System.Drawing.Point(10, 243);
            this.btnGrabarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabarDatos.Name = "btnGrabarDatos";
            this.btnGrabarDatos.Size = new System.Drawing.Size(147, 48);
            this.btnGrabarDatos.TabIndex = 4;
            this.btnGrabarDatos.Text = "Grabar Datos";
            this.btnGrabarDatos.UseVisualStyleBackColor = true;
            this.btnGrabarDatos.Click += new System.EventHandler(this.btnGrabarDatos_Click);
            // 
            // txtTipoToken
            // 
            this.txtTipoToken.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoToken.Location = new System.Drawing.Point(90, 198);
            this.txtTipoToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoToken.Name = "txtTipoToken";
            this.txtTipoToken.Size = new System.Drawing.Size(183, 28);
            this.txtTipoToken.TabIndex = 3;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificador.Location = new System.Drawing.Point(90, 141);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(183, 28);
            this.txtIdentificador.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Lexema:";
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.lblBorrarIdTabla);
            this.Eliminar.Controls.Add(this.txtBorrarIdTabla);
            this.Eliminar.Controls.Add(this.label1);
            this.Eliminar.Controls.Add(this.btnEliminarDatos);
            this.Eliminar.Controls.Add(this.txtBorrarTipoToken);
            this.Eliminar.Controls.Add(this.txtBorrarIdentificador);
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
            // lblBorrarIdTabla
            // 
            this.lblBorrarIdTabla.AutoSize = true;
            this.lblBorrarIdTabla.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrarIdTabla.Location = new System.Drawing.Point(78, 47);
            this.lblBorrarIdTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrarIdTabla.Name = "lblBorrarIdTabla";
            this.lblBorrarIdTabla.Size = new System.Drawing.Size(91, 21);
            this.lblBorrarIdTabla.TabIndex = 20;
            this.lblBorrarIdTabla.Text = "Id de Tabla:";
            // 
            // txtBorrarIdTabla
            // 
            this.txtBorrarIdTabla.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrarIdTabla.Location = new System.Drawing.Point(82, 72);
            this.txtBorrarIdTabla.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrarIdTabla.Name = "txtBorrarIdTabla";
            this.txtBorrarIdTabla.Size = new System.Drawing.Size(80, 28);
            this.txtBorrarIdTabla.TabIndex = 1;
            this.txtBorrarIdTabla.TextChanged += new System.EventHandler(this.txtBorrarIdTabla_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id a Eliminar:";
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDatos.Location = new System.Drawing.Point(108, 290);
            this.btnEliminarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(147, 48);
            this.btnEliminarDatos.TabIndex = 4;
            this.btnEliminarDatos.Text = "Eliminar Datos";
            this.btnEliminarDatos.UseVisualStyleBackColor = true;
            this.btnEliminarDatos.Click += new System.EventHandler(this.btnEliminarDatos_Click);
            // 
            // txtBorrarTipoToken
            // 
            this.txtBorrarTipoToken.AcceptsTab = true;
            this.txtBorrarTipoToken.Enabled = false;
            this.txtBorrarTipoToken.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrarTipoToken.Location = new System.Drawing.Point(82, 236);
            this.txtBorrarTipoToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrarTipoToken.Name = "txtBorrarTipoToken";
            this.txtBorrarTipoToken.Size = new System.Drawing.Size(195, 28);
            this.txtBorrarTipoToken.TabIndex = 3;
            // 
            // txtBorrarIdentificador
            // 
            this.txtBorrarIdentificador.Enabled = false;
            this.txtBorrarIdentificador.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrarIdentificador.Location = new System.Drawing.Point(82, 157);
            this.txtBorrarIdentificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrarIdentificador.Name = "txtBorrarIdentificador";
            this.txtBorrarIdentificador.Size = new System.Drawing.Size(195, 28);
            this.txtBorrarIdentificador.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo Lexema a Eliminar:";
            // 
            // timerTablaSimbolos
            // 
            this.timerTablaSimbolos.Interval = 5000;
            this.timerTablaSimbolos.Tick += new System.EventHandler(this.timerTablaSimbolos_Tick);
            // 
            // frmTablaSimbolos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(781, 529);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvTablaSimbolos);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTablaSimbolos";
            this.Text = "frmTablaSimbolos";
            this.Load += new System.EventHandler(this.frmTablaSimbolos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvTablaSimbolos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGrabarDatos;
        private System.Windows.Forms.TextBox txtTipoToken;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.TextBox txtBorrarTipoToken;
        private System.Windows.Forms.TextBox txtBorrarIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.Timer timerTablaSimbolos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTabla;
        private System.Windows.Forms.Label lblBorrarIdTabla;
        private System.Windows.Forms.TextBox txtBorrarIdTabla;
    }
}