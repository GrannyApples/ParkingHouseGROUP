namespace Parkinghouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Städer");
                List<Models.Cities> city = DatabasDapper.GetAllCities();
                foreach (Models.Cities cities in city)
                {
                    Console.WriteLine(cities.CityName);
                }
                Console.ReadLine();
            }
        }
    }
}
