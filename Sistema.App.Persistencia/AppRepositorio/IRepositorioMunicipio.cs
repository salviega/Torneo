using System;
using System.Collections.Generic;
using Sistema.App.Dominio;
namespace Sistema.App.Persistencia 
{

public interface IRepositorioMunicipio
{
    IEnumerable<Municipio> GetAllMunicipios();
    Municipio AddMunicipio(Municipio Municipio);
    Municipio UpdateMunicipio(Municipio Municipio);
    void DeleteMunicipio(int idMunicipio);
    Municipio GetMunicipio(int idMunicipio);

}

}