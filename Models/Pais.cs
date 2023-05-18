using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_04_Bis.Models
{
   public class Pais
   {
      public int Identificador {get; private set;}
      public string Nombre {get; private set;}
      public string imgBandera {get; private set;}
      public double Poblacion {get; private set;}
      public DateOnly FechaIndependencia {get; private set;}
      public string AtractivosTuristicos {get; private set;}

      public string Himno {get; private set;}

      public Pais(int id, string nom, string img, double pob, DateOnly fi, string at, string him){
         Identificador = id;
        Nombre = nom;
        imgBandera = img;
        Poblacion = pob;
        FechaIndependencia = fi;
        AtractivosTuristicos = at;
        Himno = him;
      }
   }
}
