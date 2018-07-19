using PAVTP04.Dominio;
using PAVTP04.Presentacion.Interfaces;
using PAVTP04.Presentacion.Presentadores;
using System;
using System.Windows.Forms;

namespace PAVTP04.Presentacion
{
    public partial class ProductosGestion : Form, IProductosGestion
    {
        //Se define el presentador en la vista
        private readonly PresentadorProductosGestion _presentador; 

        public ProductosGestion(long? codigo = null)
        {
            InitializeComponent();
            //Se instancia el presentador y se pasa esta misma vista como parámetro
            _presentador = new PresentadorProductosGestion(this, codigo);
        }

        //Desde el presentador se asigna el objeto nuevo producto
        public void SetProducto(Producto producto)
        {
            ProductoBindingSource.DataSource = producto;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //Se invoca al presentador para que se encargue de guardar el producto
            _presentador.GuardarProducto();
            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Método para controlar el evento KeyDown de los cuadros de texto y permitir que se pueda mover el foco de un control a otro con la tecla Enter
        private void Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;
            e.Handled = true;
            SendKeys.Send("{TAB}");
        }
    }
}
