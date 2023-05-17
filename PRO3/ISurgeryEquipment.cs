using System;

namespace PRO3
{
    public interface ISurgeryEquipment
    {
        bool OrderForOperation(DateTime dateTime, int roomNumber);
    }
}