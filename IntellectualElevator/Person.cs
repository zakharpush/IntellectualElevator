using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualElevator
{
    public class Person
    {
        int _currentFloor;
        int _destinationFloor;
        int _weight;
        Direction direction;

        public int CurrentFloor { get => _currentFloor; }
        public int DestinationFloor { get => _destinationFloor; }

        public Person(int weight)
        {
            _weight = weight;
            _currentFloor = GetRandomCurrentFloor();
            _destinationFloor = GetRandomDestinationFloor();
        }

        private int GetRandomCurrentFloor()
        {
            Random random = new Random();
            int randomCurretFloor = random.Next(Building.baseFloor, Building.floors);
            return randomCurretFloor;
        }

        private int GetRandomDestinationFloor()
        {
            Random random = new Random();
            int randomDestinationFloor = random.Next(Building.baseFloor, Building.floors);
            return randomDestinationFloor;
        }

        public void CallElevator()
        {

        }
    }
}
