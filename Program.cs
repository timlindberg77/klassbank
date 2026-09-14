using System;

namespace Övning1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //detta är första kunden för banken
            kunder k1 = new kunder();

            k1.namn = "Janne";
            k1.adress = "Storgatan 1";
            k1.telefonnummer = "0701234567";
            k1.personnummer = "123456-7890";
            k1.kundnummer = "K12345";

            k1.run(); //anropar metoden run för kunder klassen  
            //första vip kunden för banken
            vip v1 = new vip();
            v1.namn = "Eva";
            v1.adress = "Lillegatan 2";
            v1.telefonnummer = "0707654321";
            v1.personnummer = "098765-4321";
            v1.kundnummer = "K54321";
            v1.vipnummer = "V12345";

            v1.run();
        }
    }
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
