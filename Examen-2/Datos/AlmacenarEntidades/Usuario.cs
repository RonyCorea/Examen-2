using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.AlmacenarEntidades
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
         
        public Usuario()
        {

        }

        public Usuario(string codigo, string nombre, string email, string clave)
        {
            Codigo = codigo;
            Nombre = nombre;
            Email  =email;
            Clave  = clave;
        }
    }
}
