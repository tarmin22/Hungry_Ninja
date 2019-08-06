using System;
using System.Collections.Generic;
namespace Hungry_Ninja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweetcopy
        public Food(string name, int cal, bool IsSp, bool IsSw)
        {
            Name = name;
            Calories = cal;
            IsSpicy = IsSp;
            IsSweet = IsSw;
        }
    }
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Cheese Burger", 1000, false, false),
                new Food("Ceasar Salad", 650, false, false),
                new Food("Kentucky Fried Chicken", 1100, false, false),
                new Food("California Roll", 600, false, false),
                new Food("Curry Chicken", 650, true, false),
                new Food("Chicken Bake", 660, false, false),
                new Food("Pizza", 650, false, false)
            };

        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, 7)];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {
                bool full = false;
                if (calorieIntake > 1200)
                {
                    full = true;
                }
                return full;
            }
        }

        // build out the Eat method
        public void Eat(Food item)
        {

            if (IsFull)
                Console.WriteLine("Ninja is full and cannot eat anymore");
            else
            {
                this.FoodHistory.Add(item);
                this.calorieIntake += item.Calories;
                if (item.IsSpicy)
                    Console.WriteLine(item.Name + " is spicy");
                else if (item.IsSweet)
                    Console.WriteLine(item.Name + " is sweet");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet oriental = new Buffet();

            Ninja armin = new Ninja();
            armin.Eat(oriental.Serve());
            armin.Eat(oriental.Serve());
            armin.Eat(oriental.Serve());


            Console.WriteLine("Hello World!");
        }
    }
}
