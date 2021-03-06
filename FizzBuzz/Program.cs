using System;

namespace FizzBuzzy
{
    class Fizzy
    {
        // methods must have a return type
        public static void Main(string[] args)
        {
            // a user should be able to enter the starting and ending count
            // a user should be able to enter these values in any order
            // a user should be able to get the number of times fizz, buzz and fizzbuzz appear
            // a user should be able to set new values for fizz, buzz and fizzbuzz

            var startPoint = 0;
            var endPoint = 0;

            Console.WriteLine("Please enter the first number");
            startPoint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            endPoint = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter a value for fizz");
            var fizz = Console.ReadLine();
            var fizzCount = 0;
            Console.WriteLine("please enter a value for buzz");
            var buzz = Console.ReadLine();
            var buzzCount = 0;
            Console.WriteLine("please enter a value for buzz");
            string fizzbuzz = "fizzbuzz";
            var fizzbuzzCount = 0;

            if (startPoint > endPoint)
            {
                var temp = endPoint;
                startPoint = temp;

            }

            for (int value = startPoint; value < endPoint; value++)
            {
                if (value % 3 == 0 && value % 5 == 0)
                {
                    fizzCount++;
                    Console.WriteLine(fizzbuzz);
                }
            }
        }

        private int GetInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private void GetEndpoint()
        {
            Console.WriteLine("enter a number:");
            var input1 = GetInput();
        }

        private void GetEntry()
        {
            return;
        }

        private void FizzBuzz(int a, int b)
        {

        }

    }
}
//
//
Crust.cs
namespace PizzaBox.Domain.Models
{
    public class Crust:Acomponent
    {
    public string Name { get; set;}
    public decimal price { get; set ;}
    }
} 
//
//
sizeof.cs


namespace PizzaBox.Domain.Models
{
    public class size:Acomponent 
    {
    public string Name { get; set;}
    public decimal price { get; set ;}
    }
//
//
Acomponet.cs


   namespace PizzaBox.Domain.Models
{
    public Abstract class AComponent
    {
    public string Name { get; set;}
    public decimal price { get; set ;}
    } 

//
//
APizzas
using System.Collections.Generic;
using System 

//
toppings
namespace PizzaBox.Domain.Models
{
    public class size : AComponent 
    {
        public 
    }
}
//
//
 MeatPizza.cs
 using
 namespace

 {
    public MeatPizza : APizza 
 
 {
     public MeatPizza()
     {
         Crust = new Crust();
         Size = new Size();
         Topping = new List <Topping >();

     }
     public MeatPizza(Crust crust, size size)
     {
         Crust = 

     }
 }
 }
 // another meatpizza
 using 
 using
 namespace PizzaBox.Domain.Models
 {
     /// <summary>
     /// summary 
     /// </summary>
     {
      public class MeatPizza : APizza
    {
 protected override void AddCrust()
 {
     Crust = new Crust(); 
 }
 protected override 
 //
 // vegie

 //
//
