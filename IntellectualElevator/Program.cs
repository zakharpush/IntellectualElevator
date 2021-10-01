using System;

namespace IntellectualElevator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create simulation objects
            var building = new Building();
            var elevator = new Elevator(100, building);

            // Create people
            var person1 = new Person("Jack", floor: 1, 50);
            var person2 = new Person("Mary", floor: 3, 45);
            var person3 = new Person("Richard", floor: 2, 100);

            // Act
            elevator.CallFrom(person1.CurrentFloor, Direction.Up);
            elevator.CallFrom(person2.CurrentFloor, Direction.Down);
            elevator.CallFrom(person3.CurrentFloor, Direction.Down);

            elevator.Process();
            //.... try to visualize process in console
            // try to add one simulation scenarion
            
            Console.ReadKey();
        }
    }
}
