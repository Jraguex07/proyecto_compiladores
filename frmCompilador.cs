using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Documents;

namespace compilador_v1._0
{
    public partial class frmCompilador : Form
    {
        private int lineas; private int aux; private int indice; // indice de cada token
        private string linea; private string columna;
        public frmCompilador()
        {
            InitializeComponent();

            lineas = 0; aux = 0;
            indice = 1; linea = ""; columna = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Entrada.Focus();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgvSintactico.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            txt_Entrada.Text = ""; dgvCaracteres.Rows.Clear(); txt_Entrada.Focus();
            lblNumeroLineas.Text = ""; lblTotalLineasListbox.Text = ""; dgvTokens.Rows.Clear();
            dgvLexico.Rows.Clear(); lblTokens.Text = ""; dgvSintactico.Rows.Clear();
            borrar_tokens(); truncar_tabla(); borrar_Tabla_Simbolos(); truncar_Tabla_Simbolos();
        }

        // Muestra Caracter por Caracter en MsgBox con Codificacion ANSII
        private void btn_Id_Lexema_Click(object sender, EventArgs e)
        {
            string entrada = txt_Entrada.Text;
            int i = 0;
            while (i < entrada.Length)
            {
                byte[] ASCIIvalues = Encoding.ASCII.GetBytes(entrada);

                foreach (var value in ASCIIvalues)
                {
                    switch (value)
                    {
                        case 32:
                            MessageBox.Show("El caracter ingresado es: " + "ESPACIO" + "\n" +
                            "En Codificacion ASCII el código es:" + " (" + value.ToString() +
                            ")", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i++;
                            break;
                        case 9:
                            MessageBox.Show("El caracter ingresado es: " + "TABULADOR" + "\n" +
                            "En Codificacion ASCII el código es:" + " (" + value.ToString() +
                            ")", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i++;
                            break;
                        case 13:
                            MessageBox.Show("El caracter ingresado es: " + "FIN DE LINEA" + "\n" +
                            "En Codificacion ASCII el código es:" + " (" + value.ToString() +
                             ")", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i++;
                            break;
                        case 10:
                            MessageBox.Show("El caracter ingresado es: " + "SALTO DE LINEA" + "\n" +
                            "En Codificacion ASCII el código es:" + " (" + value.ToString() +
                            ")", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i++;
                            break;
                        default:
                            MessageBox.Show("El caracter ingresado es: " + entrada[i].ToString() + "\n" +
                            "En Codificacion ASCII el código es:" + " (" + value.ToString() +
                            ")", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i++;
                            break;
                    }
                }
            }
        }

        // Muestra Caracter por Caracter en DgvCaracteres, Conteo de Registros
        private void btn_Pasar_Texto_Click(object sender, EventArgs e)
        {
            string entrada = txt_Entrada.Text;
            int cl = 1;
            int cc = 0;
            int i = 0;
            while (i < entrada.Length)
            {
                byte[] ASCIIvalues = Encoding.ASCII.GetBytes(entrada);
                foreach (var value in ASCIIvalues)
                {
                    switch (value)
                    {
                        case 32:
                            cc += 1;
                            dgvCaracteres.Rows.Add("Espacio", cl, cc, value.ToString());
                            i++;
                            break;
                        case 9:
                            cc += 8;
                            dgvCaracteres.Rows.Add("Tabulador", cl, cc, value.ToString());
                            i++;
                            break;
                        case 13:
                            cc += 1;
                            dgvCaracteres.Rows.Add("FIN DE LINEA", "-", "-", value.ToString());
                            i++;
                            break;
                        case 10:
                            cl += 1; cc = 0;
                            dgvCaracteres.Rows.Add("SALTO DE LINEA", "-", "-", value.ToString());
                            i++;
                            break;
                        default:
                            cc += 1;
                            dgvCaracteres.Rows.Add(entrada[i].ToString(), cl, cc, value.ToString());
                            i++;
                            break;
                    }
                }
            }
            int contadordgv = dgvCaracteres.Rows.Count;
            lblTotalLineasListbox.Text = contadordgv.ToString();
            dgvCaracteres.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Carga un Unico Archivo de Texto Al Editor
        private void btn_Cargar_Archivo_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = openfiledialog.FileName;
            }

            try
            {
                string leerArchivo = File.ReadAllText(rutaDirectorio);
                txt_Entrada.Text = leerArchivo;
                txt_Entrada.Select(txt_Entrada.Text.Length, 0);
                txt_Entrada.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("No se abrió archivo con formato .TXT",
               "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        // Carga Multiples Archivos de Texto Al Editor
        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = openfiledialog.FileName;
            }

            try
            {
                string leerArchivo = File.ReadAllText(rutaDirectorio);
                txt_Entrada.AppendText(leerArchivo + "\r\n");
                txt_Entrada.Select(txt_Entrada.Text.Length, 0);
                txt_Entrada.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("No se abrió archivo con formato .TXT",
               "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txt_Entrada_TextChanged(object sender, EventArgs e)
        {
            this.lblErrores.Visible = false;


            lblNumeroLineas.Text = (txt_Entrada.GetLineFromCharIndex(txt_Entrada.TextLength) + 1).ToString();

            // Este Codigo Obtiene El Numero de Linea a la hora de un Salto de linea en el Textbox de Entrada
            lineas = txt_Entrada.Lines.Length + 1;
            if (lineas > aux || lineas < aux)
            {
                txtLineas.Clear();
                for (int i = 1; i < lineas; i++)
                {
                    txtLineas.Text += "" + i + Environment.NewLine;
                }
                aux = lineas;
            }
        }

        private void dgvCaracteres_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvCaracteres.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        public void ActualizarLineas()
        {
            var caracterEnEsquina = txt_Entrada.GetCharIndexFromPosition(new System.Drawing.Point(0, 4));
            var primeraLinea = txt_Entrada.GetLineFromCharIndex(caracterEnEsquina) + 1;

            // Aquí va el código donde generas los números de línea

        }

        private void dgvList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvTokens.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }


        // FUNCION PARA IMPORTAR DATOS A EXCEL
        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int ColumnIndex = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                ColumnIndex++;
                excel.Cells[1, ColumnIndex] = col.Name;
            }

            int rowIndex = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                }
            }
            excel.Columns[1].Autofit();
            excel.Columns[2].Autofit();
            excel.Columns[3].Autofit();
            excel.Columns[4].Autofit();
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
        }


        private void palabrasReservadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPalabrasReservadas palabrasReservadas = new frmPalabrasReservadas();
            palabrasReservadas.Show();
        }

        private void tokensToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTokens tokens = new frmTokens();
            tokens.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea cerrar Compilador v 1.0 ?", "Cerrar Compilador",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
            }
        }

