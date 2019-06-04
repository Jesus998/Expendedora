using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class Producto : IProducto
    {
        //variables publicas
        private int id;
        private string nombre;
        private decimal precio;
        private string tipo;
        private string contenidoNeto;



        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string ContenidoNeto
        {
            get { return contenidoNeto; }
            set { contenidoNeto = value; }
        }


        
        //Constructyor vacio
        public Producto()
        {
            Id = DateTime.Now.Second;
        }
        

    }
}
