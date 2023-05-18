using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_04_Bis.Models
{
   public static class Info
   {
        public static List<Pais> listaPaises {get; private set;} = new List<Pais>();
        public static int idBase {get; private set;}


        private static void iniciarLista(){
            listaPaises.Add(new Pais(id: idBase++,nom: "Francia", img: "bandera-francia.png", pob: 67.75, fi: new DateOnly(1789,07,14), at: "Torre Eifel, Notre Dame, Arco de Triunfo", him: "himno-francia.mp3"));
            listaPaises.Add(new Pais(id: idBase++,nom: "España", img: "bandera-españa.png", pob: 47.42, fi: new DateOnly(1814,04,17), at: "Plaza Mayor, Park Guell, Plaza de España", him: "himno-españa.mp3"));
            listaPaises.Add(new Pais(id: idBase++,"Italia", img: "bandera-italia.png", pob: 59.11, fi: new DateOnly(1849,08,22), at: "Coliseo de Roma, Torre de Pisa, Panteon de Roma", him: "himno-italia.mp3"));
            listaPaises.Add(new Pais(id: idBase++,nom: "Argentina", img: "bandera-argentina.png", pob: 45.81, fi: new DateOnly(1816,07,09), at: "Obelisco, Plaza de Mayo, Cataratas del Iguazu", him: "himno-argentina.mp3"));
            listaPaises.Add(new Pais(id: idBase++,nom: "Brasil", img: "bandera-brasil.png", pob: 214.3, fi: new DateOnly(1822,09,07), at: "Rio de janeiro, Cristo Redentor, Cataratas Iguazu", him: "himno-brasil.mp3"));
        }

        public static List<Pais> listarPaises(){
            if (listaPaises.Count == 0){
                iniciarLista();
            }
            return listaPaises; 
        }

        public static Pais detallePais(int idPais){
            Pais paisBuscado = null;
            foreach (var item in listaPaises)
            {
                if(item.Identificador == idPais){
                    paisBuscado = item;
                }
            }
            return paisBuscado;
        }
   }
}