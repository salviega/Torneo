using System.Collections.Generic;
using System.Linq;
using Sistema.App.Dominio;

namespace Sistema.App.Persistencia 
{

public class RepositorioMunicipio : IRepositorioMunicipio
    {

        /// <summary>
        /// Referencia al contexto Municipio
        /// </summary>

        private readonly AppContext _appContext;

        /// <summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//

        public RepositorioMunicipio(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Municipio IRepositorioMunicipio.AddMunicipio(Municipio Municipio)
        {
            var MunicipioAdicionado = _appContext.Municipios.Add(Municipio);
            _appContext.SaveChanges();
            return MunicipioAdicionado.Entity;
        }

        void IRepositorioMunicipio.DeleteMunicipio(int idMunicipio)
        {
            var MunicipioEncontrado = _appContext.Municipios.FirstOrDefault(p => p.Id == idMunicipio);
            if (MunicipioEncontrado == null)
            return;
            _appContext.Municipios.Remove(MunicipioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipios()
        {
            return _appContext.Municipios;
        }

        Municipio IRepositorioMunicipio.GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipios.FirstOrDefault(p => p.Id == idMunicipio);
        }

        Municipio IRepositorioMunicipio.UpdateMunicipio(Municipio Municipio)
        {
            var MunicipioEncontrado = _appContext.Municipios.FirstOrDefault(p => p.Id == Municipio.Id);
            if (MunicipioEncontrado != null)
            {
                MunicipioEncontrado.Nombre=Municipio.Nombre;
                MunicipioEncontrado.Id=Municipio.Id;
                //MunicipioEncontrado.Municipio=Municipio.Municipio;
                //MunicipioEncontrado.Genero=Municipio.Genero;
                //MunicipioEncontrado.Direccion=Municipio.Direccion;
                //MunicipioEncontrado.Latitud=Municipio.Latitud;
                //MunicipioEncontrado.Longitud=Municipio.Longitud;
                //MunicipioEncontrado.Ciudad=Municipio.Ciudad;
                //MunicipioEncontrado.FechaNacimiento=Municipio.FechaNacimiento;
                //MunicipioEncontrado.Familiar=Municipio.Familiar;
                //MunicipioEncontrado.Enfermera=Municipio.Enfermera;
                //MunicipioEncontrado.Medico=Municipio.Medico;
                //MunicipioEncontrado.Historia=Municipio.Historia;

                _appContext.SaveChanges();
    
            }
            return MunicipioEncontrado;
        }

    }

}