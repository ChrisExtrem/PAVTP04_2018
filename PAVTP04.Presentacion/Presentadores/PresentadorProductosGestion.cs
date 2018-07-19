using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PAVTP04.Dominio;
using PAVTP04.Presentacion.Datos;
using PAVTP04.Presentacion.Interfaces;

namespace PAVTP04.Presentacion.Presentadores
{
    public class PresentadorProductosGestion
    {
        //Se define la vista como una interfaz
        private readonly IProductosGestion _vista;
        //Se define un producto, que utilizará la vista para asignarle los datos
        private readonly Producto _productoActual;

        public PresentadorProductosGestion(IProductosGestion vista, long? codigo = null)
        {
            _vista = vista;
            _productoActual = codigo.HasValue ? Almacen.BuscarProducto(codigo.Value) : new Producto();
            _vista.SetProducto(_productoActual);
        }

        public void GuardarProducto()
        {
            Almacen.AgregarOEditarProducto(_productoActual);
        }
    }
}
