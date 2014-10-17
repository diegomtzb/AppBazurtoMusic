using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBazurtoMusic.Clases
{
	public class Catalogo
	{

        private string CatalogoId;
        private string CatalogoNombre;
        private float CatalogoPrecio;

        // Constructor that takes no arguments.
        public Catalogo()
        {
            CatalogoId = "unknown";
            CatalogoNombre = "unknown";
            CatalogoPrecio = 0;
        }

        // Constructor that takes arguments.
        public Catalogo(string id, string name, float price)
        {
            CatalogoId = id;
            CatalogoNombre = name;
            CatalogoPrecio = price;
        }

        public bool add_catalogo(string name)
        {
            CatalogoNombre = name;
            return true;
        }

        public string get_catalogo()
        {
            return CatalogoNombre;
        }


	}
}