using JuraganMobil.OOP;
using JuraganMobil.OOP.Structure;

internal class Program
{
    private static void Main(string[] args)
    {
        //Call interface
        IVehicleFactory _iVehicle = new VehicleFactory();
        var suvHolder1 = new VehicleStruct
        {
            NoPoliceReg = "D 1001 UM",
            VehicleType = VehicleType.SUV,
            TransactionDate = DateTime.Now,
            DriverFee = 150_000,
            Rent = 500_000
        };
        var suvHolder2 = new VehicleStruct
        {
            NoPoliceReg = "D 1002 UM",
            VehicleType = VehicleType.SUV,
            TransactionDate = DateTime.Now,
            DriverFee = 150_000,
            Rent = 500_000
        };
        var suvHolder3 = new VehicleStruct
        {
            NoPoliceReg = "D 1003 UM",
            VehicleType = VehicleType.SUV,
            TransactionDate = DateTime.Now,
            DriverFee = 150_000,
            Rent = 500_000
        };
        var suvHolder4 = new VehicleStruct
        {
            NoPoliceReg = "D 1004 UM",
            VehicleType = VehicleType.SUV,
            TransactionDate = DateTime.Now,
            DriverFee = 150_000,
            Rent = 500_000
        };

        var taxiHolder1 = new VehicleRecord
        {
            NoPoliceReg = "D 11 UK",
            VehicleType = VehicleType.TAXI,
            TransactionDate = DateTime.Now,
            Rent = 500_000,
            Order = 75,
            OrderPerKM = 4_500
        };

        var taxiHolder2 = new VehicleRecord
        {
            NoPoliceReg = "D 12 UK",
            VehicleType = VehicleType.TAXI,
            TransactionDate = DateTime.Now,
            Rent = 500_000,
            Order = 45,
            OrderPerKM = 4_500
        };

        var taxiHolder3 = new VehicleRecord
        {
            NoPoliceReg = "D 13 UK",
            VehicleType = VehicleType.TAXI,
            TransactionDate = DateTime.Now,
            Rent = 500_000,
            Order = 90,
            OrderPerKM = 4_500
        };


        var suv1 = _iVehicle.CreateSUV(suvHolder1);
        var suv2 = _iVehicle.CreateSUV(suvHolder2);
        var suv3 = _iVehicle.CreateSUV(suvHolder3);
        var suv4 = _iVehicle.CreateSUV(suvHolder4);
        var taxi1 = _iVehicle.CreateTaxi(taxiHolder1);
        var taxi2 = _iVehicle.CreateTaxi(taxiHolder2);
        var taxi3 = _iVehicle.CreateTaxi(taxiHolder3);

        List<SUV> suvs = new() { suv1, suv2, suv3, suv4 };
        List<VehicleBase> vehicles = new() { suv1, suv2, suv3, suv4, taxi1, taxi2, taxi3 };

        _iVehicle.DisplayVehicle(vehicles);
        Console.WriteLine($"Total SUV : {_iVehicle.GetTotalVehicle(vehicles, VehicleType.SUV)}");
        Console.WriteLine($"Total TAXI: {_iVehicle.GetTotalVehicle(vehicles, VehicleType.TAXI)}");
        Console.WriteLine($"Total ALL : {_iVehicle.GetTotalVehicle(vehicles)}");
        Console.WriteLine($"Total Income SUV : {_iVehicle.GetTotalIncomeVehicle(vehicles, VehicleType.SUV)}");
        Console.WriteLine($"Total Income TAXI: {_iVehicle.GetTotalIncomeVehicle(vehicles, VehicleType.TAXI)}");
        Console.WriteLine($"Total Income ALL : {_iVehicle.GetTotalIncomeVehicle(vehicles)}");

        var minTotalIncome = vehicles.Min(x => x.TotalIncomes);
        var maxTotalIncome = vehicles.Max(x => x.TotalIncomes);

        Console.WriteLine($"Min Total Income : {minTotalIncome}, Max Total Income : {maxTotalIncome}");

        var query = vehicles.Where(x => x.TotalIncomes > minTotalIncome && x.TotalIncomes < maxTotalIncome)
                            .Select(vh =>
                             new { 
                                NoPolisi = vh.NoPoliceReg,
                                TahunBeli = vh.Year,
                                TotalIncome = vh.TotalIncomes
                             }
                    );

        foreach(var item in query)
        {
            Console.WriteLine(item);
        }

    }
}