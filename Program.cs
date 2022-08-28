using System;

namespace EjercicioEmpleadoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables locales
            string nombreAr, apellidoAr, nip;

            Console.WriteLine("¡Bienvenidos al Sistema!");
            Console.WriteLine("Ingrese por favor los campos que se le solicitan a continuación\n");

            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("Apellido: ");
            apellidoAr = Console.ReadLine();
            Console.WriteLine("Digite su número NIP para asignarlo a su tarjeta");
            nip = Console.ReadLine();

            //Instanciamos la clase Empleado
            Empleado empleado1 = new Empleado(nombreAr, apellidoAr);
            empleado1.Nip = nip;

            //Mostrar la información del objeto
            Console.WriteLine(empleado1.ToString());
        }
    }

    class Empleado
    {
        //Campos
        private string nombre, apellido, id, locker, banco, nip;

        //Constructor
        public Empleado(string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            //Invocamos a los métodos para generar los campos aleatorios

            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignarBanco();
        }

        //Instanciando la clase Random
        Random random = new Random();

        //Propiedad (Descriptor de acceso)
        public string Nip
        {
            set { nip = value;}
            //set => nip = value;
        }

        //Métodos
        private string GenerarID()
        {
            //Variables
            int numero;
            string id = "";

            for (int i = 0; i < 10; i++)
            {
                numero = random.Next(10);
                id += numero.ToString();
            }
            return id;
        }

        private string GenerarLocker()
        {
            //Variables
            int numero;
            string locker = "";

            for (int i = 0; i < 2; i++)
            {
                numero = random.Next(10);
                locker += numero.ToString();
            }
            return locker;

        }

        private string AsignarBanco()
        {
            //Variables
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1,3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;
                case 2:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = "";
            mensaje = "Empleado: " + nombre + " " + apellido +
                "\nNumero Empleado: " + id + "\nNumero de Locker: " +
                locker + "\nBanco Asignado: " + banco;
            
            return mensaje;
        }
    }
}
