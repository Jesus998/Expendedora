using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expendedora
{
    public partial class Maquina : MetroFramework.Forms.MetroForm
    {

        Venta venta = new Venta();
        List<Venta> ventas = new List<Venta>();


        public Maquina()
        {
            

            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            Producto sprite = new Producto();
            sprite.Precio = 13;
            sprite.Nombre = "Sprite";
            sprite.Tipo = "Soda";
            //sprite.Id = 13;
            sprite.ContenidoNeto = "600ml";
            venta.Cobrar(venta.Dinero, sprite);
            venta.Producto = sprite;
            venta.Fecha_Venta = DateTime.Now;
            ventas.Add(venta);
            venta.Id = ventas.Count();
            if (venta.Dinero >= sprite.Precio)
            {
                registro.RealizarRegistro( venta);
                venta.Dinero = 0;
                mLabel1.Text = Convert.ToString(venta.Dinero);
            }
        }

        private void mButton2_Click(object sender, EventArgs e)
        {
            venta.Dinero = venta.Dinero + 1;
            mLabel1.Text = Convert.ToString(venta.Dinero);
        }

        private void mButton3_Click(object sender, EventArgs e)
        {
            venta.Dinero = venta.Dinero + 2;
            mLabel1.Text = Convert.ToString(venta.Dinero);
        }

        private void mButton4_Click(object sender, EventArgs e)
        {
            venta.Dinero = venta.Dinero + 5;
            mLabel1.Text = Convert.ToString(venta.Dinero);
        }

        private void mButton5_Click(object sender, EventArgs e)
        {
            venta.Dinero = venta.Dinero + 10;
            mLabel1.Text = Convert.ToString(venta.Dinero);
        }

        private void mLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Maquina_Load(object sender, EventArgs e)
        {

        }

        private void mButton10_Click(object sender, EventArgs e)
        {
            if(venta.Dinero != 0)
            {
                MessageBox.Show("Se regresaron: "+Convert.ToString(venta.Dinero)+" pesos");
                venta.Dinero = 0;
                mLabel1.Text = Convert.ToString(venta.Dinero);
            }
            else
            {
                MessageBox.Show("No a insertado dinero");
            }
            
        }

        private void mButton6_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            Producto yogurt = new Producto();
            yogurt.Precio = 10;
            yogurt.Nombre = "Yogurt";
            yogurt.Tipo = "Lacteo";
            //yogurt.Id = 10;
            yogurt.ContenidoNeto = "345ml";
            venta.Cobrar(venta.Dinero, yogurt);
            venta.Producto = yogurt;
            venta.Fecha_Venta = DateTime.Now;
            ventas.Add(venta);
            venta.Id = ventas.Count();
            if (venta.Dinero >= yogurt.Precio)
            {
                registro.RealizarRegistro( venta);
                venta.Dinero = 0;
                mLabel1.Text = Convert.ToString(venta.Dinero);
            }
        }

        private void mButton7_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            Producto emperador = new Producto();
            emperador.Precio = 19;
            emperador.Nombre = "Emperador";
            emperador.Tipo = "Galletas";
            emperador.Id = 19;
            emperador.ContenidoNeto = "90gr";
            venta.Cobrar(venta.Dinero, emperador);
            venta.Producto = emperador;
            venta.Fecha_Venta = DateTime.Now;
            ventas.Add(venta);
            venta.Id = ventas.Count();
            if (venta.Dinero >= emperador.Precio)
            {
                registro.RealizarRegistro( venta);
                venta.Dinero = 0;
                mLabel1.Text = Convert.ToString(venta.Dinero);
                
            }
        }

        private void mButton8_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            Producto conchas = new Producto();
            conchas.Precio = 16;
            conchas.Nombre = "Conchas";
            conchas.Tipo = "Pan dulce";
            conchas.Id = 16;
            conchas.ContenidoNeto = "250gr";
            venta.Cobrar(venta.Dinero, conchas);
            venta.Producto = conchas;
            venta.Fecha_Venta = DateTime.Now;
            ventas.Add(venta);
            
            if (venta.Dinero >= conchas.Precio)
            {
                registro.RealizarRegistro(venta, ventas);
                venta.Dinero = 0;
                mLabel1.Text = Convert.ToString(venta.Dinero);
                
            }
        }

        private void mButton9_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            Producto cafe = new Producto();
            cafe.Precio = 25;
            cafe.Nombre = "Cafe frio";
            cafe.Tipo = "Bebida";
            cafe.Id = 25;
            cafe.ContenidoNeto = "600ml";
            venta.Cobrar(venta.Dinero, cafe);
            venta.Producto = cafe;
            venta.Fecha_Venta = DateTime.Now;
            ventas.Add(venta);
            
            if (venta.Dinero >= cafe.Precio)
            {
                registro.RealizarRegistro( venta, ventas);
                venta.Dinero = 0;
                mLabel1.Text = Convert.ToString(venta.Dinero);
            }
        }
    }
}
