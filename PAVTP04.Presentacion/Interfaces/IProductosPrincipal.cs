using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAVTP04.Dominio;

namespace PAVTP04.Presentacion.Interfaces
{
    public interface IProductosPrincipal
    {
        void ListarProductos(List<Producto> productos);
    }
}
