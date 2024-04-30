using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormsTestDelete
{
    public partial class Form1 : Form
    {
        //string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        MySqlConnection conexion = new MySqlConnection(
            "SERVER=LOCALHOST; DATABASE=conexion; UID=root; PASSWORD=Mysqlpassword_1"
        );

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private MySqlConnection establecerConexion()
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT usuario FROM usuarios WHERE user_id = 7",
                    conexion
                );

                // Ejecutar la consulta y obtener el resultado
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Si hay resultados:

                    string usuario = reader["usuario"].ToString(); // Almacenar el resultado en una variable
                    Console.WriteLine(usuario); // Mostrar el resultado
                    MessageBox.Show("Usuario encontrado: " + usuario); // Mostrar el resultado en un MessageBox
                }
                else
                {
                    Console.WriteLine("No se encontró el usuario.");
                    MessageBox.Show("No se encontró el usuario.");
                }

                // No olvides cerrar el lector y la conexión
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return conexion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            establecerConexion();
        }
    }
}
