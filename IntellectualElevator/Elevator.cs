using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualElevator
{
    public class Elevator
    {
        private const int _speed = 1; // 1 floor per second
        private int _currentFloor;
        private readonly int _maxWeight;
        private readonly int _floors;
        List<Person> _persons;

        public int CurrentFloor { get => _currentFloor; }

        public Elevator(int maxWeight, Building attachedBuilding)
        {
            _maxWeight = maxWeight;
            _floors = attachedBuilding.Floors;
            _persons = new List<Person>();
            
            attachedBuilding.CallElevator += ReactToCall;
        }

        private void ReactToCall(int fromFloor, Direction direction)
        {
            Console.WriteLine($"Request from floor:{fromFloor} to {direction}");
        }

        public void MoveUp()
        {
            _currentFloor++;
            Console.WriteLine($"__{_currentFloor}__");

        }

        public void MoveDown()
        {
            _currentFloor--;
            Console.WriteLine($"__{_currentFloor}__");        
        }

        // Anybody could call elevator from any floor and wait for it
        public void CallFrom(int currentFloor, Direction direction)
        {
            // add person to queue of course check weight, direction, order...
        }

        // Person will set floor with this method
        public void SetFloor(int floor)
        {

        }

        public void Stop()
        {

        }
    }
}
