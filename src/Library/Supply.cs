//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    ///  Se crea la clase Supply para que se encargue de almacenar la descripcion y el costo unitario de un producto.
    /// </summary>
    public class Supply
    {
        /// <summary>
        /// Se crea el constructor para que se encargue de inicializar la descripcion y el costo unitario de un producto.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="unitCost"></param>
        public Supply(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        /// <summary>
        /// Se crea la propiedad Description para que se encargue de conocer la descripcion de un producto.
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        /// <summary>
        /// Se crea la propiedad UnitCost para que se encargue de conocer el costo unitario de un producto.
        /// </summary>
        public double UnitCost { get; set; }
    }
}