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

        public Building()
        {
            _floors = 3;
        }

        public Building(int floors)
        {
            _floors = floors;
        }
    }
}
