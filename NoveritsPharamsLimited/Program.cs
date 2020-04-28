using System;

namespace NoveritsPharamsLimited
{
    class Program
    {
        static void Main(string[] args)
        {
            Date maufactureDate = new Date(1, 2, 2020);
            Date expiryDate = new Date(5, 2, 2023);
           
            
            
            Sales sales = new Sales("Panadol", 50,20,20,"Lagos");
            Medicine medicine = new Medicine("4578FR","Amatem","Emzor Param",23.0,45,"67FGD",maufactureDate,expiryDate);

            Console.WriteLine(sales.Display(22));
            Console.WriteLine(medicine.Print());
        }
    }
}
