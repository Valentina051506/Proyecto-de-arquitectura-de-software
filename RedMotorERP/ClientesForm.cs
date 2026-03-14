using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedMotorERP
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            tablaClientes.Columns.Add("Nombre", "Nombre");
            tablaClientes.Columns.Add("TipoDocumento", "Tipo Documento");
            tablaClientes.Columns.Add("Documento", "Documento");
            tablaClientes.Columns.Add("Telefono", "Teléfono");
            tablaClientes.Columns.Add("Correo", "Correo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" ||
                txtTipoDocumento.Text == "" ||
                txtDocumento.Text == "" ||
                txtTelefono.Text == "" ||
                txtCorreo.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            tablaClientes.Rows.Add(
                txtNombre.Text,
                txtTipoDocumento.Text,
                txtDocumento.Text,
                txtTelefono.Text,
                txtCorreo.Text
            );

            MessageBox.Show("Cliente guardado correctamente");

            txtNombre.Clear();
            txtTipoDocumento.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtNombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTipoDocumento.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtNombre.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (tablaClientes.SelectedRows.Count > 0)
            {
                tablaClientes.Rows.RemoveAt(tablaClientes.SelectedRows[0].Index);
                MessageBox.Show("Cliente eliminado");
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (tablaClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = tablaClientes.SelectedRows[0];

                fila.Cells[0].Value = txtNombre.Text;
                fila.Cells[1].Value = txtTipoDocumento.Text;
                fila.Cells[2].Value = txtDocumento.Text;
                fila.Cells[3].Value = txtTelefono.Text;
                fila.Cells[4].Value = txtCorreo.Text;

                MessageBox.Show("Cliente actualizado");
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para actualizar");
            }
        }
        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tablaClientes.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells[0].Value.ToString();
                txtTipoDocumento.Text = fila.Cells[1].Value.ToString();
                txtDocumento.Text = fila.Cells[2].Value.ToString();
                txtTelefono.Text = fila.Cells[3].Value.ToString();
                txtCorreo.Text = fila.Cells[4].Value.ToString();
            }
        }
    }
}