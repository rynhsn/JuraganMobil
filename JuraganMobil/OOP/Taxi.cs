namespace JuraganMobil.OOP
{
    internal sealed class Taxi : VehicleBase //sealed memungkinkan class Taxi tidak bisa diwariskan
    {
        public Taxi(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, short order, double orderPerKM) : base(noPoliceReg, vehicleType, transactionDate, rent)
        {
            Order = order;
            OrderPerKM = orderPerKM;
            TotalIncomes = (decimal)(Rent + (Order * OrderPerKM));
        }
        public short Order { get; set; }
        public double OrderPerKM { get; set; }
        public override string? ToString()
        {
            return base.ToString() + $" Total Income: {TotalIncomes}";
        }
    }
}
