using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBazurtoMusic.Clases
{
	public class Usuario
	{

        private string UsernId;
        private string UserNombre;
        private string UserApellido;
        private string UserEmail;

        // Constructor that takes no arguments.
        public Usuario()
        {
            UsernId = "unknown";
            UserNombre = "unknown";
            UserApellido = "unknown";
            UserEmail = "unknown";
        }

        // Constructor that takes arguments.
        public Usuario(string id, string name, string lastname, string email)
        {
            UsernId = id;
            UserNombre = name;
            UserApellido = lastname;
            UserEmail = email;
        }

        public bool add_user(string name)
        {
            UserNombre = name;
            return true;
        }

        public string get_user()
        {
            return UserNombre;
        }

	}
}