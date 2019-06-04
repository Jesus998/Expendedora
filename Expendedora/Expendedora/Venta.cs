using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class Venta
    {

        private int id;
        private decimal dinero;
        private decimal cambio;
        private DateTime fecha_Venta;
        private Producto producto;
        private int idProducto;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public decimal Cambio
        {
            get { return cambio; }
            set { cambio = value; }
        }

        public DateTime Fecha_Venta
        {
            get { return fecha_Venta; }
            set { fecha_Venta = value; }
        }

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public void Cobrar(decimal dinero, Producto producto)
        {
            
            try
            {
                if (dinero >= producto.Precio)
                {
                    Cambio = dinero - producto.Precio;
                    DarCambio(Cambio);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Saldo insuficiente");
                }
            }
            catch(Exception ed)
            {
                System.Windows.Forms.MessageBox.Show(ed.Message.ToString());
            }



        }

        public void DarCambio(decimal cambio)
        {
            System.Windows.Forms.MessageBox.Show("Su cambio fue: " + cambio);
        }


    }
}