        private void flujoDeCaracteresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exportarExcel(dgvCaracteres);
        }

        private void tokensToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            exportarExcel(dgvTokens);
        }



        // --------------------------COMIENZA ANALISIS LEXICO Y MANTENIMIENTOS --------------------------------
        public void borrar_tokens()
        {
            // Borra los Tokens Existentes de la base de Datos
            String sql = "DELETE FROM token WHERE id_token >= @id";
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                comando.Parameters.AddWithValue("@id", 0);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
            finally
            {
                objetoConexion.Close();
            }
        }

        public void borrar_Tabla_Simbolos()
        {
            // Borra los Tokens Existentes de la base de Datos
            String sql = "DELETE FROM tabla_simbolos WHERE id_tabla >= @id";
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                comando.Parameters.AddWithValue("@id", 0);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException)
            {

            }
            finally
            {
                objetoConexion.Close();
            }
        }

        public void truncar_tabla()
        {
            // Este codigo trunca la tabla Token
            String sql = "TRUNCATE db_compilador.token;";
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Truncar la Tabla Token: " + ex.Message);
            }
            finally
            {
                objetoConexion.Close();
            }
        }

        public void truncar_Tabla_Simbolos()
        {
            // Este codigo trunca la tabla Token
            String sql = "TRUNCATE db_compilador.tabla_simbolos;";
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Truncar la Tabla de Simbolos: " + ex.Message);
            }
            finally
            {
                objetoConexion.Close();
            }
        }

        private void btnTokensSinLibrerias_Click(object sender, EventArgs e)
        {
            dgvLexico.Rows.Clear(); dgvSintactico.Rows.Clear(); dgvSintactico.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Empty;
                ;
            borrar_tokens(); truncar_tabla(); borrar_Tabla_Simbolos(); truncar_Tabla_Simbolos();

            string entrada = txt_Entrada.Text;
            char[] salto = { '\n' };
            char[] espacio = { ' ' };
            int estado = 0; string tipo_lexema = null;
            int validar_id = 0;
            int numero;
            double numero_decimal;
            string[] operador = { "+", "-", "/", "*", "=", ":=", ">", "<", "<>", "&&", "||" };
            string[] signo_puntuacion = { "(", ")", "{", "}", ";", "," };

            string[] excluir_signos_id = { "[", "]" , "(", ")", "{", "}", "!" , "@" ,"#" };

            System.Data.DataTable dt;
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            String sql = "SELECT * FROM palabra_reservada";

            using (MySqlCommand comando = new MySqlCommand(sql, objetoConexion))
            {
                objetoConexion.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    dt = new System.Data.DataTable();
                    if (reader.HasRows)
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                        reader.Dispose();
                        adapter.Fill(dt);
                    }
                }
                objetoConexion.Close();
            }

            List<string> palabras_reservadas = new List<string>(); // Aqui se guardan las palabras reservadas
            List <string> excluir_todos_los_simbolos = new List<string> (); // Operadores de Exclusion en los ids

            for (int to = 0; to < excluir_signos_id.Length; to++)
            {
                excluir_todos_los_simbolos.Add(excluir_signos_id[to]);
            }
           

            foreach (DataRow dr in dt.Rows)
            {
                palabras_reservadas.Add(dr["palabra_reservada"].ToString());
            }

            if (entrada == "")
            {
                MessageBox.Show("Porfavor Ingresa Texto al Editor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Entrada.Focus();
            }

            string[] entradaArray = entrada.Split(salto);

            for (int i = 0; i < entradaArray.Length; i++)
            {
                string[] palabra = entradaArray[i].Split(espacio);

                for (int j = 0; j < palabra.Length; j++)
                {
                    palabra[j] = palabra[j].Replace("\n", "");
                    palabra[j] = palabra[j].Replace("\t", "");
                    palabra[j] = palabra[j].Replace("\r", "");

                    void agregar_dgvLexico_dbToken()
                    {
                        DataGridViewRow row = (DataGridViewRow)dgvLexico.Rows[0].Clone();
                        row.Cells[0].Value = (palabra[j]); //lexema
                        row.Cells[1].Value = tipo_lexema; //tipo lexema                                      
                        row.Cells[2].Value = i + 1; // lineas
                        row.Cells[3].Value = j + 1; // columnas
                        dgvLexico.Rows.Add(row);

                        // Agrega Lexema a la Tabla Token
                        String sqlInsert = "INSERT INTO token (lexema,tipo,linea,columna) values (@lexema,@tipo,@linea,@columna)";
                        MySqlConnection objetoConexion1 = conexion_bd.establecerConexion();
                        objetoConexion1.Open();
                        MySqlCommand comando = new MySqlCommand(sqlInsert, objetoConexion1);
                        comando.Parameters.AddWithValue("@lexema", row.Cells[0].Value);
                        comando.Parameters.AddWithValue("@tipo", row.Cells[1].Value);
                        comando.Parameters.AddWithValue("@linea", row.Cells[2].Value);
                        comando.Parameters.AddWithValue("@columna", row.Cells[3].Value);
                        comando.ExecuteNonQuery();
                        objetoConexion1.Close();
                    }

                    void agregar_dgvLexico_dbTokenyTablaSimbolos()
                    {
                        DataGridViewRow row = (DataGridViewRow)dgvLexico.Rows[0].Clone();
                        row.Cells[0].Value = (palabra[j]); //lexema
                        row.Cells[1].Value = tipo_lexema; //tipo lexema                                      
                        row.Cells[2].Value = i + 1; // lineas
                        row.Cells[3].Value = j + 1; // columnas
                        dgvLexico.Rows.Add(row);

                        // Agrega Lexema a la Tabla Token
                        String sqlInsert = "INSERT INTO token (lexema,tipo,linea,columna) values (@lexema,@tipo,@linea,@columna)";
                        MySqlConnection objetoConexion1 = conexion_bd.establecerConexion();
                        objetoConexion1.Open();
                        MySqlCommand comando = new MySqlCommand(sqlInsert, objetoConexion1);
                        comando.Parameters.AddWithValue("@lexema", row.Cells[0].Value);
                        comando.Parameters.AddWithValue("@tipo", row.Cells[1].Value);
                        comando.Parameters.AddWithValue("@linea", row.Cells[2].Value);
                        comando.Parameters.AddWithValue("@columna", row.Cells[3].Value);
                        comando.ExecuteNonQuery();
                        objetoConexion1.Close();

                        // Agrega Lexema a la Tabla de Simbolos
                        String sqlInsertId = "INSERT INTO tabla_simbolos (id,tipo_token) values (@id,@tipo_token)";
                        MySqlConnection objetoConexionId = conexion_bd.establecerConexion();
                        try
                        {
                            objetoConexionId.Open();
                            MySqlCommand comandoId = new MySqlCommand(sqlInsertId, objetoConexionId);
                            comandoId.Parameters.AddWithValue("@id", row.Cells[0].Value);
                            comandoId.Parameters.AddWithValue("@tipo_token", row.Cells[1].Value);
                            comandoId.ExecuteNonQuery();
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("En la Tabla de Simbolos, solamente se guarda" + "\n" +
                            "una unica vez el Identificador: " + row.Cells[0].Value, "No se permiten duplicados",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            objetoConexionId.Close();
                        }
                    }



                    if (palabra[j] != "" )
                    {

                        switch (estado)
                        {
                            case 0:

                                if (palabra[j] == operador[0]) // Identifica si es un Operador
                                {
                                    tipo_lexema = "Operador Suma";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[1])
                                {
                                    tipo_lexema = "Operador Resta";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[2])
                                {
                                    tipo_lexema = "Operador Division";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[3])
                                {
                                    tipo_lexema = "Operador Multiplicacion";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[4])
                                {
                                    tipo_lexema = "Operador Igual";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[5])
                                {
                                    tipo_lexema = "Operador Asignacion";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[6])
                                {
                                    tipo_lexema = "Operador Mayor";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[7])
                                {
                                    tipo_lexema = "Operador Menor";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[8])
                                {
                                    tipo_lexema = "Operador Distincion";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[9])
                                {
                                    tipo_lexema = "Operador Conjuncion";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == operador[10])
                                {
                                    tipo_lexema = "Operador Disyuncion";
                                    agregar_dgvLexico_dbToken();
                                }

                                else if (palabra[j] == signo_puntuacion[0])   // Identifica si es un signo de Puntuacion
                                {
                                    tipo_lexema = "Signo de Puntuacion Parentesis Abre";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == signo_puntuacion[1])
                                {
                                    tipo_lexema = "Signo de Puntuacion Parentesis Cierra";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == signo_puntuacion[2])
                                {
                                    tipo_lexema = "Signo de Puntuacion Llave Abre";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == signo_puntuacion[3])
                                {
                                    tipo_lexema = "Signo de Puntuacion Llave Cierra";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == signo_puntuacion[4])
                                {
                                    tipo_lexema = "Signo de Puntuacion Punto y Coma";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (palabra[j] == signo_puntuacion[5])
                                {
                                    tipo_lexema = "Signo de Puntuacion Coma";
                                    agregar_dgvLexico_dbToken();
                                }

                                else if (int.TryParse(palabra[j], out numero))   // Identifica si es un numero Entero
                                {
                                    tipo_lexema = "Numero Entero";
                                    agregar_dgvLexico_dbToken();
                                }
                                else if (double.TryParse(palabra[j], out numero_decimal)) // Identifica si es un numero Decimal
                                {
                                    tipo_lexema = "Numero Decimal";
                                    agregar_dgvLexico_dbToken();
                                }


                                else if (char.IsLetter(palabra[j][validar_id]) && (palabra[j].Contains("[]") == false)
                                        && (palabra[j].Contains("!") == false) && (palabra[j].Contains("@") == false)
                                        && (palabra[j].Contains("#") == false) && (palabra[j].Contains("{") == false)
                                        &&  (palabra.Contains("{}") == false)
                                        && (palabra[j].Contains("(") == false) && (palabra[j].Contains(")") == false)
                                        && (palabra[j].Contains("()") == false) && (palabra[j].Contains("[") == false)
                                        && (palabra[j].Contains("]") == false) 
                                        && (palabras_reservadas.Contains(palabra[j]) == false))                                                                         
                                // Identificador 
                                {                                   
                                    tipo_lexema = "Identificador";
                                    agregar_dgvLexico_dbTokenyTablaSimbolos();
                                }


                                else if (palabra[j] == "/*") // Inicio de Comentario
                                {
                                    tipo_lexema = "Comentario [Inicio]";
                                    MessageBox.Show(tipo_lexema + "\n" + "Linea: " + (i + 1) + "\n" + "Columna: " + (j + 1), "Aviso de Comentario",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                                   
                                    estado = 1;
                                }

                                else if (palabra[j] == "\"") // Inicio de Cadena
                                {
                                    tipo_lexema = "Cadena [Inicio]";
                                    DataGridViewRow row = (DataGridViewRow)dgvLexico.Rows[0].Clone();
                                    row.Cells[0].Value = (palabra[j]); //lexema
                                    row.Cells[1].Value = tipo_lexema; //tipo lexema                                    
                                    row.Cells[2].Value = i + 1; // lineas
                                    row.Cells[3].Value = j + 1; // columnas
                                    dgvLexico.Rows.Add(row);
                                    estado = 3;
                                }


                                else if (palabras_reservadas.Contains(palabra[j]) == true)  // Identifica si es palabra Reservada
                                {
                                    tipo_lexema = "Palabra Reservada";
                                    agregar_dgvLexico_dbToken();
                                }

                                else
                                {
                                        tipo_lexema = "Error Lexico";
                                        DataGridViewRow row = (DataGridViewRow)dgvLexico.Rows[0].Clone();
                                        row.Cells[0].Value = (palabra[j]); //lexema
                                        row.Cells[1].Value = tipo_lexema; //tipo lexema                                    
                                        row.Cells[2].Value = i + 1; // lineas
                                        row.Cells[3].Value = j + 1; // columnas                                   
                                        dgvLexico.Rows.Add(row);
                                }
                                 


                                break;
                            case 1:

                                if (palabra[j] != null)
                                {
                                    if (palabra[j].Contains("*/") == true)
                                    {
                                        tipo_lexema = "Comentario [Fin]";
                                        MessageBox.Show(tipo_lexema + "\n" + "Linea: " + (i + 1) + "\n" + "Columna: " + (j + 1), "Aviso de Comentario",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        estado = 0;
                                    }
                                    else
                                    {
                                        int validar_comentario = 0;
                                        if (palabra[j] != "\n" || palabra[j] != "\t")
                                        {
                                            if (char.IsLetterOrDigit(palabra[j][validar_comentario]))
                                            {
                                                tipo_lexema = "Comentario [Contenido]";
                                                MessageBox.Show("El comentario es:  " + palabra[j] + "\n" + tipo_lexema + "\n" + "Linea: " + (i + 1) + "\n" +
                                                    "Columna: " + (j + 1), "Aviso de Comentario",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            }
                                        }
                                    }

                                }
                                break;

                            case 2:

                                break;
                            case 3:
                                if (palabra[j] != "\n")
                                {
                                    if (palabra[j] == "\"")
                                    {
                                        tipo_lexema = "Cadena [Fin]";
                                        DataGridViewRow row = (DataGridViewRow)dgvLexico.Rows[0].Clone();
                                        row.Cells[0].Value = (palabra[j]); //lexema
                                        row.Cells[1].Value = tipo_lexema; //tipo lexema                                    
                                        row.Cells[2].Value = i + 1; // lineas
                                        row.Cells[3].Value = j + 1; // columnas
                                        dgvLexico.Rows.Add(row);
                                        estado = 0;
                                    }
                                    else
                                    {
                                        int validar_cadena = 0;
                                        if (char.IsLetterOrDigit(palabra[j][validar_cadena]))
                                        {
                                            tipo_lexema = "Cadena [Contenido]";
                                            DataGridViewRow row = (DataGridViewRow)dgvLexico.Rows[0].Clone();
                                            row.Cells[0].Value = (palabra[j]); //lexema
                                            row.Cells[1].Value = tipo_lexema; //tipo lexema                                    
                                            row.Cells[2].Value = i + 1; // lineas
                                            row.Cells[3].Value = j + 1; // columnas
                                            dgvLexico.Rows.Add(row);

                                            // Agrega Lexema a la Tabla Token
                                            String unir_cadena = row.Cells[0].Value.ToString();
                                            String sqlInsert = "INSERT INTO token (lexema,tipo,linea,columna) values (@lexema,@tipo,@linea,@columna)";
                                            MySqlConnection objetoConexion1 = conexion_bd.establecerConexion();
                                            objetoConexion1.Open();
                                            MySqlCommand comando = new MySqlCommand(sqlInsert, objetoConexion1);
                                            comando.Parameters.AddWithValue("@lexema", "\"" + unir_cadena + "\"");
                                            comando.Parameters.AddWithValue("@tipo", row.Cells[1].Value);
                                            comando.Parameters.AddWithValue("@linea", row.Cells[2].Value);
                                            comando.Parameters.AddWithValue("@columna", row.Cells[3].Value);
                                            comando.ExecuteNonQuery();
                                            objetoConexion1.Close();
                                        }
                                    }
                                }

                                break;
                            default:

                                break;
                        }

                    }

                }
            }

            int contadordgv = dgvLexico.Rows.Count - 1;
            lblTokens.Text = contadordgv.ToString();
            dgvLexico.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void tablaDeSimbolosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaSimbolos tablaSimbolos = new frmTablaSimbolos();
            tablaSimbolos.Show();
        }

      
       // ------------------- COMIENZA ANALISIS SINTACTICO ---------------------------------------------

    public string getToken()
{
    // Establecer una conexión a la base de datos MySQL
    MySqlConnection objetoConexion = conexion_bd.establecerConexion();
    objetoConexion.Open();

    // Crear una consulta SQL para seleccionar un token basado en un índice
    String sql = "SELECT * FROM token where id_token = " + indice;
    string lexema = "";

    try
    {
        // Ejecutar la consulta SQL
        MySqlDataReader reader;
        MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
        reader = comando.ExecuteReader();

        // Verificar si hay resultados en la consulta
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                // Leer el valor del campo en la posición 1 (el segundo campo)
                lexema = reader.GetString(1);
                // También parece que actualiza algunas variables de clase llamadas "linea" y "columna"
                linea = reader.GetString(3);
                columna = reader.GetString(4);
            }
        }    
    }
    catch (Exception e)
    {
        // Manejo de excepciones: Mostrar un mensaje de error en un cuadro de diálogo
        MessageBox.Show("Error: " + e);
    }
    finally
    {
        // Cerrar la conexión a la base de datos y actualizar el índice
        objetoConexion.Close();
        indice = indice + 1;
    }

    // Devolver el valor del token obtenido de la base de datos
    return lexema;
}


        public string nextToken()
        {
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();
            int siguiente_indice = indice + 1;
            String sql = "SELECT * FROM token where id_token = " + siguiente_indice;        
            string lexema = "";
          
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        //lexema.Add(Convert.ToString(reader["lexema"]));
                        lexema = reader.GetString(1);
                        linea = reader.GetString(3);
                        columna = reader.GetString(4);                   
                    }

                   
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: " + e);
            }
            finally
            {
                objetoConexion.Close();
                
                
            }

             
            
            return lexema;
        }

        public string [] getTokenPorTipo()

        {
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();
            String sql = "SELECT * FROM token WHERE id_token = " + indice;
            string lexema = ""; string tipo = "";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lexema = reader.GetString(1);
                        tipo = reader.GetString(2);
                        linea = reader.GetString(3);
                        columna = reader.GetString(4);
                    }
                }
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: " + e);
                
            }
            finally
            {
                objetoConexion.Close();
                indice = indice + 1;
                linea = Convert.ToString(linea);
            }

            string[] matriz = new string[] {lexema,tipo}; 

            return matriz;
        }


        public void regla_gramatica_5_D() // REGLA GRAMATICA PARA DIM
        {
          

            if (getTokenPorTipo()[1] == "Identificador")
            {
                if (getToken().ToLower() == "as")
                {
                    switch (getToken().ToLower())
                    {
                        case "integer":
                            if (getToken() == ";")
                            {
                                
                                MessageBox.Show("DIM --- DECLARACION DE VARIABLES", "Exitosamente",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvSintactico.Rows.Add("CORRECTA", "DECLARACION DE VARIABLE: --> " 
                                 + " <--" +  " INTEGER" + " FILA: " + linea);
                                
                            }
                            else
                            {
                                indice = indice - 1;
                                MessageBox.Show(
                                "Se esperaba un punto y coma ';'" + "\n" +
                                "despues de la declaracion Dim" + "\n" + "en Linea: " + linea
                               , "Error de Sintaxis", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                                dgvSintactico.Rows.Add("INCORRECTA", "ERROR : --> Dentro de Dim: <--  SE esperaba Punto y Coma FILA: "
                                + linea);
                            }
                            break;
                        case "string":
                            if (getToken() == ";")
                            {
                                
                                MessageBox.Show("DIM --- DECLARACION DE VARIABLES", "Exitosamente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvSintactico.Rows.Add("CORRECTA", "DECLARACION DE VARIABLE: --> "
                                + " <--" + " STRING" + " FILA: " + linea);
                                
                            }
                            else
                            {
                                indice = indice - 1;
                                MessageBox.Show(
                                "Se esperaba un punto y coma ';'" + "\n" +
                                "despues de la declaracion Dim" + "\n" + "en Linea: " + linea
                               , "Error de Sintaxis", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                                dgvSintactico.Rows.Add("INCORRECTA", "ERROR : --> Dentro de Dim: <--  SE esperaba Punto y Coma FILA: "
                                + linea);
                            }
                            break;
                        case "decimal":
                            if (getToken() == ";")
                            {
                                
                                MessageBox.Show("DIM --- DECLARACION DE VARIABLES", "Exitosamente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvSintactico.Rows.Add("CORRECTA", "DECLARACION DE VARIABLE: --> "
                                + " <--" + " DECIMAL" + " FILA: " + linea);
                                 
                            }
                            else
                            {
                                indice = indice - 1;
                                MessageBox.Show(
                                "Se esperaba un punto y coma ';'" + "\n" +
                                "despues de la declaracion Dim" + "\n" + "en Linea: " + linea
                               , "Error de Sintaxis", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                                dgvSintactico.Rows.Add("INCORRECTA", "ERROR : --> Dentro de Dim: <--  SE esperaba Punto y Coma FILA: "
                                + linea);
                            }
                            break;
                        default:
                            indice = indice - 1;
                            MessageBox.Show(
                            "Tipo de Datos Permitidos: " + "\n" +
                            "1. String" + "\n" + "2. Integer" + "\n" + "3. Decimal" + "\n\n" + "en Linea: " + linea
                           , "Error de Sintaxis", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            dgvSintactico.Rows.Add("INCORRECTA", "ERROR : --> Dentro de Dim: <--  Tipo de Dato Incorrecto FILA: "
                            + linea);
                            break;
                    }
                                     
                }
                else
                {
                    indice = indice - 1;
                    MessageBox.Show(
                    "Se esperaba palabra reservada As" + 
                    "\n" + "en Linea: " + linea
                   , "Error de Sintaxis", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    dgvSintactico.Rows.Add("INCORRECTA", "ERROR : --> Dentro de Dim: <--  Falta Palabra Reservada As, FILA: "
                    + linea);
                }
            }
            else
            {
                
                indice = indice - 1;
                MessageBox.Show(
                "Se esperaba nombre de variable" + 
                 "\n" + "en Linea: " + linea
               , "Error de Sintaxis", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                dgvSintactico.Rows.Add("INCORRECTA", "ERROR : --> Dentro de Dim: <--  Falta Id o Variable FILA: "
                + linea);
            }
        }

        public void regla_gramatica_5_A() // REGLA GRAMATICA PARA ASIGNACION
        {

          
            if (getToken() == ":=")
            {
                switch (getTokenPorTipo()[1])
                {
                    case "Identificador":
                        if (getToken() == ";")
                        {
                            MessageBox.Show("Asignacion de Variable Identificador","Exitosamente",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                            dgvSintactico.Rows.Add("CORRECTA", "ASIGNACION DE VARIABLE IDENTIFICADOR FILA: "
                                + linea);
                        }
                        else
                        {
                            indice = indice - 1;
                            dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR : --> Dentro de Declaracion: <--  Falta Punto y coma ';' FILA: "
                             + linea);
                        }
                    break;
                    case  "Numero Entero":
                        if(getToken() == ";")
                        {
                            MessageBox.Show("Asignacion de Variable Numerica", "Exitosamente",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSintactico.Rows.Add("CORRECTA", "ASIGNACION DE VARIABLE NUMERICA FILA: "
                                + linea);
                        }
                        else
                        {
                            indice = indice - 1;
                            dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR : --> Dentro de Declaracion: <--  Falta Punto y coma ';' FILA: "
                             + linea);
                        }
                    break;
                    case "Numero Decimal":
                        if (getToken() == ";")
                        {
                            MessageBox.Show("Asignacion de Variable Decimal", "Exitosamente",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSintactico.Rows.Add("CORRECTA", "ASIGNACION DE VARIABLE DECIMAL FILA: "
                                + linea);
                        }
                        else
                        {
                            indice = indice - 1;
                            dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR : --> Dentro de Declaracion: <--  Falta Punto y coma ';' FILA: "
                             + linea);
                        }

                        break;
                    case "Palabra Reservada":
                        if (getToken()== ";")
                        {
                            dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR: --> Dentro de Declaracion <-- Es Palabra Reservada FILA: "
                                + linea);
                        }
                        else
                        {
                            indice = indice - 1;
                            dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR: --> Dentro de Declaracion <-- Es Palabra Reservada FILA: "
                                + linea);
                            dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR : --> Dentro de Declaracion: <--  Falta Punto y coma ';' FILA: "
                             + linea);
                        }
                        break;
                    case "Cadena [Contenido]":
                        if (getToken() == ";")
                        {
                            MessageBox.Show("Asignacion de Variable String", "Exitosamente",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSintactico.Rows.Add("CORRECTA", "ASIGNACION DE VARIABLE STRING FILA: "
                                + linea);
                        }
                        else
                        {
                            indice = indice - 1;
                            dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR : --> Dentro de Declaracion: <--  Falta Punto y coma ';' FILA: "
                             + linea);
                        }
                        break;
                    default:
                        indice = indice - 1;
                        dgvSintactico.Rows.Add("INCORRECTA",
                            "ERROR: --> Dentro de Declaracion <-- Se esperaba Id, número o cadena FILA: "
                                + linea);
                        break;
                }
            }
            else
            {
                indice = indice - 1;
                dgvSintactico.Rows.Add("INCORRECTA",
                "ERROR: --> Dentro de Declaracion <-- Se esperaba Asignacion ':=' FILA: "
                    + linea);
            }
            
        }
            
        public void regla_gramatica_5_I() // REGLA GRAMATICA PARA IF
        {
            if(getToken() == "(")
            {
    
                if (getTokenPorTipo()[1] == "Identificador")
                {
                    switch (getToken())
                    {
                        case "=": // CONDICIONAL CON SIMBOLO IGUAL
                            if (getTokenPorTipo()[1] == "Numero Entero")
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Entero": // SI ES IGUAL A NUMERO ENTERO POR EJEMPLO B = 1
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Igual a Numero Entero <-- SATISFACTORIA EN FILA: "
                                + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);

                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        break;
                                }
                               
                            } 
                            else
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Decimal":      // SI ES IGUAL A NUMERO DECIMAL, POR EJEMPLO C = 1.50
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Igual a Numero Decimal <-- SATISFACTORIA EN FILA: "
                                 + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Cadena [Contenido]": // SI ES IGUAL A CADENA STRING, POR EJEMPLO D = " HOLA "
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Igual a Cadena String <-- SATISFACTORIA EN FILA: "
                                         + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Identificador": // SI ES IGUAL A UN IDENTIFICADOR, POR EJEMPLO F = G
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Igual a Identificador <-- SATISFACTORIA EN FILA: "
                               + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        indice = indice - 1;
                                        dgvSintactico.Rows.Add("INCORRECTA",
                                        "ERROR --> Sentencia If <-- TIPO DE DATO NO VALIDO despues de '=' en "
                                        + " FILA: " + linea);
                                        break;
                                }
                            }
                            break;

                        case ">": // CONDICIONAL CON SIMBOLO MAYOR
                            if (getTokenPorTipo()[1] == "Numero Entero")
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Entero": // SI ES MAYOR A NUMERO ENTERO POR EJEMPLO B > 1
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Mayor a Numero Entero <-- SATISFACTORIA EN FILA: "
                                + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                            else
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Decimal":      // SI ES MAYOR A NUMERO DECIMAL, POR EJEMPLO C > 1.50
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Mayor a Numero Decimal <-- SATISFACTORIA EN FILA: "
                                 + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Cadena [Contenido]": // SI ES MAYOR A CADENA STRING, POR EJEMPLO D > " HOLA "
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Mayor a Cadena String <-- SATISFACTORIA EN FILA: "
                                         + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Identificador": // SI ES MAYOR A UN IDENTIFICADOR, POR EJEMPLO F > G
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Mayor a Identificador <-- SATISFACTORIA EN FILA: "
                               + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        indice = indice - 1;
                                        dgvSintactico.Rows.Add("INCORRECTA",
                                        "ERROR --> Sentencia If <-- TIPO DE DATO NO VALIDO despues de '>' en "
                                        + " FILA: " + linea);
                                        break;
                                }
                            }
                            break;
                        case "<":
                            if (getTokenPorTipo()[1] == "Numero Entero")
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Entero": // SI ES MENOR A NUMERO ENTERO POR EJEMPLO B < 1
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Menor a Numero Entero <-- SATISFACTORIA EN FILA: "
                                + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                            else
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Decimal":      // SI ES MENOR A NUMERO DECIMAL, POR EJEMPLO C < 1.50
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Menor a Numero Decimal <-- SATISFACTORIA EN FILA: "
                                 + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Cadena [Contenido]": // SI ES MENOR A CADENA STRING, POR EJEMPLO D < " HOLA "
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Menor a Cadena String <-- SATISFACTORIA EN FILA: "
                                         + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Identificador": // SI ES MENOR A UN IDENTIFICADOR, POR EJEMPLO F < G
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Menor a Identificador <-- SATISFACTORIA EN FILA: "
                               + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        indice = indice - 1;
                                        dgvSintactico.Rows.Add("INCORRECTA",
                                        "ERROR --> Sentencia If <-- TIPO DE DATO NO VALIDO despues de '<' en "
                                        + " FILA: " + linea);
                                        break;
                                }
                            }
                            break;
                        case "<>":
                            if (getTokenPorTipo()[1] == "Numero Entero")
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Entero": // SI ES DISTINTO A NUMERO ENTERO POR EJEMPLO B <> 1
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Diferente que Numero Entero <-- SATISFACTORIA EN FILA: "
                                + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                            else
                            {
                                indice = indice - 1;
                                switch (getTokenPorTipo()[1])
                                {
                                    case "Numero Decimal":      // SI ES DIFERENTE A NUMERO DECIMAL, POR EJEMPLO C <> 1.50
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Diferente que Numero Decimal <-- SATISFACTORIA EN FILA: "
                                 + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Cadena [Contenido]": // SI ES DIFERENTE A CADENA STRING, POR EJEMPLO D <> " HOLA "
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Diferente que Cadena String <-- SATISFACTORIA EN FILA: "
                                         + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    case "Identificador": // SI ES DIFERENTE A UN IDENTIFICADOR, POR EJEMPLO F <> G
                                        dgvSintactico.Rows.Add("CORRECTA", "CONDICIONAL --> Diferente que Identificador <-- SATISFACTORIA EN FILA: "
                               + linea);

                                        if (getToken() == ")")
                                        {
                                            if (getToken().ToLower() == "then")
                                            {

                                                if (getTokenPorTipo()[1] == "Identificador")
                                                {
                                                    int linea_if = Convert.ToInt32(linea);
                                                    linea_if = linea_if - 1;
                                                    dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Condicional If <-- SATISFACTORIA EN FILA: "
                                                    + linea_if);
                                                    regla_gramatica_5_A();


                                                    if (getToken().ToLower() == "else")
                                                    {

                                                        dgvSintactico.Rows.Add("CORRECTA", "ESTRUCTURA --> Sentencia Else <-- SATISFACTORIA EN FILA: "
                                                         + linea);

                                                        if (getTokenPorTipo()[1] == "Identificador")
                                                        {
                                                            regla_gramatica_5_A();

                                                        }
                                                        else
                                                        {
                                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                            linea_convertida = linea_convertida - 1;
                                                            dgvSintactico.Rows.Add("INCORRECTA",
                                                            "ERROR --> Sentencia Else <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                            + " FILA: " + linea_convertida);

                                                        }

                                                    }
                                                    else
                                                    {
                                                        indice = indice - 1;
                                                    }


                                                }
                                                else
                                                {
                                                    indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                    linea_convertida = linea_convertida - 1;
                                                    dgvSintactico.Rows.Add("INCORRECTA",
                                                    "ERROR --> Sentencia If <-- NO PUEDE IR VACIA y SOLO ACEPTA ASIGNACIONES en "
                                                    + " FILA: " + linea_convertida);
                                                }




                                            }
                                            else
                                            {
                                                indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                                linea_convertida = linea_convertida - 1;
                                                dgvSintactico.Rows.Add("INCORRECTA",
                                                "ERROR --> Sentencia If <-- FALTA PALABRA THEN en "
                                                + " FILA: " + linea_convertida);
                                            }
                                        }
                                        else
                                        {
                                            indice = indice - 1; int linea_convertida = Convert.ToInt32(linea);
                                            linea_convertida = linea_convertida - 1;
                                            dgvSintactico.Rows.Add("INCORRECTA",
                                            "ERROR --> Sentencia If <-- FALTA CIERRE DE PARENTESIS ')' en "
                                            + " FILA: " + linea_convertida);
                                        }
                                        break;
                                    default:
                                        indice = indice - 1;
                                        dgvSintactico.Rows.Add("INCORRECTA",
                                        "ERROR --> Sentencia If <-- TIPO DE DATO NO VALIDO despues de '<>' en "
                                        + " FILA: " + linea);
                                        break;
                                }
                            }
                            break;
                        default:
                            indice = indice - 1;
                            dgvSintactico.Rows.Add("INCORRECTA",
                                        "ERROR --> Sentencia If <-- OPERADOR NO VALIDO, en "
                                        + " FILA: " + linea);
                            break;
                    }
                }
                else
                {
                    indice = indice - 1;
                    dgvSintactico.Rows.Add("INCORRECTA",
                                        "ERROR --> Sentencia If <-- SE ESPERABA IDENTIFICADOR en "
                                        + " FILA: " + linea);
                }
            }    
            else
            {
                indice = indice - 1;
                dgvSintactico.Rows.Add("INCORRECTA",
                                        "ERROR --> Sentencia If <-- SE ESPERABA APERTURA DE PARENTESIS '(' en "
                                        + " FILA: " + linea);
            }
            
          
           


        }
        
        public void regla_gramatica_2_3_4_C ()
        {

            if (getTokenPorTipo()[1] == "Identificador")
            {
                indice = indice - 1;

                switch (getTokenPorTipo()[1])
                {
                    case "Identificador":
                        regla_gramatica_5_A();
                        break;
                    default:
                        dgvSintactico.Rows.Add("INCORRECTA",
                       "ERROR : --> Dentro de Main: <--  No es Identificador, FILA: "
                        + linea);
                        break;

                }
            }

            else
            {

                indice = indice - 1;

                switch (getToken().ToLower())
                {
                    case "dim":
                        regla_gramatica_5_D();
                        break;
                    case "if":
                        regla_gramatica_5_I();
                        break;
                    default:
                        
                        dgvSintactico.Rows.Add("INCORRECTA",
                        "ERROR : --> Dentro de Main: <--  No es Dim, If o Id, FILA: "
                         + linea);
                        break;
                }

            }
        }

        public void regla_gramatica_Main_S ()
        {
            
            if (getToken().ToLower() == "main")
            {
                
                if(getToken() == "(")
                {
                    if(getToken() == ")")
                    {
                        
                        if (getToken() == "{")
                        {
                            while (getToken() != "}")
                            {
                                indice = indice - 1;
                                regla_gramatica_2_3_4_C();                               
                            }

                            indice = indice - 1;
                     
                            if (getToken()== "}")
                                {
                                
                                    if (getToken() == "")
                                    {
                                    dgvSintactico.Rows.Add("CORRECTA", "FINALIZACION --> Main: <-- FILA: " + linea);
                                    }
                                    else
                                    {
                                        indice = indice - 1; 
                                        MessageBox.Show("Estructura de Main es Incorrecta" + "\n"
                                        + "Se encontró el token: "+ getToken() + "\n" + "despues de Main en la" +"\n"+
                                        "Linea: "+linea +" Columna: "+columna, 
                                        "Error de Sintaxis Fuera del Main",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        dgvSintactico.Rows.Add("INCORRECTA", "ERROR en: --> Main: <--  Fuera del Main en Linea: "+linea+
                                            " y en Columna: "+columna);
                                        
                                    }
                                }
                                else
                                {
                                    
                                    MessageBox.Show("Estructura de Main es Incorrecta" + "\n"
                                     + "Se esperaba cierre de llave '}' en la"  + "\n" +
                                       "Linea: " + linea + " Columna: " + columna,
                                       "Falta cierre de llave en Main",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    dgvSintactico.Rows.Add("INCORRECTA", "ERROR en: --> Main: <--  Se esperaba cierre de llave en FILA: " + linea);



                            }
                            }
                            else
                            {
                            MessageBox.Show("Estructura de Main es Incorrecta" + "\n"
                                  + "Se esperaba apertura de llave '{' en la" + "\n" +
                                  "Linea: " + linea + " Columna: " + columna,
                                  "Falta apertura de llave en Main",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvSintactico.Rows.Add("INCORRECTA", "ERROR en: --> Main: <--  Se esperaba apertura de llave en: " + linea +
                                " y en Columna: " + columna);
                           
                        }                      

                    }
                    else
                    {
                        MessageBox.Show("Estructura de Main es Incorrecta" + "\n"
                                      + "Se esperaba cierre de parentesis ')' en la" + "\n" +
                                      "Linea: " + linea + " Columna: " + columna,
                                      "Falta cierre de parentesis en Main",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvSintactico.Rows.Add("INCORRECTA", "ERROR en: --> Main: <--  Se esperaba cierre de parentesis en: " + linea +
                            " y en Columna: " + columna);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Estructura de Main es Incorrecta" + "\n"
                                      + "Se esperaba apertura de parentesis '(' en la" + "\n" +
                                      "Linea: " + linea + " Columna: " + columna,
                                      "Falta apertura de parentesis en Main",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvSintactico.Rows.Add("INCORRECTA", "ERROR en: --> Main: <--  Se esperaba apertura de parentesis en: " + linea +
                        " y en Columna: " + columna);
                   
                }
            }
            else
            {
                MessageBox.Show("Estructura de Main es Incorrecta" + "\n"
                                      + "Se esperaba Main ( ) { }" + "\n" +"para inicializar el codigo, error en: " + "\n" +
                                      "Linea: " + linea + " Columna: " + columna,
                                      "Estructura de Main Invalida",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvSintactico.Rows.Add("INCORRECTA", "ERROR en: --> Main: <--  Estructura de Main invalida en linea: " + linea +
                    " y en Columna: " + columna);
               
            }

            indice = 1;
        }



        private void btnSintactico_Click(object sender, EventArgs e)
        {
            dgvSintactico.Rows.Clear();
            
            regla_gramatica_Main_S();

            for (int x = 0; x < dgvSintactico.RowCount; x++)
            {
                if ((dgvSintactico.Rows[x].Cells[0].Value.ToString()).Equals("INCORRECTA"))
                {
                    dgvSintactico.Rows[x].DefaultCellStyle.BackColor = Color.Pink;
                    
                }
                else if ((dgvSintactico.Rows[x].Cells[0].Value.ToString()).Equals("CORRECTA"))
                {

                    dgvSintactico.Rows[x].DefaultCellStyle.BackColor = Color.YellowGreen;
                }
            }

        }

        private void dgvSintactico_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvSintactico.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}