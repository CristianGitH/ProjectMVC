using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Services
{
    public class TestClass
    {
        public double CalcularPotencia(int numero, int potencia)
        {
            return Math.Pow(numero, potencia);
        }

        public int ContarDivisores(int numero)
        {
            int cont = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cont = cont + 1;
                }
            }

            return cont;
        }

        public double ObtenerValorProducto(int codigo)
        {
            List<Producto> list = new List<Producto>();

            list.Add(new Producto
            {
                codigo = 1250,
                valor = 15500
            });

            list.Add(new Producto
            {
                codigo = 1251,
                valor = 18500
            });

            list.Add(new Producto
            {
                codigo = 1252,
                valor = 20000
            });

            list.Add(new Producto
            {
                codigo = 1253,
                valor = 10000
            });

            list.Add(new Producto
            {
                codigo = 1254,
                valor = 30000
            });

            var valor = (from q in list
                         where q.codigo == codigo
                         select q.valor).FirstOrDefault();

            return valor;
        }

        private class Producto
        {
            public int codigo { get; set; }
            public int valor { get; set; }
        }

        public double CalcularSubtotal(int codigo, int cantidad)
        {
            List<Producto> list = new List<Producto>();

            list.Add(new Producto
            {
                codigo = 1250,
                valor = 15500
            });

            list.Add(new Producto
            {
                codigo = 1251,
                valor = 18500
            });

            list.Add(new Producto
            {
                codigo = 1252,
                valor = 20000
            });

            list.Add(new Producto
            {
                codigo = 1253,
                valor = 10000
            });

            list.Add(new Producto
            {
                codigo = 1254,
                valor = 30000
            });

            var valor = (from q in list
                         where q.codigo == codigo
                         select q.valor).FirstOrDefault();

            return valor * cantidad;
        }

        public double CalcularDescuento(double Subtotal)
        {
            if (Subtotal >= 500000 && Subtotal <= 1000000)
                Subtotal = Subtotal - (Subtotal * 5 / 100);
            if (Subtotal > 1000000)
                Subtotal = Subtotal - (Subtotal * 10 / 100);

            return Subtotal;
        }

        public double CalcularIVA(double Subtotal)
        {
            double Valor = Subtotal * 19 / 100;

            return Valor;
        }

        public double CalcularTotal(double Subtotal, double Descuento, double Impuesto)
        {
            Subtotal = Subtotal - (Subtotal * Descuento / 100);

            Subtotal = Subtotal + (Subtotal * Impuesto / 100);

            return Subtotal;
        }

        public string ImprimirComentario(double Subtotal)
        {
            string Comentario = "";
            if (Subtotal >= 500000 && Subtotal <= 1000000)
                Comentario = "APLICA DESCUENTO DEL 5%";

            if (Subtotal > 1000000)
                Comentario = "APLICA DESCUENTO DEL 10%";

            if (Subtotal < 500000)
                Comentario = "NO APLICA DESCUENTO";

            return Comentario;
        }

        public bool ValidarCampos(string cliente, string nit, string direccion, string telefono, string formaDePago, string contacto)
        {
            if (!string.IsNullOrEmpty(cliente) && !string.IsNullOrEmpty(nit) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(telefono) &&
                !string.IsNullOrEmpty(formaDePago) && !string.IsNullOrEmpty(contacto))
                return true;

            return false;
        }
    }
}
