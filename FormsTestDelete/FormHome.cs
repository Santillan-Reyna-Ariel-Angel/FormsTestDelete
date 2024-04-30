using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTestDelete
{
    public partial class FormHome : Form
    {
        public string usuario;

        // El contructor recibe la variable que se envio desde otro formulario(login):
        public FormHome(string recibirUsuario)
        {
            InitializeComponent();
            usuario = recibirUsuario;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // labelSaludo.Text = "Bienvenido " + usuario + " !!!";
            labelSaludo.Text = $"Bienvenido {usuario} ...!!!";
        }

        private void labelSaludo_Click(object sender, EventArgs e) { }
    }
}
