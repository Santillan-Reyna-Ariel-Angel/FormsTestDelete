using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormsTestDelete
{
    public partial class Form1 : Form
    {
        public string usuario;
        public string contrasenia;
        public string usuarioId;

        //string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        MySqlConnection conexion = new MySqlConnection(
            "SERVER=LOCALHOST; DATABASE=conexion; UID=root; PASSWORD=Mysqlpassword_1"
        );

        // Constructor de la clase:
        public Form1()
        {
            // InitializeComponent(): Inicializa todos los controles colocados en el formulario a través del diseñador de Windows Forms
            InitializeComponent();
        }

        // Funcion que se ejecuta automaticamente antes que el formulario se muestre por 1ra vez (para cargar datos que se mostraran al usuario/interfaz):
        private void Form1_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            string inputUsuario = textBoxUsuario.Text; // Capturamos el texto del TextBox
            usuario = inputUsuario;
        }

        private void textBoxContrasenia_TextChanged(object sender, EventArgs e)
        {
            string inputContrasenia = textBoxContrasenia.Text;
            contrasenia = inputContrasenia;
        }

        private bool validarUsuario()
        {
            bool usuarioValido;

            try
            {
                // Abrir la conexion:
                conexion.Open();

                // Consulta sql con parametros (@x) :
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM usuarios WHERE usuario = @usuario and contrasena = @contrasenia",
                    conexion
                );

                // Agregar los parámetros al comando y asignar sus valores( o variable):
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasenia", contrasenia);

                // Ejecutar la consulta y obtener el resultado
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Si hay resultados:
                    string usuarioIdBD = reader["user_id"].ToString(); // Almacenar el resultado en una variable
                    string usuarioBD = reader["usuario"].ToString();
                    usuario = usuarioBD;
                    usuarioId = usuarioIdBD;
                    usuarioValido = true;
                }
                else
                {
                    // No hay resultados:
                    usuarioValido = false;
                }

                // Cerrar el lector y la conexión
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                usuarioValido = false;
                MessageBox.Show("Error: " + ex.Message);
            }

            return usuarioValido;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioValido;
            usuarioValido = validarUsuario();

            if (usuarioValido == true)
            {
                MessageBox.Show("Se encontró el usuario.");
                //Console.WriteLine("Se encontró el usuario.");
            }
            else
            {
                MessageBox.Show("No se encontró el usuario.");
                //Console.WriteLine("No se encontró el usuario.");
            }
        }
    }
}
