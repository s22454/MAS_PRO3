using System.Collections.Generic;

namespace PRO3
{
    public class SurgeryRoom : Room
    {
        private List<string> _equipment;

        public SurgeryRoom(ref SleepingRoom sleepingRoom, List<string> equipment)
        {
            _equipment = equipment;
            _number = sleepingRoom._number;
            sleepingRoom = null;
        }
    }
}