class Town
{
    public string Name; public string Country; public string Region; public int Population; public double YearIncome; public double Square; public bool HasPort; public bool HasAirport;

    public double GetYearIncomePerInhabitant()
    {
        return YearIncome / Population;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть назву фільму: "); string sName = Console.ReadLine();

        Console.Write("Введiть ім'я режисеру: "); string sCountry = Console.ReadLine();

        Console.Write("Введiть ім'я головного актора: "); string sRegion = Console.ReadLine();

        Console.Write("Введiть ім'я улюбленного персонажу: "); string sPopulation = Console.ReadLine();

        Console.Write("Введіть дюрейшн фільму: "); string sYearIncome = Console.ReadLine();

        Console.Write("Введiть жанр фільму: "); string sSquare = Console.ReadLine();

        Console.Write("Чи хороший у фільму рейтинг? (y-так, n-нi): "); ConsoleKeyInfo keyHasPort = Console.ReadKey(); Console.WriteLine();

        Console.Write("Чи є сцена після титрів? (y-так, n-нi): "); ConsoleKeyInfo keyHasAirport = Console.ReadKey(); Console.WriteLine();

        Town OurTown = new Town();

        OurTown.Name = sName; OurTown.Country = sCountry; OurTown.Region = sRegion;
        OurTown.Population = int.Parse(sPopulation); OurTown.YearIncome = double.Parse(sYearIncome); OurTown.Square = double.Parse(sSquare);
        OurTown.HasPort = keyHasPort.Key == ConsoleKey.Y ? true : false;
        OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;

        double YearIncomePerInhabitant = OurTown.GetYearIncomePerInhabitant();
        Console.WriteLine();
        Console.WriteLine(" "); Console.WriteLine("Данi про об`ект: ");
        Console.WriteLine(" ");
        Console.WriteLine("Назва: " + OurTown.Name); Console.WriteLine("Країна: " + OurTown.Country); Console.WriteLine("Регiон: " + OurTown.Region); Console.WriteLine("Кiлькiсть населення: " +
        OurTown.Population.ToString()); Console.WriteLine("Рiчний дохiд: " +
        OurTown.YearIncome.ToString("0.00")); Console.WriteLine("Площа: " + OurTown.Square.ToString("0.000")); Console.WriteLine(OurTown.HasPort ? "У мiстi є порт" :
        "У мiстi нема порту"); Console.WriteLine(OurTown.HasAirport ? "У мiстi є аеропорт" :
        "У мiстi нема аеропорту"); Console.WriteLine();
        Console.WriteLine("Середнiй рiчний дохiд на одного громадянина: " + YearIncomePerInhabitant.ToString("0.00"));
        Console.ReadKey();
    }
}