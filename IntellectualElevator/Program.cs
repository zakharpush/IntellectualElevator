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
            var person1 = new Person("Jack", floor: 1, toFloor: 5, 50);
            var person2 = new Person("Mary", floor: 3, toFloor: 5, 45);
            var person3 = new Person("Richard", floor: 2, toFloor: 1, 100);

            // Act            
            building.OnElevatorCalled(person1.CurrentFloor, Direction.Up);
            building.OnElevatorCalled(person2.CurrentFloor, Direction.Down);
            building.OnElevatorCalled(person3.CurrentFloor, Direction.Down);

            //elevator.Process();
            //.... try to visualize process in console
            // try to add one simulation scenarion
            
            Console.ReadKey();
        }
    }
}
