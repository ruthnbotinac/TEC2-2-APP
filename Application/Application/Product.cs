using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Product
    {
        public string[] category = { "Lacteos", "Semillas", "Cultivos", "Trabajo" , "Frutas", "Vegetales", "Animales", "Otro" };
        public void productCategory(string prod)
        {

            for(int i=0;i<8;i++){
                if (category[i] == prod) { 
                
                }
            }
          //  get { return $"{} {}"; }
        }

        //Lacteos
        //Semillas
        //Cultivos
        //Trabajo
        //Frutas
        //Vegetales
        //Animales
        //Otros

    }
}
