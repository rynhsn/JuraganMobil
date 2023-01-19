namespace JuraganMobil.OOP.Structure
{
    internal record VehicleRecord
    {
        public string? NoPoliceReg { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Rent { get; set; }
        public short Order { get; set; }
        public double OrderPerKM { get; set; }
    }
}
