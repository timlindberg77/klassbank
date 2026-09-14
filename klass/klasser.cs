using System;

namespace Övning1.klass
{
    public class kunder
    {
        //detta är en klass som innehåller information om kunder
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
    public class vip : kunder // skapar vip kunder som ärver från kunder klassen
    {
        public string vipnummer; //ny attribut för klassen

        public new void run() //ny metod för vip kunder
        {
            Console.WriteLine("Hej vänligen fyll i VIP kundinformation");
        }

        public void treatment() //ny metod för vip kunder
        {
            Console.WriteLine("VIP kunder får bättre behandling");
        }
    }    
}
