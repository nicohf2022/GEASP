//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    ///  Se crea la clase Building para que se encargue de conocer los detalles de la construccion y se cumpla con el principio SRP.
    /// </summary>
    public class Building
    {
        private ArrayList tasks = new ArrayList();
        /// <summary>
        /// Se crea el constructor para que se encargue de inicializar la descripcion de la construccion.
        /// </summary>
        /// <param name="name"></param>
        public Building(string name)
        {
            this.Description = name;
        }

        /// <summary>
        /// Se crea la propiedad Description para que se encargue de conocer la descripcion de la construccion.
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        /// <summary>
        ///  Se crea el metodo addTask para que se encargue de agregar una tarea a la construccion.
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }

        /// <summary>
        ///  Se crea el metodo removeTask para que se encargue de eliminar una tarea de la construccion.
        /// </summary>
        /// <param name="task"></param>
        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }
        /// <summary>
        /// Se crea el metodo GetProductionCost para que se encargue de calcular el costo de produccion de la construccion.
        /// </summary>
        /// //se utiliza el patron expert para que la clase Building sea la encargada de calcular el costo de produccion ya que es la clase experta en conocer los detalles de la construccion
        public double GetProductionCost()
        {
            double total = 0;
            foreach (Task task in this.tasks)
            {
                total += (task.Material.UnitCost * task.Quantity) + (task.Equipment.HourlyCost * task.Time);
            }
            return total;
        }
        /// <summary>
        /// Se utiliza el patron expert para que la clase Building sea la encargada de imprimir la receta ya que es la clase experta en conocer los detalles de la construccion
        /// </summary>
        /// <returns></returns>
        public string PrintBuilding()
        {
             string printBuilding = "";
            printBuilding += $"Edificio {this.Description}: \n";
            foreach (Task task in this.tasks)
            {
            printBuilding += $"- {task.Quantity} de {task.Material.Description} + {task.Time} horas de {task.Equipment.Description} \n";
            }
            printBuilding += $"Monto total de construcción: {this.GetProductionCost()} \n";
            
            return printBuilding;
        }
    }
}
