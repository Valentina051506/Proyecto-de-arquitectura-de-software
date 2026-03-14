using RedMotorERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedMotorERP
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Boton Clientes
        private void button1_Click(object sender, EventArgs e)
        {
            ClientesForm Clientes = new ClientesForm();
            Clientes.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //Boton Cerrar Sesión
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
}

    }


