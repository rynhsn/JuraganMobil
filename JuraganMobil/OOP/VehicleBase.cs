using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP
{
    internal class VehicleBase
    {
        public VehicleBase(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent)
        {
            NoPoliceReg = noPoliceReg;
            VehicleType = vehicleType;
            TransactionDate = transactionDate;
            Rent = rent;
        }

        public string? NoPoliceReg { get; set; }
        public VehicleType VehicleType { get; set; }
        public string? Year { get; set; }
        public double? Price { get; set; }
        public float? Tax { get; set; }
        public short? Seat { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Rent { get; set; }
        public decimal TotalIncomes { get; set; }

        //public abstract string DisplayInfo();

        public override string? ToString()
        {
            return $"NoPoliceReg: {NoPoliceReg}, Type: {VehicleType}, TransactionDate: {TransactionDate}, Rent: {Rent}";
        }
    }
}
