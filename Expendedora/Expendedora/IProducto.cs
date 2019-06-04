using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public interface IProducto
    {

        int Id { get; set; }
        string Nombre { get; set; }
        decimal Precio { get; set; }
        string Tipo { get; set; }
        string ContenidoNeto { get; set; }

    }
}
