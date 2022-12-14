//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Building
    {
        private ArrayList tasks = new ArrayList();

        public Building(string name)
        {
            this.Description = name;
        }

        public string Description { get; set; }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        //se utiliza el patron expert para que la clase Building sea la encargada de calcular el costo de produccion ya que es la clase experta en conocer los detalles de la construccion
        public double GetProductionCost()
        {
            double total = 0;
            foreach (Task task in this.tasks)
            {
                total += (task.Material.UnitCost * task.Quantity) + (task.Equipment.HourlyCost * task.Time);
            }
            return total;
        }
        
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
