using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAVTP04.Dominio
{
    public class Producto
    {
        public Producto()
        {
            Estado = Estados.Activo;
        }

        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecionSinIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PrecionConIva => PrecionSinIva * (1 + PorcentajeIva);
        public Estados Estado { get; set; }
        public float Existencia { get; set; }
    }
}
