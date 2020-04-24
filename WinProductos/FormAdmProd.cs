using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DataAccess;
using BussinesLogic;


namespace WinProductos
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        public int IDProducto;
        private void tsbtnGurdar_Click(object sender, EventArgs e)
        {
            Producto pProducto = ObtenerProducto();
            if (ProductoManager.Guardar(pProducto) == 0)
            {
                MessageBox.Show("Campo Nombre vacío.");
            }
            else
            {
                if (IDProducto == 0)
                {
                    MessageBox.Show("Nuevo registro guardado con éxito.");
                }
                else
                {
                    MessageBox.Show("Registro actualizado con éxito.");
                }
            ProductoManager.Guardar(pProducto);
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

        private Producto ObtenerProducto()
        {
            Producto pProducto = new Producto();

            pProducto.Id = IDProducto;
            pProducto.Nombre = textBoxNom.Text;
            pProducto.Descripcion = textBoxDesc.Text;
            pProducto.Precio = textBoxPrecio.Text;
            pProducto.Stock = textBoxStock.Text;

            return pProducto;
        }

        private void ActualizarGrilla()
        {
            if (textBoxNom.Text == "")
            {
                List<Producto> lista = ProductoManager.Buscar();
                dgvBuscar.DataSource = lista;
            }
            else
            {
                List<Producto> lista = ProductoManager.Buscar(textBoxNom.Text);
                dgvBuscar.DataSource = lista;
            }
        }

        private void Limpiar()
        {
            IDProducto = 0;
            textBoxNom.Text = "";
            textBoxDesc.Text = "";
            textBoxPrecio.Text = "";
            textBoxStock.Text = "";
            dgvBuscar.Columns.Clear();
        }

        private void ActualizarControles()
        {
            IDProducto = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
            textBoxNom.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[1].Value);
            textBoxDesc.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[2].Value);
            textBoxPrecio.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[3].Value);
            textBoxStock.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[4].Value);
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            ProductoManager.Eliminar(IDProducto);
            MessageBox.Show("Registro eliminado con éxito.");
            Limpiar();
        }

        private void tsbtnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
