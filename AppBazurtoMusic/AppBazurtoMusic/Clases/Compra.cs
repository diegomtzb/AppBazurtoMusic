using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBazurtoMusic.Clases
{
	public class Compra
	{

        private string CompraId;
        private string ProductoId;

        // Constructor that takes arguments.
        public Compra(string compraId, string productoId)
        {
            CompraId = compraId;
            ProductoId = productoId;
        }

        public bool add_compra(string compraId)
        {
            CompraId = compraId;
            return true;
        }

        public string get_compra()
        {
            return CompraId;
        }

	}
}