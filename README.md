# Overlapping
Klasy "Cardiologist" i "Oncologist" zostały spłaszczone do klasy "Doctor" oraz enum'a "Specialization".
W klasie doctor znajdują się metody dostępne tylko dla lekarzy o określolych specjalizacjach.
Jeden lekarz może mieć wiele specjalizacji.

# Wielodziedziczenie
Klasa "HospitalBed" implementuje dwa interfejsy "IBed" i "ISurgeryEquipment" ponieważ można ją traktować 
zarówno jako sprzęt potrzebny do operacji jak i łóżko szpitalne.

# Wieloaspektowe 
Klasy "MedicalStuff" i "Stuff" zostały spłaszczone do klasy "Employee". Klasa ta nie jest 
abstrakcyjna i jeśli zostanie utworzona z konstruktora traktowana będzie jak klasa "Stuff".
Pracownik taki nie będzie mogł brać udziału w operacjach. Jeśli jednak utworzony zostanie obiekt
klasy "Doctor" to taki obiekt traktowany będzie jakby dziedziczył po "MedicalStuff" oraz będzie
mógł brać udział w operacjach.

# Dynamiczne
Klasy "SurgeryRoom" i "SleepingRoom" dziedziczą po abstrakcyjnej klasie "Room". Obie w parametrach 
konstruktora przyjmują przez referencję obiekt drugiej klasy, uzupełniają pola wspólne i nullują
obiekt przekazany przez referencję.  