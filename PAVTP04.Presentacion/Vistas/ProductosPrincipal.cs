using PAVTP04.Presentacion.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAVTP04.Dominio;
using PAVTP04.Presentacion.Interfaces;
using PAVTP04.Presentacion.Presentadores;

namespace PAVTP04.Presentacion
{
    public partial class ProductosPrincipal : Form, IProductosPrincipal
    {
        private readonly PresentadorProductosPrincipal _presentador;
        public ProductosPrincipal()
        {
            InitializeComponent();
            _presentador = new PresentadorProductosPrincipal(this);
        }

        public void ListarProductos(List<Producto> productos)
        {
            ProductosBindingSource.DataSource = productos;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var alta = new ProductosGestion();
            alta.ShowDialog();
            ProductosBindingSource.ResetBindings(false);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            var actual = GetProducto();
            if (actual == null) return;
            var editar = new ProductosGestion(actual.Codigo);
            editar.ShowDialog();
            ProductosBindingSource.ResetBindings(false);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var actual = GetProducto();
            if (actual == null) return;
            if(MessageBox.Show($"¿Seguro desea eliminar el producto: {actual.Descripcion}","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            _presentador.EliminarProducto(actual);
            ProductosBindingSource.ResetBindings(false);
        }

        private Producto GetProducto()
        {
            var actual = ProductosBindingSource.Current as Producto;
            if (actual != null) return actual;
            MessageBox.Show("Debe seleccionar un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}
