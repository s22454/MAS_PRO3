namespace PRO3
{
    public class SleepingRoom : Room
    {
        private int _numberOfBeds;

        public SleepingRoom(ref SurgeryRoom surgeryRoom, int numberOfBeds)
        {
            _number = surgeryRoom._number;
            _numberOfBeds = numberOfBeds;
            surgeryRoom = null;
        }
    }
}