using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Sistema.App.Dominio;
using Sistema.App.Persistencia;

namespace Sistema.App.Consola
{
    class Program
    {
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico(new Persistencia.AppContext());
        private static void AgregarDirectorTecnico()
        {
            var Dt = new DirectorTecnico
            {
                Nombre ="Santiago",
                Apellido ="Viana",
                Documento = 1234,
                Telefono = "3197499064"
            };
            _repoDirectorTecnico.AddDirectorTecnico(Dt);
        }
        private static void BuscarDirectorTecnico(int idDirectorTecnico)
        {
            var directorTecnico = _repoDirectorTecnico.GetDirectorTecnico(idDirectorTecnico);
            Console.WriteLine(directorTecnico.Nombre + " " + directorTecnico.Apellido);
        }

        private static void EliminarDirectorTecnico(int idDirectorTecnico)
        {
            _repoDirectorTecnico.DeleteDirectorTecnico(idDirectorTecnico);
        }

        private static void ActualizarDirectorTecnico()
        {
            Console.WriteLine("Por favor digite el documento que desea modificar");
            int documento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nuevo nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo número telefónico: ");
            string telefono = Console.ReadLine();
            var NuevoDt = new DirectorTecnico
            {
                Nombre = nombre, 
                Apellido = apellido, 
                Telefono = telefono
            };
        
            var directorTecnico = _repoDirectorTecnico.UpdateDirectorTecnico(documento,NuevoDt);
            Console.WriteLine("---");
            Console.WriteLine("Director tecnico actualizado:");
            Console.WriteLine(directorTecnico.Nombre + " " + directorTecnico.Apellido);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AgregarDirectorTecnico();
            //BuscarDirectorTecnico(2);
            //EliminarDirectorTecnico(1);
            ActualizarDirectorTecnico();

        }


    }
}
