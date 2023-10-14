
namespace compilador_v1._0
{
    partial class frmCompilador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompilador));
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado_Ascii = new System.Windows.Forms.Label();
            this.lblNumeroLineas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalLineasListbox = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.palabrasReservadasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeSimbolosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAExcelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flujoDeCaracteresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palabrasReservadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flujoDeCaracteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Entrada = new System.Windows.Forms.TextBox();
            this.txtLineas = new System.Windows.Forms.TextBox();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.LEXEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOKEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Pasar_Texto = new System.Windows.Forms.Button();
            this.btn_Id_Lexema = new System.Windows.Forms.Button();
            this.btn_Cargar_Archivo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCaracteres = new System.Windows.Forms.DataGridView();
            this.CARACTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMNA_FLUJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINEA_FLUJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTokens = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.btnTokensSinLibrerias = new System.Windows.Forms.Button();
            this.dgvLexico = new System.Windows.Forms.DataGridView();
            this.lexema1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSintactico = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSintactico = new System.Windows.Forms.DataGridView();
            this.ENCABEZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintactico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(237, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de Entrada";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Gold;
            this.lblResultado.Location = new System.Drawing.Point(883, 52);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(238, 37);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Flujo de Caracteres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(699, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Acciones";
            // 
            // resultado_Ascii
            // 
            this.resultado_Ascii.AutoSize = true;
            this.resultado_Ascii.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_Ascii.ForeColor = System.Drawing.Color.DarkRed;
            this.resultado_Ascii.Location = new System.Drawing.Point(499, 391);
            this.resultado_Ascii.Name = "resultado_Ascii";
            this.resultado_Ascii.Size = new System.Drawing.Size(0, 32);
            this.resultado_Ascii.TabIndex = 11;
            // 
            // lblNumeroLineas
            // 
            this.lblNumeroLineas.AutoSize = true;
            this.lblNumeroLineas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroLineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroLineas.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLineas.ForeColor = System.Drawing.Color.White;
            this.lblNumeroLineas.Location = new System.Drawing.Point(411, 782);
            this.lblNumeroLineas.Name = "lblNumeroLineas";
            this.lblNumeroLineas.Size = new System.Drawing.Size(2, 23);
            this.lblNumeroLineas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 782);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Numero de Lineas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(883, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Numero de Lineas:";
            // 
            // lblTotalLineasListbox
            // 
            this.lblTotalLineasListbox.AutoSize = true;
            this.lblTotalLineasListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLineasListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalLineasListbox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLineasListbox.ForeColor = System.Drawing.Color.White;
            this.lblTotalLineasListbox.Location = new System.Drawing.Point(1060, 526);
            this.lblTotalLineasListbox.Name = "lblTotalLineasListbox";
            this.lblTotalLineasListbox.Size = new System.Drawing.Size(2, 23);
            this.lblTotalLineasListbox.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem1,
            this.exportarAExcelToolStripMenuItem1,
            this.salirDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1869, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem1
            // 
            this.mantenimientosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.palabrasReservadasToolStripMenuItem1,
            this.tokensToolStripMenuItem2,
            this.tablaDeSimbolosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem1.Name = "mantenimientosToolStripMenuItem1";
            this.mantenimientosToolStripMenuItem1.Size = new System.Drawing.Size(130, 24);
            this.mantenimientosToolStripMenuItem1.Text = "Mantenimientos";
            // 
            // palabrasReservadasToolStripMenuItem1
            // 
            this.palabrasReservadasToolStripMenuItem1.Name = "palabrasReservadasToolStripMenuItem1";
            this.palabrasReservadasToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.palabrasReservadasToolStripMenuItem1.Text = "Palabras Reservadas";
            this.palabrasReservadasToolStripMenuItem1.Click += new System.EventHandler(this.palabrasReservadasToolStripMenuItem1_Click);
            // 
            // tokensToolStripMenuItem2
            // 
            this.tokensToolStripMenuItem2.Name = "tokensToolStripMenuItem2";
            this.tokensToolStripMenuItem2.Size = new System.Drawing.Size(225, 26);
            this.tokensToolStripMenuItem2.Text = "Tokens";
            this.tokensToolStripMenuItem2.Click += new System.EventHandler(this.tokensToolStripMenuItem2_Click);
            // 
            // tablaDeSimbolosToolStripMenuItem
            // 
            this.tablaDeSimbolosToolStripMenuItem.Name = "tablaDeSimbolosToolStripMenuItem";
            this.tablaDeSimbolosToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.tablaDeSimbolosToolStripMenuItem.Text = "Tabla de Simbolos";
            this.tablaDeSimbolosToolStripMenuItem.Click += new System.EventHandler(this.tablaDeSimbolosToolStripMenuItem_Click);
            // 
            // exportarAExcelToolStripMenuItem1
            // 
            this.exportarAExcelToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flujoDeCaracteresToolStripMenuItem1,
            this.tokensToolStripMenuItem3});
            this.exportarAExcelToolStripMenuItem1.Name = "exportarAExcelToolStripMenuItem1";
            this.exportarAExcelToolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.exportarAExcelToolStripMenuItem1.Text = "Exportar a Excel";
            // 
            // flujoDeCaracteresToolStripMenuItem1
            // 
            this.flujoDeCaracteresToolStripMenuItem1.Name = "flujoDeCaracteresToolStripMenuItem1";
            this.flujoDeCaracteresToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.flujoDeCaracteresToolStripMenuItem1.Text = "Flujo de Caracteres";
            this.flujoDeCaracteresToolStripMenuItem1.Click += new System.EventHandler(this.flujoDeCaracteresToolStripMenuItem1_Click);
            // 
            // tokensToolStripMenuItem3
            // 
            this.tokensToolStripMenuItem3.Name = "tokensToolStripMenuItem3";
            this.tokensToolStripMenuItem3.Size = new System.Drawing.Size(218, 26);
            this.tokensToolStripMenuItem3.Text = "Tokens";
            this.tokensToolStripMenuItem3.Click += new System.EventHandler(this.tokensToolStripMenuItem3_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.palabrasReservadasToolStripMenuItem,
            this.tokensToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // palabrasReservadasToolStripMenuItem
            // 
            this.palabrasReservadasToolStripMenuItem.Name = "palabrasReservadasToolStripMenuItem";
            this.palabrasReservadasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.palabrasReservadasToolStripMenuItem.Text = "Palabras Reservadas";
            // 
            // tokensToolStripMenuItem
            // 
            this.tokensToolStripMenuItem.Name = "tokensToolStripMenuItem";
            this.tokensToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.tokensToolStripMenuItem.Text = "Tokens";
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flujoDeCaracteresToolStripMenuItem,
            this.tokensToolStripMenuItem1});
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            // 
            // flujoDeCaracteresToolStripMenuItem
            // 
            this.flujoDeCaracteresToolStripMenuItem.Name = "flujoDeCaracteresToolStripMenuItem";
            this.flujoDeCaracteresToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.flujoDeCaracteresToolStripMenuItem.Text = "Flujo de Caracteres";
            // 
            // tokensToolStripMenuItem1
            // 
            this.tokensToolStripMenuItem1.Name = "tokensToolStripMenuItem1";
            this.tokensToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.tokensToolStripMenuItem1.Text = "Tokens";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // txt_Entrada
            // 
            this.txt_Entrada.AcceptsTab = true;
            this.txt_Entrada.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Entrada.Location = new System.Drawing.Point(77, 110);
            this.txt_Entrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Entrada.Multiline = true;
            this.txt_Entrada.Name = "txt_Entrada";
            this.txt_Entrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Entrada.Size = new System.Drawing.Size(553, 660);
            this.txt_Entrada.TabIndex = 9;
            this.txt_Entrada.TextChanged += new System.EventHandler(this.txt_Entrada_TextChanged);
            // 
            // txtLineas
            // 
            this.txtLineas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLineas.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLineas.Location = new System.Drawing.Point(12, 110);
            this.txtLineas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLineas.Multiline = true;
            this.txtLineas.Name = "txtLineas";
            this.txtLineas.ReadOnly = true;
            this.txtLineas.Size = new System.Drawing.Size(59, 660);
            this.txtLineas.TabIndex = 23;
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.AllowUserToDeleteRows = false;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LEXEMA,
            this.TOKEN,
            this.LINEA,
            this.COLUMNA});
            this.dgvTokens.Location = new System.Drawing.Point(721, 141);
            this.dgvTokens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.RowHeadersWidth = 51;
            this.dgvTokens.RowTemplate.Height = 24;
            this.dgvTokens.Size = new System.Drawing.Size(307, 244);
            this.dgvTokens.TabIndex = 24;
            this.dgvTokens.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // LEXEMA
            // 
            this.LEXEMA.HeaderText = "LEXEMA";
            this.LEXEMA.MinimumWidth = 6;
            this.LEXEMA.Name = "LEXEMA";
            this.LEXEMA.ReadOnly = true;
            this.LEXEMA.Width = 125;
            // 
            // TOKEN
            // 
            this.TOKEN.HeaderText = "TOKEN";
            this.TOKEN.MinimumWidth = 6;
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.ReadOnly = true;
            this.TOKEN.Width = 145;
            // 
            // LINEA
            // 
            this.LINEA.HeaderText = "LINEA";
            this.LINEA.MinimumWidth = 6;
            this.LINEA.Name = "LINEA";
            this.LINEA.ReadOnly = true;
            this.LINEA.Width = 125;
            // 
            // COLUMNA
            // 
            this.COLUMNA.HeaderText = "COLUMNA";
            this.COLUMNA.MinimumWidth = 6;
            this.COLUMNA.Name = "COLUMNA";
            this.COLUMNA.ReadOnly = true;
            this.COLUMNA.Width = 125;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarArchivo.BackgroundImage")));
            this.btnSeleccionarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarArchivo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(699, 697);
            this.btnSeleccionarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(131, 68);
            this.btnSeleccionarArchivo.TabIndex = 14;
            this.btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.BackgroundImage")));
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(1000, 702);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(131, 66);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Borrar";
            this.btn_Limpiar.UseCompatibleTextRendering = true;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Pasar_Texto
            // 
            this.btn_Pasar_Texto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pasar_Texto.BackgroundImage")));
            this.btn_Pasar_Texto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pasar_Texto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pasar_Texto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pasar_Texto.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pasar_Texto.Location = new System.Drawing.Point(848, 703);
            this.btn_Pasar_Texto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Pasar_Texto.Name = "btn_Pasar_Texto";
            this.btn_Pasar_Texto.Size = new System.Drawing.Size(131, 62);
            this.btn_Pasar_Texto.TabIndex = 7;
            this.btn_Pasar_Texto.Text = "Pasar a Texto";
            this.btn_Pasar_Texto.UseVisualStyleBackColor = true;
            this.btn_Pasar_Texto.Click += new System.EventHandler(this.btn_Pasar_Texto_Click);
            // 
            // btn_Id_Lexema
            // 
            this.btn_Id_Lexema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Id_Lexema.BackgroundImage")));
            this.btn_Id_Lexema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Id_Lexema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Id_Lexema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Id_Lexema.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Id_Lexema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Id_Lexema.Location = new System.Drawing.Point(848, 624);
            this.btn_Id_Lexema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Id_Lexema.Name = "btn_Id_Lexema";
            this.btn_Id_Lexema.Size = new System.Drawing.Size(131, 65);
            this.btn_Id_Lexema.TabIndex = 6;
            this.btn_Id_Lexema.Text = "Identificar Lexemas";
            this.btn_Id_Lexema.UseVisualStyleBackColor = true;
            this.btn_Id_Lexema.Click += new System.EventHandler(this.btn_Id_Lexema_Click);
            // 
            // btn_Cargar_Archivo
            // 
            this.btn_Cargar_Archivo.BackColor = System.Drawing.Color.Silver;
            this.btn_Cargar_Archivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cargar_Archivo.BackgroundImage")));
            this.btn_Cargar_Archivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cargar_Archivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cargar_Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cargar_Archivo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cargar_Archivo.Location = new System.Drawing.Point(699, 624);
            this.btn_Cargar_Archivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cargar_Archivo.Name = "btn_Cargar_Archivo";
            this.btn_Cargar_Archivo.Size = new System.Drawing.Size(131, 66);
            this.btn_Cargar_Archivo.TabIndex = 5;
            this.btn_Cargar_Archivo.Text = "Cargar Archivo";
            this.btn_Cargar_Archivo.UseVisualStyleBackColor = false;
            this.btn_Cargar_Archivo.Click += new System.EventHandler(this.btn_Cargar_Archivo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(1584, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tokens";
            // 
            // dgvCaracteres
            // 
            this.dgvCaracteres.AllowUserToAddRows = false;
            this.dgvCaracteres.AllowUserToDeleteRows = false;
            this.dgvCaracteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CARACTER,
            this.COLUMNA_FLUJO,
            this.LINEA_FLUJO,
            this.CODIGO_ASCII});
            this.dgvCaracteres.Location = new System.Drawing.Point(648, 111);
            this.dgvCaracteres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCaracteres.Name = "dgvCaracteres";
            this.dgvCaracteres.ReadOnly = true;
            this.dgvCaracteres.RowHeadersWidth = 51;
            this.dgvCaracteres.RowTemplate.Height = 24;
            this.dgvCaracteres.Size = new System.Drawing.Size(628, 402);
            this.dgvCaracteres.TabIndex = 26;
            this.dgvCaracteres.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCaracteres_RowPostPaint);
            // 
            // CARACTER
            // 
            this.CARACTER.HeaderText = "CARACTER";
            this.CARACTER.MinimumWidth = 6;
            this.CARACTER.Name = "CARACTER";
            this.CARACTER.ReadOnly = true;
            this.CARACTER.Width = 175;
            // 
            // COLUMNA_FLUJO
            // 
            this.COLUMNA_FLUJO.HeaderText = "COLUMNA";
            this.COLUMNA_FLUJO.MinimumWidth = 6;
            this.COLUMNA_FLUJO.Name = "COLUMNA_FLUJO";
            this.COLUMNA_FLUJO.ReadOnly = true;
            this.COLUMNA_FLUJO.Width = 125;
            // 
            // LINEA_FLUJO
            // 
            this.LINEA_FLUJO.HeaderText = "LINEA";
            this.LINEA_FLUJO.MinimumWidth = 6;
            this.LINEA_FLUJO.Name = "LINEA_FLUJO";
            this.LINEA_FLUJO.ReadOnly = true;
            this.LINEA_FLUJO.Width = 125;
            // 
            // CODIGO_ASCII
            // 
            this.CODIGO_ASCII.HeaderText = "CODIGO ASCII";
            this.CODIGO_ASCII.MinimumWidth = 6;
            this.CODIGO_ASCII.Name = "CODIGO_ASCII";
            this.CODIGO_ASCII.ReadOnly = true;
            this.CODIGO_ASCII.Width = 125;
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTokens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTokens.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokens.ForeColor = System.Drawing.Color.White;
            this.lblTokens.Location = new System.Drawing.Point(1735, 526);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(2, 23);
            this.lblTokens.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1557, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Numero de Lineas:";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblErrores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErrores.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(721, 804);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(199, 37);
            this.lblErrores.TabIndex = 31;
            this.lblErrores.Text = "Errores Lexicos:";
            this.lblErrores.Visible = false;
            // 
            // btnTokensSinLibrerias
            // 
            this.btnTokensSinLibrerias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTokensSinLibrerias.BackgroundImage")));
            this.btnTokensSinLibrerias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTokensSinLibrerias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTokensSinLibrerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTokensSinLibrerias.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTokensSinLibrerias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTokensSinLibrerias.Location = new System.Drawing.Point(1000, 624);
            this.btnTokensSinLibrerias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTokensSinLibrerias.Name = "btnTokensSinLibrerias";
            this.btnTokensSinLibrerias.Size = new System.Drawing.Size(131, 62);
            this.btnTokensSinLibrerias.TabIndex = 34;
            this.btnTokensSinLibrerias.Text = "Tokens";
            this.btnTokensSinLibrerias.UseVisualStyleBackColor = true;
            this.btnTokensSinLibrerias.Click += new System.EventHandler(this.btnTokensSinLibrerias_Click);
            // 
            // dgvLexico
            // 
            this.dgvLexico.AllowUserToDeleteRows = false;
            this.dgvLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLexico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lexema1,
            this.tipo,
            this.linea1,
            this.columna1});
            this.dgvLexico.Location = new System.Drawing.Point(1282, 111);
            this.dgvLexico.Name = "dgvLexico";
            this.dgvLexico.ReadOnly = true;
            this.dgvLexico.RowHeadersWidth = 51;
            this.dgvLexico.RowTemplate.Height = 24;
            this.dgvLexico.Size = new System.Drawing.Size(733, 402);
            this.dgvLexico.TabIndex = 35;
            // 
            // lexema1
            // 
            this.lexema1.HeaderText = "LEXEMA";
            this.lexema1.MinimumWidth = 6;
            this.lexema1.Name = "lexema1";
            this.lexema1.ReadOnly = true;
            this.lexema1.Width = 125;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 125;
            // 
            // linea1
            // 
            this.linea1.HeaderText = "LINEA";
            this.linea1.MinimumWidth = 6;
            this.linea1.Name = "linea1";
            this.linea1.ReadOnly = true;
            this.linea1.Width = 125;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "COLUMNA";
            this.columna1.MinimumWidth = 6;
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 125;
            // 
            // btnSintactico
            // 
            this.btnSintactico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSintactico.BackgroundImage")));
            this.btnSintactico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSintactico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSintactico.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnSintactico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintactico.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSintactico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSintactico.Location = new System.Drawing.Point(699, 770);
            this.btnSintactico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSintactico.Name = "btnSintactico";
            this.btnSintactico.Size = new System.Drawing.Size(131, 62);
            this.btnSintactico.TabIndex = 36;
            this.btnSintactico.Text = "Parser";
            this.btnSintactico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSintactico.UseVisualStyleBackColor = true;
            this.btnSintactico.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(1527, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 37);
            this.label6.TabIndex = 38;
            this.label6.Text = "Analisis Sintactico:";
            // 
            // dgvSintactico
            // 
            this.dgvSintactico.AllowUserToAddRows = false;
            this.dgvSintactico.AllowUserToDeleteRows = false;
            this.dgvSintactico.AllowUserToResizeColumns = false;
            this.dgvSintactico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSintactico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ENCABEZADO,
            this.DETALLE});
            this.dgvSintactico.Location = new System.Drawing.Point(1199, 624);
            this.dgvSintactico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSintactico.Name = "dgvSintactico";
            this.dgvSintactico.ReadOnly = true;
            this.dgvSintactico.RowHeadersWidth = 51;
            this.dgvSintactico.RowTemplate.Height = 24;
            this.dgvSintactico.Size = new System.Drawing.Size(816, 310);
            this.dgvSintactico.TabIndex = 37;
            this.dgvSintactico.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSintactico_RowPostPaint);
            // 
            // ENCABEZADO
            // 
            this.ENCABEZADO.HeaderText = "ENCABEZADO";
            this.ENCABEZADO.MinimumWidth = 6;
            this.ENCABEZADO.Name = "ENCABEZADO";
            this.ENCABEZADO.ReadOnly = true;
            this.ENCABEZADO.Width = 200;
            // 
            // DETALLE
            // 
            this.DETALLE.HeaderText = "DETALLE";
            this.DETALLE.MinimumWidth = 6;
            this.DETALLE.Name = "DETALLE";
            this.DETALLE.ReadOnly = true;
            this.DETALLE.Width = 350;
            // 
            // frmCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1869, 767);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSintactico);
            this.Controls.Add(this.btnSintactico);
            this.Controls.Add(this.dgvLexico);
            this.Controls.Add(this.btnTokensSinLibrerias);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblTokens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvCaracteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.txtLineas);
            this.Controls.Add(this.lblTotalLineasListbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeroLineas);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.resultado_Ascii);
            this.Controls.Add(this.txt_Entrada);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Pasar_Texto);
            this.Controls.Add(this.btn_Id_Lexema);
            this.Controls.Add(this.btn_Cargar_Archivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCompilador";
            this.Text = "Tokens Prueba 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintactico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cargar_Archivo;
        private System.Windows.Forms.Button btn_Id_Lexema;
        private System.Windows.Forms.Button btn_Pasar_Texto;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label resultado_Ascii;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Label lblNumeroLineas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalLineasListbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palabrasReservadasToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Entrada;
        private System.Windows.Forms.TextBox txtLineas;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCaracteres;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flujoDeCaracteresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem1;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem palabrasReservadasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flujoDeCaracteresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARACTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMNA_FLUJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEA_FLUJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ASCII;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEXEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMNA;
        private System.Windows.Forms.Button btnTokensSinLibrerias;
        private System.Windows.Forms.DataGridView dgvLexico;     
        private System.Windows.Forms.ToolStripMenuItem tablaDeSimbolosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexema1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.Button btnSintactico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSintactico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENCABEZADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETALLE;
    }
}

