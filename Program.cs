

using UrbanPlanner;

Building FiveOneTwoEigth = new Building("512 8th Avenue");
FiveOneTwoEigth.Stories = 150;
FiveOneTwoEigth.Width = 3000;
FiveOneTwoEigth.Depth = 2000;
FiveOneTwoEigth.Purchase("Cristi");
FiveOneTwoEigth.Construct();

Building TwoTwoTwo = new Building("222 7th Street");
TwoTwoTwo.Stories = 150;
TwoTwoTwo.Width = 3000;
TwoTwoTwo.Depth = 2000;
TwoTwoTwo.Purchase("Cristi");
TwoTwoTwo.Construct();

List<Building> buildings = new List<Building>();
buildings.Add(FiveOneTwoEigth);
buildings.Add(TwoTwoTwo);

foreach(Building building in buildings)
    {
    Console.WriteLine($"{building.Address}");
    Console.WriteLine($"Designed By: {building.Designer}");
    Console.WriteLine($"Constructed on: {building.DateConstructed}");
} 