namespace CivHeadphoneExample_20210608.models
{
    public class NoiseCancelling : Wireless
    {
        /// array of strings describing each mode
        public string[] Modes { get; set; }
        /// description of algorithm
        public string Algorithm { get; set; }

        public NoiseCancelling(string name, uint weight, string type, bool microphone, uint price, uint batteryRuntime, string wirelessProtocol, string[] modes, string algorithm) : base(name, weight, type, microphone, price, batteryRuntime, wirelessProtocol)
        {
            Modes = modes;
            Algorithm = algorithm;
        }
    }
}