using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionControladorGastosTPFINAL
{
    public class ListaMovimiento
    {
        public decimal Monto { get; set; }
        public string TipoCheck { get; set; }
        public string Categoria { get; set; }
        public DateTime Fecha { get; set; }
    }
}
