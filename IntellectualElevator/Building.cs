using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualElevator
{
    public class Building
    {
        private readonly int _floors;
        public const int baseFloor = 1;

        public int Floors { get => _floors; }

        public Building()
        {
            _floors = 3;
        }

        public Building(int floors)
        {
            _floors = floors;
        }

        // Event
        public event Action<int, Direction> CallElevator;

        public void OnElevatorCalled(int fromFloor, Direction direction)
        {
            Action<int, Direction> handle = CallElevator;
            handle.Invoke(fromFloor, direction);
        }
    }
}
