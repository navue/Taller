using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLogic;
using DataAccess;
using Domain;



namespace WinClientes
{
    public partial class FormAdmCli : Form
    {
        public FormAdmCli()
        {
            InitializeComponent();
        }

        public int IDCliente;
        private void tsbtnGurdar_Click(object sender, EventArgs e)
        {
            Cliente pCliente = ObtenerCliente();
            if (ClientesManager.Guardar(pCliente) == 0)
            {
                MessageBox.Show("Fecha de nacimiento erronea.");
            }
            else
            {
                if (IDCliente == 0)
                {
                    MessageBox.Show("Nuevo registro guardado con éxito.");
                }
                else
                {
                    MessageBox.Show("Registro actualizado con éxito.");
                }
                ClientesManager.Guardar(pCliente);
                ActualizarGrilla();
                Limpiar();
            }
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           ActualizarControles();
        }

        private void ActualizarControles()
        {
            IDCliente = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
            textBoxNom.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[1].Value);
            textBoxAp.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[2].Value);
            dtpFecha.Value = Convert.ToDateTime(dgvBuscar.CurrentRow.Cells[3].Value);
            textBoxDir.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[4].Value);
        }

        private void ActualizarGrilla()
        {
            if (textBoxNom.Text != "" || textBoxAp.Text != "")
            {
                List<Cliente> lista = ClientesManager.Buscar(textBoxNom.Text, textBoxAp.Text);
                dgvBuscar.DataSource = lista;
            }
            else
            {
                List<Cliente> lista = ClientesManager.Buscar();
                dgvBuscar.DataSource = lista;
            }
        }

        private void Limpiar()
        {
            IDCliente = 0;
            textBoxNom.Text = "";
            textBoxAp.Text = "";
            dtpFecha.Value = DateTime.Now;
            textBoxDir.Text = "";
            dgvBuscar.Columns.Clear();
        }

        private Cliente ObtenerCliente()
        {
            Cliente pCliente = new Cliente();

            pCliente.Id = IDCliente;
            pCliente.Nombre = textBoxNom.Text;
            pCliente.Apellido = textBoxAp.Text;
            pCliente.Fecha_Nac = dtpFecha.Value.Year.ToString() + '/' + dtpFecha.Value.Month.ToString() + '/' + dtpFecha.Value.Day.ToString(); ;
            pCliente.Direccion = textBoxDir.Text;

            return pCliente;
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            ClientesManager.Eliminar(IDCliente);
            MessageBox.Show("Registro eliminado con éxito.");
            Limpiar();
        }

        private void tsbtnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
