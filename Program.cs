using System;

namespace Övning1
{
    public class Program
    {
        static void Main(string[] args)
        {
            kunder k1 = new kunder();

            k1.namn = "Janne";
            k1.adress = "Storgatan 1";
            k1.telefonnummer = "0701234567";
            k1.personnummer = "123456-7890";
            k1.kundnummer = "K12345";


        }
    }
    public class kunder
    {
       public string namn;
        public string adress;
        public string telefonnummer;
        public string email;
        public string personnummer;
        public string kundnummer;
        
        public void run()
        {
            Console.WriteLine("Hej vänligen fyll i kundinformation");
        }
    }
}
