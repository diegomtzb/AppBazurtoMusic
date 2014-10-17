using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBazurtoMusic.Clases
{
	public class Factura
	{

        private string ProductoId;
        private string FacturaId;
        private float PrecioProducto;
        private string NombreProducto;

        // Constructor that takes arguments.
        public Factura(string productoId, string facturaId, float price, string nameProduct)
        {
            ProductoId = productoId;
            FacturaId = facturaId;
            PrecioProducto = price;
            NombreProducto = nameProduct;
        }

        public bool add_factura(string facturaId)
        {
            FacturaId = facturaId;
            return true;
        }

        public string get_factura()
        {
            return FacturaId;
        }

	}
}