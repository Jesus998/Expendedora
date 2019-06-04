using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Expendedora
{
    public class Registro
    {

       // public int Id{ get; set; }
      //  public int IdVenta { get; set; }
        //public Venta venta { get; set; }

            //metodo que realiza el registro de las ventas en un archivo de texto
        public void RealizarRegistro(Venta venta)
        {

            try
            {
                
                StreamWriter registro = File.AppendText("Registro.Txt");//Crea un documento en el que se registraran los datos de una venta
                registro.WriteLine("Id: " + venta.Id + ", Producto: " + venta.Producto.Nombre + ", Precio: " + venta.Producto.Precio + ", Dinero: " + venta.Dinero +", Cambio: "+ venta.Cambio);//Escribe Los datos de la venta en el documeto creado
                registro.Close();//Cierra el documento para ahorrar recursos
                
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString());//messagebox en caso de haber error dice cual es
               
            }
        }

        public void RealizarRegistro(Venta venta, List<Venta> ventas)
        {
            try
            {
                StreamWriter registro = File.AppendText("Registro.Txt");
                registro.WriteLine("Id: "+ventas.Count+", Producto: "+venta.Producto.Nombre+", Precio: "+venta.Producto.Precio+", Dinero: "+ venta.Dinero+", Cambio: "+venta.Cambio);
                registro.Close();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString());
            }
        }

    }
}
