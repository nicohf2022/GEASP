using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
   // Se crea la clase ConsolePrinter para que se encargue de imprimir en consola esto es para cumplir con el principio SRP.
    public class ConsolePrinter
    {
        public static void PrintAmount(Building building)
        {
            Console.WriteLine(building.PrintBuilding());
        }
        
            
        
    }
}