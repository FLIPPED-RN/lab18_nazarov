//средний уровень

try
{
    Console.Write("Введите количество кабинетов в поликлинике: ");
    int n = int.Parse(Console.ReadLine());
    Polyclinic[] polyclinic = new Polyclinic[n];
    for (int i = 0; i < n; i++)
    {
        polyclinic[i] = new Polyclinic();
        Console.Write("Введите название кабинета: ");
        polyclinic[i].CabinetName = Console.ReadLine();
        Console.Write("Введите номер кабинета: ");
        polyclinic[i].CabinetNumber = int.Parse(Console.ReadLine());
        Console.Write("Введите ФИО врача: ");
        polyclinic[i].DoctorName = Console.ReadLine();
        Console.Write("Введите день приема (2_Вторник): ");
        polyclinic[i].ReceptionDay = int.Parse(Console.ReadLine());
        Console.Write("Введите время начала приема (ЧЧ:ММ:СС): ");
        polyclinic[i].StartTime = TimeOnly.Parse(Console.ReadLine());
        Console.Write("Введите время окончания приема (ЧЧ:ММ:СС): ");
        polyclinic[i].EndTime = TimeOnly.Parse(Console.ReadLine());
    }

    Console.WriteLine("Информация о кабинетах поликлиники:");
    foreach (Polyclinic item in polyclinic)
    {
        Console.WriteLine($"Название кабинета: {item.CabinetName}");
        Console.WriteLine($"Номер кабинета: {item.CabinetNumber}");
        Console.WriteLine($"ФИО врача: {item.DoctorName}");
        Console.WriteLine($"День приема: {item.ReceptionDay}");
        Console.WriteLine($"Время начала приема: {item.StartTime}");
        Console.WriteLine($"Время окончания приема: {item.EndTime}");
        Console.WriteLine($"Длительность приема: {(item.EndTime - item.StartTime).TotalMinutes} минут");
        Console.WriteLine();
    }

    Console.WriteLine("Введите день недели (Например: 2_Вторник): ");
    int searchDay = int.Parse(Console.ReadLine());
    Console.Write("Введите время для поиска (ЧЧ:ММ:СС): ");
    TimeOnly searchTime = TimeOnly.Parse(Console.ReadLine());

    bool hasFluorography = false;

    foreach (Polyclinic item in polyclinic)
    {
        if (item.ReceptionDay == searchDay && searchTime >= item.StartTime && searchTime <= item.EndTime)
        {
            hasFluorography = true;
            break;
        }
    }

    if (hasFluorography)
    {
        Console.WriteLine("Кабинет флюорографии принимает в указанное время и день недели.");
    }
    else
    {
        Console.WriteLine("Кабинет флюорографии не принимает в указанное время и день недели.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct Polyclinic
{
    public string CabinetName;
    public int CabinetNumber;
    public string DoctorName;
    public int ReceptionDay; 
    public TimeOnly StartTime;
    public TimeOnly EndTime;
}