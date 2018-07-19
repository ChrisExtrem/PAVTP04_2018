using PAVTP04.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAVTP04.Presentacion.Datos
{
    public class Almacen
    {
        private static List<Producto> _productos = new List<Producto>();

        public static List<Producto> Productos => _productos;

        public static void Iniciar()
        {
            
        }

        public static void AgregarOEditarProducto(Producto producto)
        {
            var existe = _productos.Any(p => p.Codigo == producto.Codigo);
            if (existe) return;
            _productos.Add(producto);
        }

        public static Producto BuscarProducto(long codigo)
        {
            return _productos.FirstOrDefault(p => p.Codigo == codigo);
        }

        public static void EliminarProducto(Producto producto)
        {
            if (producto == null) return;
            _productos.Remove(producto);
        }
    }
}
