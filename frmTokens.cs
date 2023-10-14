using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace compilador_v1._0
{
    public partial class frmTokens : Form
    {
        public frmTokens()
        {
            InitializeComponent();
        }

        private void btnGrabarDatos_Click(object sender, EventArgs e)
        {
            String id_token = txtIdToken.Text;
            String lexema = txtLexema.Text;
            String tipo = txtTipo.Text;
            
            if (id_token == "" && lexema != "" && tipo != "")
            {
                String sql = "INSERT INTO token (lexema,tipo) VALUES ('" + lexema + "','"+ tipo + "');";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado.");
                    limpiar();
                    txtLexema.Focus();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al Guardar: " + ex.Message);
                }
                finally
                {
                    objetoConexion.Close();
                }



            }
            else if (id_token != "" && lexema != "" && tipo!= "")
            {
                String sql = "UPDATE token SET lexema='" + lexema
                    + "' ,tipo='" +tipo+"'  WHERE id_token='" + id_token + "'";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Modificado.");
                    limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al Modificar: " + ex.Message);
                }
                finally
                {
                    objetoConexion.Close();
                }

            }
            else if (id_token == "" && lexema == "" && tipo == "")
            {
                MessageBox.Show("Para agregar un registro debes escribir los datos que se solicitan.");
            }
            else 
            {
                MessageBox.Show("Para Modificar un registro debes Escribir Un Id Existente y los datos correspondientes.");
            }
        }



        private void limpiar()
        {
            txtIdToken.Text = "";
            txtLexema.Text = "";
            txtTipo.Text = "";
            txtBorrarIdToken.Text = "";
            txtBorrarLexema.Text = "";
            txtBorrarTipo.Text = "";
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiar();
            txtLexema.Text = "";
        }

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            String borrar_id_token = txtBorrarIdToken.Text;
            String borrar_lexema = txtBorrarLexema.Text;
            String borrar_tipo = txtBorrarTipo.Text;
            
            if (borrar_id_token != "")
            {
                String sql = "DELETE FROM token WHERE id_token='" + borrar_id_token + "';";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado.");
                    limpiar();
                    txtBorrarIdToken.Focus();
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

        private void txtIdToken_TextChanged(object sender, EventArgs e)
        {
            String id_token = txtIdToken.Text;
            String lexema = txtLexema.Text;
            String tipo = txtTipo.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT * from token where id_token='" + id_token + "'";
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
                        txtIdToken.Text = reader.GetString(0);
                        txtLexema.Text = reader.GetString(1);
                        txtTipo.Text = reader.GetString(2);
                       
                    }
                }
                else
                {
                    txtLexema.Text = ""; txtTipo.Text = ""; 
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshreg();
            timerToken.Start();
        }

        private void frmTokens_Load(object sender, EventArgs e)
        {
            refreshreg();
            timerToken.Start();
        }

        public void refreshreg()
        {
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            DataTable datatable = new DataTable();
            MySqlDataReader reader;
            String sql = "SELECT * FROM token";
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
            dgvTokens.DataSource = datatable;
            dgvTokens.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void txtBorrarIdToken_TextChanged(object sender, EventArgs e)
        {

            String id_token = txtBorrarIdToken.Text;
            String lexema = txtBorrarLexema.Text;
            String tipo = txtBorrarTipo.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT * from token where id_token='" + id_token + "'";
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
                        txtBorrarIdToken.Text = reader.GetString(0);
                        txtBorrarLexema.Text = reader.GetString(1);
                        txtBorrarTipo.Text = reader.GetString(2);
                        
                    }
                }
                else
                {
                    txtBorrarLexema.Text = ""; txtBorrarTipo.Text = "";
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
