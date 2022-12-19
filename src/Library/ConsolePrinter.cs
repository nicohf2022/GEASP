using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    // Se crea la clase ConsolePrinter para que se encargue de imprimir en consola esto es para cumplir con el principio SRP.
    /// <summary>
    /// Se crea la clase ConsolePrinter para que se encargue de imprimir en consola esto es para cumplir con el principio SRP.
    /// </summary>
    public class ConsolePrinter: IPrinter
    {
        /// <summary>
        /// Se crea el metodo PrintBuilding para que se encargue de imprimir en consola la receta de la construccion.
        /// </summary>
        /// <param name="building"></param>
        public void PrintBuilding(IConvertToString convertToString)
        {
            Console.WriteLine(convertToString.PrintBuilding());
        }
    }
     
}      
    