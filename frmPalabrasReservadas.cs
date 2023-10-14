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
    public partial class frmPalabrasReservadas : Form
    {
        public frmPalabrasReservadas()
        {
            InitializeComponent();
        }

        private void btnGrabarDatos_Click(object sender, EventArgs e)
        {
            String id_palabra_reservada = txtIdPalabraReservada.Text;
            String palabra_reservada = txtPalabraReservada.Text;
            if (id_palabra_reservada == "" && txtPalabraReservada.Text != "")
            {
                String sql = "INSERT INTO palabra_reservada (palabra_reservada) VALUES ('" + palabra_reservada + "');";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado.");
                    limpiar();
                    txtPalabraReservada.Focus();
                    
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
            else if(id_palabra_reservada != "" && txtPalabraReservada.Text != "")
            {
                String sql = "UPDATE palabra_reservada SET palabra_reservada='" + palabra_reservada
                    + "' WHERE id_palabra_reservada='" + id_palabra_reservada + "'";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Modificado.");
                    limpiar();
                    this.dgvPalabraReservada.Refresh();
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
            else if(id_palabra_reservada == "" && txtPalabraReservada.Text == "")
            {
                MessageBox.Show("Para agregar un registro debes escribir la palabra reservada.");
            }
            else
            {
                MessageBox.Show("Para Modificar un registro debes Escribir Un Id Existente y la nueva palabra Reservada.");
            }
        }

       

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            String borrar_id_palabra_reservada = txtBorrarIdPalabraReservada.Text;
            String borrar_palabra_reservada = txtEliminarPalabraReservada.Text;
            if (borrar_id_palabra_reservada != "")
            {
                String sql = "DELETE FROM palabra_reservada WHERE id_palabra_reservada='" + borrar_id_palabra_reservada + "';";
                MySqlConnection objetoConexion = conexion_bd.establecerConexion();
                objetoConexion.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado.");
                    limpiar();
                    txtBorrarIdPalabraReservada.Focus();
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

        private void limpiar()
        {
            txtIdPalabraReservada.Text = "";
            txtPalabraReservada.Text = "";
            txtBorrarIdPalabraReservada.Text = "";
            txtEliminarPalabraReservada.Text = "";

        }

        private void txtIdPalabraReservada_TextChanged(object sender, EventArgs e)
        {
            
            String id_palabra_reservada = txtIdPalabraReservada.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT * from palabra_reservada where id_palabra_reservada='" + id_palabra_reservada +"'";
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
                        txtIdPalabraReservada.Text = reader.GetString(0);
                        txtPalabraReservada.Text = reader.GetString(1);
                        this.dgvPalabraReservada.Refresh();
                    }
                    } else
                    {
                    txtPalabraReservada.Text = "";
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

        private void frmPalabrasReservadas_Load(object sender, EventArgs e)
        {
            timerPalabras.Start();
            
        }

        public void refreshreg()
        {
            MySqlConnection objetoConexion = conexion_bd.establecerConexion();
            DataTable datatable = new DataTable();
            MySqlDataReader reader;
            String sql = "SELECT * FROM palabra_reservada";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objetoConexion);
                comando.CommandType = CommandType.Text;
                objetoConexion.Open();
                reader = comando.ExecuteReader();
                datatable.Load(reader);
                this.dgvPalabraReservada.Refresh();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Consultar: " + ex.Message);
            }
            finally
            {
                objetoConexion.Close();
            }
            dgvPalabraReservada.DataSource = datatable;
            dgvPalabraReservada.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshreg();
            timerPalabras.Start();
        }

        private void txtBorrarIdPalabraReservada_TextChanged(object sender, EventArgs e)
        {
            String id_borrar_palabra_reservada = txtBorrarIdPalabraReservada.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT * from palabra_reservada where id_palabra_reservada='" + id_borrar_palabra_reservada + "'";
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
                        txtBorrarIdPalabraReservada.Text = reader.GetString(0);
                        txtEliminarPalabraReservada.Text = reader.GetString(1);
                      
                    }
                }
                else
                {
                    txtEliminarPalabraReservada.Text = "";
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

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiar();
            txtPalabraReservada.Focus();
        }

    }
}

