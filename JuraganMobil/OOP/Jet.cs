namespace JuraganMobil.OOP
{
    internal sealed class Jet : VehicleBase
    {
        public Jet(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, double orderPerHours) : base(noPoliceReg, vehicleType, transactionDate, rent)
        {
            OrderPerHours = orderPerHours;
        }
        public double OrderPerHours { get; set; }
    }
}
