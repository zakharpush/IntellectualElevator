using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualElevator
{
    public class Elevator
    {
        int _maxWeight;
        int _currentFloor;
        int _speed;
        int _floors;
        List<Person> _persons;

        public int Floors { get => _floors; }

        public Elevator(int maxWeight)
        {
            _maxWeight = maxWeight;
            _floors = Building.floors;
            _persons = new List<Person>();
        }

        public void MoveUp()
        {

        }
        public void MoveDown()
        {

        }
        public void Stop()
        {

        }
    }
}
