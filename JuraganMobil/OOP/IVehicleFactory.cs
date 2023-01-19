using JuraganMobil.OOP.Structure;

namespace JuraganMobil.OOP
{
    internal interface IVehicleFactory
    {
        public SUV CreateSUV(VehicleStruct vhStruct);
        public Taxi CreateTaxi(VehicleRecord vhRecord);
        public Jet CreateJet(VehicleStruct vhStruct);
        public void DisplayVehicle<T>(List<T> listVehicle);
        public int GetTotalVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL);
        public decimal GetTotalIncomeVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL);
    }
}
