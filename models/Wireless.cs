namespace CivHeadphoneExample_20210608.models
{
    public class Wireless : Headphone
    {
        /// expessed as minutes
        public uint BatteryRuntime { get; set; }
        /// example; "Bluetooth 3.0"
        public string WirelessProtocol { get; set; }

        public Wireless(string name, uint weight, string type, bool microphone, uint price, uint batteryRuntime, string wirelessProtocol) : base(name, weight, type, microphone, price)
        {
            BatteryRuntime = batteryRuntime;
            WirelessProtocol = wirelessProtocol;
        }
    }
}