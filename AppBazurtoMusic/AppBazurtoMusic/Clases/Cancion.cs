using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBazurtoMusic.Clases
{
	public class Cancion
	{

        private string CancionId;
        private string CancionNombre;
        private float CancionPrecio;
        private string CancionArtista;
        private string CancionGenero;

        // Constructor that takes no arguments.
        public Cancion()
        {
            CancionId = "unknown";
            CancionNombre = "unknown";
            CancionPrecio = 0;
            CancionArtista = "unknown";
            CancionGenero = "unknown";
        }

        // Constructor that takes arguments.
        public Cancion(string id, string name, float price, string artist, string genero)
        {
            CancionId = id;
            CancionNombre = name;
            CancionPrecio = price;
            CancionArtista = artist;
            CancionGenero = genero;
        }

        public bool add_song(string song)
        {
            CancionNombre = song;
            return true;
        }

        public string get_song()
        {
            return CancionNombre;
        }

	}
}