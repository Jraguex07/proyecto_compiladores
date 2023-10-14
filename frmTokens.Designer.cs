
namespace compilador_v1._0
{
    partial class frmTokens
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
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGrabarDatos = new System.Windows.Forms.Button();
            this.txtLexema = new System.Windows.Forms.TextBox();
            this.txtIdToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.txtBorrarTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.txtBorrarLexema = new System.Windows.Forms.TextBox();
            this.txtBorrarIdToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerToken = new System.Windows.Forms.Timer(this.components);
            this.lblMantenimiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.AllowUserToDeleteRows = false;
            this.dgvTokens.AllowUserToOrderColumns = true;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Location = new System.Drawing.Point(393, 57);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.ReadOnly = true;
            this.dgvTokens.RowHeadersWidth = 51;
            this.dgvTokens.RowTemplate.Height = 24;
            this.dgvTokens.Size = new System.Drawing.Size(667, 639);
            this.dgvTokens.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(20, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 664);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTipo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnLimpiarDatos);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnGrabarDatos);
            this.tabPage1.Controls.Add(this.txtLexema);
            this.tabPage1.Controls.Add(this.txtIdToken);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar o Modificar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(80, 202);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(183, 28);
            this.txtTipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Escribe El Tipo:";
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(101, 346);
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
            this.label6.Location = new System.Drawing.Point(76, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id Token: ";
            // 
            // btnGrabarDatos
            // 
            this.btnGrabarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarDatos.Location = new System.Drawing.Point(101, 290);
            this.btnGrabarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabarDatos.Name = "btnGrabarDatos";
            this.btnGrabarDatos.Size = new System.Drawing.Size(147, 48);
            this.btnGrabarDatos.TabIndex = 4;
            this.btnGrabarDatos.Text = "Grabar Datos";
            this.btnGrabarDatos.UseVisualStyleBackColor = true;
            this.btnGrabarDatos.Click += new System.EventHandler(this.btnGrabarDatos_Click);
            // 
            // txtLexema
            // 
            this.txtLexema.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLexema.Location = new System.Drawing.Point(80, 130);
            this.txtLexema.Margin = new System.Windows.Forms.Padding(4);
            this.txtLexema.Name = "txtLexema";
            this.txtLexema.Size = new System.Drawing.Size(183, 28);
            this.txtLexema.TabIndex = 2;
            // 
            // txtIdToken
            // 
            this.txtIdToken.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdToken.Location = new System.Drawing.Point(183, 55);
            this.txtIdToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdToken.Name = "txtIdToken";
            this.txtIdToken.Size = new System.Drawing.Size(65, 28);
            this.txtIdToken.TabIndex = 1;
            this.txtIdToken.TextChanged += new System.EventHandler(this.txtIdToken_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escribe El Lexema:";
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.txtBorrarTipo);
            this.Eliminar.Controls.Add(this.label4);
            this.Eliminar.Controls.Add(this.label1);
            this.Eliminar.Controls.Add(this.btnEliminarDatos);
            this.Eliminar.Controls.Add(this.txtBorrarLexema);
            this.Eliminar.Controls.Add(this.txtBorrarIdToken);
            this.Eliminar.Controls.Add(this.label2);
            this.Eliminar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(4, 25);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminar.Size = new System.Drawing.Size(359, 635);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // txtBorrarTipo
            // 
            this.txtBorrarTipo.AcceptsTab = true;
            this.txtBorrarTipo.Enabled = false;
            this.txtBorrarTipo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrarTipo.Location = new System.Drawing.Point(86, 204);
            this.txtBorrarTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrarTipo.Name = "txtBorrarTipo";
            this.txtBorrarTipo.Size = new System.Drawing.Size(183, 28);
            this.txtBorrarTipo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo a Eliminar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id Token:";
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDatos.Location = new System.Drawing.Point(97, 312);
            this.btnEliminarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(147, 48);
            this.btnEliminarDatos.TabIndex = 4;
            this.btnEliminarDatos.Text = "Eliminar Datos";
            this.btnEliminarDatos.UseVisualStyleBackColor = true;
            this.btnEliminarDatos.Click += new System.EventHandler(this.btnEliminarDatos_Click);
            // 
            // txtBorrarLexema
            // 
            this.txtBorrarLexema.AcceptsTab = true;
            this.txtBorrarLexema.Enabled = false;
            this.txtBorrarLexema.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrarLexema.Location = new System.Drawing.Point(86, 132);
            this.txtBorrarLexema.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrarLexema.Name = "txtBorrarLexema";
            this.txtBorrarLexema.Size = new System.Drawing.Size(183, 28);
            this.txtBorrarLexema.TabIndex = 2;
            // 
            // txtBorrarIdToken
            // 
            this.txtBorrarIdToken.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrarIdToken.Location = new System.Drawing.Point(179, 48);
            this.txtBorrarIdToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrarIdToken.Name = "txtBorrarIdToken";
            this.txtBorrarIdToken.Size = new System.Drawing.Size(65, 28);
            this.txtBorrarIdToken.TabIndex = 1;
            this.txtBorrarIdToken.TextChanged += new System.EventHandler(this.txtBorrarIdToken_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lexema a Eliminar:";
            // 
            // timerToken
            // 
            this.timerToken.Interval = 10000;
            this.timerToken.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMantenimiento.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.ForeColor = System.Drawing.Color.Gold;
            this.lblMantenimiento.Location = new System.Drawing.Point(266, 9);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(320, 37);
            this.lblMantenimiento.TabIndex = 13;
            this.lblMantenimiento.Text = "Mantenimiento de Tokens";
            // 
            // frmTokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1085, 726);
            this.Controls.Add(this.lblMantenimiento);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTokens";
            this.Text = "frmTokens";
            this.Load += new System.EventHandler(this.frmTokens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGrabarDatos;
        private System.Windows.Forms.TextBox txtLexema;
        private System.Windows.Forms.TextBox txtIdToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.TextBox txtBorrarLexema;
        private System.Windows.Forms.TextBox txtBorrarIdToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBorrarTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerToken;
        private System.Windows.Forms.Label lblMantenimiento;
    }
}