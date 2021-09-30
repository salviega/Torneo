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
        private static IRepositorioFutbolista _repoFutbolista = new RepositorioFutbolista(new Persistencia.AppContext());
        /// CRUD director tecnico ///

        private static void MostrarDirectoresTecnicos()
        {
            var TodosDts = _repoDirectorTecnico.GetAllDirectorTecnico();
            
            foreach (DirectorTecnico directorTecnico in TodosDts)
            {
                Console.WriteLine(directorTecnico.Nombre + " " + directorTecnico.Apellido);
            }
        }
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
        
        /// CRUD director tecnico ///

        /// CRUD director Futbolista ///

        private static void MostrarFutbolistas()
        {
            var TodosFutbolistas = _repoFutbolista.GetAllFutbolista();
            
            foreach (Futbolista futbolista in TodosFutbolistas)
            {
                Console.WriteLine(futbolista.Nombre + " " + futbolista.Apellido);
            }
        }
        private static void AgregarFutbolista()
        {
            var futbolista = new Futbolista
            {
                Nombre ="Santiago",
                Apellido ="Viana",
                Documento = 1234,
                Telefono = "3197499064",
                NumeroCamiseta = 1,
                PosicionCancha = "Defensa"
            };
            _repoFutbolista.AddFutbolista(futbolista);
        }
        private static void BuscarFutbolista(int idFutbolista)
        {

            var futbolista = _repoFutbolista.GetFutbolista(idFutbolista);
            Console.WriteLine(futbolista.Nombre + " " + futbolista.Apellido);
        }
        private static void EliminarFutbolista(int idFutbolista)
        {
            _repoFutbolista.DeleteFutbolista(idFutbolista);
        }
        private static void ActualizarFutbolista()
        {
            Console.WriteLine("Por favor digite el documento que desea modificar");
            int documento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nuevo nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo número telefónico: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo Numero de camiseta: ");
            int numerocamiseta = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nueva posicion en la cancha: ");
            string posicioncancha = Console.ReadLine();
            var NuevoFutbolista = new Futbolista
            {
                Nombre = nombre, 
                Apellido = apellido, 
                Telefono = telefono,
                NumeroCamiseta = numerocamiseta,
                PosicionCancha = posicioncancha

            };
        
            var futbolista = _repoFutbolista.UpdateFutbolista(documento,NuevoFutbolista);
            Console.WriteLine("---");
            Console.WriteLine("Futbolista actualizado:");
            Console.WriteLine(futbolista.Nombre + " " + futbolista.Apellido);
        }
        
        /// CRUD Futbolista ///
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AgregarDirectorTecnico();
            //BuscarDirectorTecnico(2);
            //EliminarDirectorTecnico(1);
            //ActualizarDirectorTecnico();
            //MostrarDirectoresTecnicos();

            //AgregarFutbolista();
            //BuscarFutbolista(8);
            //EliminarFutbolista(9);
            //ActualizarFutbolista();
            //MostrarFutbolistas();

        }
    }
}
