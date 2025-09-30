using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var birdOne = new Bird();
            birdOne.Name = "Eagle";
            birdOne.Age = 2;
            birdOne.Diet = "Insects and small rodents";
            birdOne.IsNocturnal = false;
            birdOne.BeakType = "hooked";
            birdOne.CanFly = true;
            birdOne.FeatherColor = "Golden brown and white";
            birdOne.WingSpan = 12;
            
            Console.WriteLine($"Name: {birdOne.Name}\nAge: {birdOne.Age}\nDiet: {birdOne.Diet}\nIsNocturnal: {birdOne.IsNocturnal}\nBeakType: {birdOne.BeakType}\nCanFly: {birdOne.CanFly}\nFeather Color: {birdOne.FeatherColor}\nWingSpan: {birdOne.WingSpan} ft");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var reptileOne = new Reptile()
            {
                Name = "Snake Eyes", 
                Age = 1,
                Diet = "Small rodents",
                IsNocturnal = true,
                IsVenomous = false,
                ForkedTongue = true,
                ScaleColor = "Black and Red diamonds",
                HasShell = false
            };
            
            Console.WriteLine($"Name: {reptileOne.Name}\nAge: {reptileOne.Age}\nDiet: {reptileOne.Diet}\nNocturnal {reptileOne.IsNocturnal}\nVenomous: {reptileOne.IsVenomous}\nForked Tongue: {reptileOne.ForkedTongue}\nScale Color: {reptileOne.ScaleColor}\nHasShell: {reptileOne.HasShell}");
            
        }
    }
}
