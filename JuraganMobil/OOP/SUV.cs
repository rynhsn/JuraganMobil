namespace JuraganMobil.OOP
{
    internal class SUV : VehicleBase
    {
        public SUV(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, double driverFee) : base(noPoliceReg, vehicleType, transactionDate, rent)
        {
            DriverFee = driverFee;
            TotalIncomes = (decimal) (Rent + DriverFee);
        }
        public double? DriverFee { get; set; }

        public override string? ToString()
        {
            return base.ToString() + $" Total Income: {TotalIncomes}";
        }
    }
}
