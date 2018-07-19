using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAVTP04.Dominio;
using PAVTP04.Presentacion.Datos;
using PAVTP04.Presentacion.Interfaces;

namespace PAVTP04.Presentacion.Presentadores
{
    public class PresentadorProductosPrincipal
    {
        private readonly IProductosPrincipal _vista;
        public PresentadorProductosPrincipal(IProductosPrincipal vista)
        {
            _vista = vista;
            _vista.ListarProductos(Almacen.Productos);
        }

        public void EliminarProducto(Producto producto)
        {
            Almacen.EliminarProducto(producto);
        }
    }
}
