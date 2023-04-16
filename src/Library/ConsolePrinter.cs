using System;
using System.Collections;


namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        Recipe receta = new Recipe();
        public ConsolePrinter(Recipe recipes){

            this.receta = recipes;
        }
        public void consolePrinter(){
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.steps){
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}

// Utilicé el principio SRP