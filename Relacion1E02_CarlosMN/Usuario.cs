using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion1E02_CarlosMN
{
    // Excepciones Personalizadas
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException() : base("El nombre no es válido. Debe tener entre 3 y 20 caracteres.") { }
    }

    public class ApellidoInvalidoException : Exception
    {
        public ApellidoInvalidoException() : base("El apellido no es válido. Debe tener entre 4 y 40 caracteres.") { }
    }

    public class EdadInvalidaException : Exception
    {
        public EdadInvalidaException() : base("La edad no es válida. Debe estar entre 5 y 70 años.") { }
    }
    public class Usuario
    {
        // Atributos
        private string _nombre;
        private string _apellidos;
        private int _edad;

        // Constructores
        public Usuario()
        {
            // Inicialización de propiedades con valores por defecto
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Edad = 0;
        }
        public Usuario(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        // Propiedades
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        // Metodos
        public bool TieneAcceso()
        {
            return Edad >= 18;
        }

        public bool ValidarDatos()
        {
            // Validaciones para todos los atributos
            if (string.IsNullOrEmpty(Nombre) || Nombre.Length < 3 || Nombre.Length > 20)
            {
                throw new NombreInvalidoException();
            }

            if (string.IsNullOrEmpty(Apellidos) || Apellidos.Length < 4 || Apellidos.Length > 40)
            {
                throw new ApellidoInvalidoException();
            }

            if (Edad < 5 || Edad > 70)
            {
                throw new EdadInvalidaException();
            }

            return true;
        }
    }
}
