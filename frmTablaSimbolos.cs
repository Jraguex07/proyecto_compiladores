using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilador_v1._0
{
    public partial class frmTablaSimbolos : Form
    {
        public frmTablaSimbolos()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtIdentificador.Text = "";
            txtTipoToken.Text = "";
            txtBorrarIdentificador.Text = "";
            txtBorrarTipoToken.Text = "";
            txtBorrarIdTabla.Text = "";
            txtIdTabla.Text = "";
            txtBorrarIdTabla.Focus();
        }

        private void btnGrabarDatos_Click(object sender, EventArgs e)
        {
            String id_tabla = txtIdTabla.Text;
            String identificador = txtIdentificador.Text;
            String tipo_token = txtTipoToken.Text;
            if (id_tabla == "" && identificador != "" && txtTipoToken.Text != "")
            {
                String sql = "INSERT INTO tabla_simbolos (id,tipo_token) VALUES (@id, @tipo_token);";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.Parameters.AddWithValue("@id", identificador);
                    comando.Parameters.AddWithValue("@tipo_token", tipo_token);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado.");
                    limpiar();
                    txtIdentificador.Focus();

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error al guardar. No pueden Existir 2 Identificadores con el mismo Nombre en la Tabla de Simbolos. ",
                        "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    limpiar();
                    txtIdentificador.Focus();
                }
                finally
                {
                    objetoConexion.Close();
                }
            } 
            else if (id_tabla == "" || identificador == "" || tipo_token == "")
            {
                MessageBox.Show("Para Agregar o Modificar un registro debes escribir el Id y el Tipo de Token.");
            }
           
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            String id_tabla = txtIdTabla.Text;
            String identificador = txtIdentificador.Text;
            String tipo_token = txtTipoToken.Text;
            if (identificador != "" && txtTipoToken.Text != "")
            {
                String sql = "UPDATE tabla_simbolos SET id='" + identificador
                    + "',tipo_token='"+tipo_token+"' WHERE id_tabla='" + id_tabla + "'";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Modificado.");
                    limpiar();             
                }
                catch (MySqlException )
                {
                    MessageBox.Show("Error al guardar. No pueden Existir 2 Identificadores con el mismo Nombre en la Tabla de Simbolos. ",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    txtIdentificador.Focus();
                }
                finally
                {
                    objetoConexion.Close();
                }

            }
            else if ( id_tabla == "" || identificador == "" || tipo_token == "")
            {
                MessageBox.Show("Para Agregar o Modificar un registro debes escribir el Id y el Tipo de Token.");
            }       
        }



        public void refreshreg()
        {
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            DataTable datatable = new DataTable();
            MySqlDataReader reader;
            String sql = "SELECT * FROM tabla_simbolos";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                comando.CommandType = CommandType.Text;
                objetoConexion.Open();
                reader = comando.ExecuteReader();
                datatable.Load(reader);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Consultar: " + ex.Message);
            }
            finally
            {
                objetoConexion.Close();
            }
            dgvTablaSimbolos.DataSource = datatable;
            dgvTablaSimbolos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void frmTablaSimbolos_Load(object sender, EventArgs e)
        {
            refreshreg();
            timerTablaSimbolos.Start();
        }

        private void timerTablaSimbolos_Tick(object sender, EventArgs e)
        {
            timerTablaSimbolos.Start();
            refreshreg();
        }

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            String borrar_id_tabla = txtBorrarIdTabla.Text;
            String borrar_identificador = txtBorrarIdentificador.Text;
            String borrar_Tipo_Token = txtBorrarTipoToken.Text;
            if (borrar_identificador != "")
            {
                String sql = "DELETE FROM tabla_simbolos WHERE id_tabla='" + borrar_id_tabla + "';";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado.");
                    limpiar();
                    txtBorrarIdTabla.Focus();
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
        }



        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtBorrarIdTabla_TextChanged(object sender, EventArgs e)
        {
            String borrar_id_tabla = txtBorrarIdTabla.Text;
            String borrar_identificador = txtBorrarIdentificador.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT * from tabla_simbolos where id_tabla='" + borrar_id_tabla + "'";
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtBorrarIdentificador.Text = reader.GetString(1);
                        txtBorrarTipoToken.Text = reader.GetString(2);
                    }
                }
                else
                {
                    txtBorrarIdentificador.Text = ""; txtBorrarTipoToken.Text = "";
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Buscar: " + ex.Message);
            }
            finally
            {
                objetoConexion.Close();
            }
        }

        private void txtIdTabla_TextChanged(object sender, EventArgs e)
        {
            String id_tabla = txtIdTabla.Text;
            String identificador = txtIdentificador.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT * from tabla_simbolos where id_tabla='" + id_tabla + "'";
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            objetoConexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtIdentificador.Text = reader.GetString(1);
                        txtTipoToken.Text = reader.GetString(2);
                    }
                }
                else
                {
                    txtTipoToken.Text = ""; txtIdentificador.Text = "";
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Buscar: " + ex.Message);
            }
            finally
            {
                objetoConexion.Close();
            }
        }
    }
}
