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

namespace FormsTestDelete
{
    public partial class FormHome : Form
    {
        public string usuario;
        public string usuarioId;
        public string saldoTarjeta;
        public string saldoEfectivo;

        MySqlConnection conexion = new MySqlConnection(
            "SERVER=LOCALHOST; DATABASE=conexion; UID=root; PASSWORD=Mysqlpassword_1"
        );

        // El contructor recibe la variable que se envio desde otro formulario(login):
        public FormHome(string recibirUsuario, string recibirUsuarioId)
        {
            InitializeComponent();
            usuario = recibirUsuario;
            usuarioId = recibirUsuarioId;
        }

        private void cargarSalodos()
        {
            try
            {
                // Abrir la conexion:
                conexion.Open();

                // Consulta sql con parametros (@x) :
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT saldo_tarjeta, saldo_efectivo FROM usuarios WHERE usuario = @usuario",
                    conexion
                );

                // Agregar los parámetros al comando y asignar sus valores( o variable):
                cmd.Parameters.AddWithValue("@usuario", usuario);

                // Ejecutar la consulta y obtener el resultado
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Si hay resultados:
                    string saldoTarjetaBD = reader["saldo_tarjeta"].ToString(); // Almacenar el resultado en una variable
                    string saldoEfectivoBD = reader["saldo_efectivo"].ToString();
                    saldoTarjeta = saldoTarjetaBD;
                    saldoEfectivo = saldoEfectivoBD;
                }
                else
                {
                    saldoTarjeta = "No se encontro saldo tarjeta";
                    saldoEfectivo = "No se encontro saldo efectivo";
                }

                // Cerrar el lector y la conexión
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // labelSaludo.Text = "Bienvenido " + usuario + " !!!";
            labelSaludo.Text = $"Bienvenido {usuario} ...!!!";
            cargarSalodos();
            textBoxSaldoTarjeta.Text = saldoTarjeta;
            textBoxSaldoEfectivo.Text = saldoEfectivo;
        }

        private void labelSaludo_Click(object sender, EventArgs e) { }

        private void textBoxSaldoTarjeta_TextChanged(object sender, EventArgs e) { }

        private void textBoxSaldoEfectivo_TextChanged(object sender, EventArgs e) { }
    }
}
