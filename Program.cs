using System;
using System.Collections.Generic;
using CivHeadphoneExample_20210608.models;

namespace CivHeadphoneExample_20210608
{
    class Program
    {
        static void Main(string[] args)
        {
            Cable copperCable = new Cable("Copper", "3.5mm", 1000);

            Wired mx50 = new Wired("MX50", 250, "Closed-Back", false, 15000, "2.5mm", copperCable);

            System.Console.WriteLine(mx50.Name);
            System.Console.WriteLine(mx50.Cable.Material);
            System.Console.WriteLine(copperCable.Material);

            // Create another Wired headphone
            Wired madeUpWired = new Wired("FakePhones", 10, "Open-Back", true, 20000, "3.5mm", copperCable);
            // Create a Wirelss headphone
            Wireless madeUpWireless = new Wireless("FakeBuds", 10, "In-Ear",true,100000,1000,"Bluetooth 3.0");
            // Create a NoiseCancelling headphone
            NoiseCancelling madeUpNoiseCancelling = new NoiseCancelling("BlockerPro 350",350,"Closed-Back", false, 50000, 300, "Bluetooth 3.0", new string[3]{ "None", "All Sound", "Drone"},"BlockerPro Proprietary");

            // print the plugtype of the second wired headphone
            System.Console.WriteLine(madeUpWired.PlugType);
            
            // print the WirelessProtocol of the wireless headphone
            System.Console.WriteLine(madeUpWireless.WirelessProtocol);

            // print he algorithm of the NoiseCancelling headphone
            System.Console.WriteLine(madeUpNoiseCancelling.Algorithm);
        }
    }
}
