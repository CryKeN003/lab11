using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kot = new Cat("Еда", "Комната", "Луна");
            Dog sobaka = new Dog("Кость", "Будка", "Жучка");
            Horse loshad = new Horse("Яблоко", "Конюшня", "Плотва");
            kot.sleep();
            sobaka.eat();
            loshad.makeNoise();
        }
    }
}
class Animal
{
    public string food;
    public string location;
    public Animal(string food, string location)
    {
        this.food = food;
        this.location = location;
    }
    public virtual void makeNoise()
    {
        Console.WriteLine("Животное издаёт звук");
    }
    public virtual void eat()
    {
        Console.WriteLine("Животное кушает");
    }
    public void sleep()
    {
        Console.WriteLine("Животное спит");
    }

}
class Cat : Animal
{
    public string name;
    public Cat(string food, string location, string name) : base(food, location) { this.name = name; }
    public override void eat()
    {
        Console.WriteLine("Кошка : Кушает корм");
    }
    public override void makeNoise()
    {
        Console.WriteLine("Кошка : Орёт посреди ночи");
    }
    public void sleep()
    {
        Console.WriteLine("Кошка : Спит на кроссовках");
    }
}
class Dog : Animal
{
    public string name;
    public Dog(string food, string location, string name) : base(food, location) { this.name = name; }
    public override void eat()
    {
        Console.WriteLine("Собака : Кушает кость");
    }
    public override void makeNoise()
    {
        Console.WriteLine("Собака : Лает");
    }
    public void sleep()
    {
        Console.WriteLine("Собака : Спит");
    }
}
class Horse : Animal
{
    public string name;
    public Horse(string food, string location, string name) : base(food, location) { this.name = name; }
    public override void eat()
    {
        Console.WriteLine("Лошадь : кушает яблочко");
    }
    public override void makeNoise()
    {
        Console.WriteLine("Лошадь : Ржёт");
    }
    public void sleep()
    {
        Console.WriteLine("Лошадь : Спит");
    }
}