using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualElevator
{
    public class Person
    {
        private int _currentFloor;
        private int _destinationFloor;
        private string _name;
        private int _weight;
        Direction direction;

        public int CurrentFloor { get => _currentFloor; }
        public int DestinationFloor { get => _destinationFloor; }

        public Person(string name, int floor, int toFloor, int weight)
        {
            _name = name;
            _weight = weight;
            _currentFloor = floor;
            _destinationFloor = toFloor;
        }

        //private int GetRandomCurrentFloor()
        //{
        //    Random random = new Random();
        //    int randomCurretFloor = random.Next(Building.baseFloor, Building.floors);
        //    return randomCurretFloor;
        //}

        //private int GetRandomDestinationFloor()
        //{
        //    Random random = new Random();
        //    int randomDestinationFloor = random.Next(Building.baseFloor, Building.Floors);
        //    return randomDestinationFloor;
        //}
        
        
    }
}
