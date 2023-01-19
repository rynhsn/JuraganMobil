using JuraganMobil.OOP.Structure;

namespace JuraganMobil.OOP
{
    internal class VehicleFactory : IVehicleFactory
    {
        public Jet CreateJet(VehicleStruct vhStruct)
        {
            throw new NotImplementedException();
        }

        public SUV CreateSUV(VehicleStruct vhStruct)
        {
            return new SUV(vhStruct.NoPoliceReg, vhStruct.VehicleType, vhStruct.TransactionDate, vhStruct.Rent, vhStruct.DriverFee);
        }

        public Taxi CreateTaxi(VehicleRecord vhRecord)
        {
            return new Taxi(vhRecord.NoPoliceReg, vhRecord.VehicleType, vhRecord.TransactionDate, vhRecord.Rent, vhRecord.Order, vhRecord.OrderPerKM);
        }

        public void DisplayVehicle<T>(List<T> listVehicle)
        {
            foreach (var item in listVehicle)
            {
                Console.WriteLine($"{item}");
            }
        }

        public decimal GetTotalIncomeVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL)
        {
            if (vhType == VehicleType.ALL)
            {
                return listVehicle.Sum(n=> n.TotalIncomes);
            }
            else
            {
                return listVehicle.Where(n => n.VehicleType == vhType).Sum(n => n.TotalIncomes);
            }
        }

        public int GetTotalVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL)
        {
            if (vhType == VehicleType.ALL)
            {
                return listVehicle.Count;
            }
            else
            {
                return listVehicle.Count(n => n.VehicleType == vhType);
            }
        }
    }
}
