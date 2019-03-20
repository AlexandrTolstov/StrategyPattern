using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
        }
        interface IMovable
        {
            void Move();
        }
        class PetrolMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на бензине");
            }
        }
        class ElectricMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на электричесве");
            }
        }
        class Car
        {
            protected int passengers;
            protected string model;
            public IMovable Movable { private get; set; }
            public Car(int num, string model, IMovable mov)
            {
                this.passengers = num;
                this.model = model;
                Movable = mov;
            }
            public void Move()
            {
                Movable.Move();
            }
        }
    }
}
