using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ComSpecParser
{
    public class ComSpecParse
    {
        public event EventHandler<UshrtChangeEventArgs> UShortChange;
        public ushort maxPorts { get; set; }
        public ushort PortOffset { get; set; }

        /// <summary>
        /// SIMPL+ can only execute the default constructor. If you have variables that require initialization, please
        /// use an Initialize method
        /// </summary>
        public ComSpecParse()
        {

        }
        public void ProcessComSpec(string data)
        {
            try
            {
                var values = JsonConvert.DeserializeObject<portComSpec>(data);
                ushort index = (ushort)(values.Port - PortOffset);
                if (index > 0 && index <= maxPorts)
                {
                    OnUShortChange(values.Baud, index, ChangeTypeBaud);
                    OnUShortChange(values.Parity, index, ChangeTypeParity);
                    OnUShortChange(values.DataBits, index, ChangeTypeDataBits);
                    OnUShortChange(values.StopBit, index, ChangeTypeStopBit);
                    OnUShortChange(values.SoftHS, index, ChangeTypeSoftHS);
                    OnUShortChange(values.HardHS, index, ChangeTypeHardHS);
                    OnUShortChange(values.Protocol, index, ChangeTypeProtocol);
                    OnUShortChange(values.Pacing, index, ChangeTypePacing);
                }
            }
            catch (Exception ex)
            {
                CrestronConsole.PrintLine("ComSpecParse EXCEPTION: ProcessComSpec() Error: {0}", ex);
            }
        }
        //ushort change types
        public const ushort ChangeTypeBaud = 101;
        public const ushort ChangeTypeParity = 102;
        public const ushort ChangeTypeDataBits = 103;
        public const ushort ChangeTypeStopBit = 104;
        public const ushort ChangeTypeSoftHS = 105;
        public const ushort ChangeTypeHardHS = 106;
        public const ushort ChangeTypeProtocol = 107;
        public const ushort ChangeTypePacing = 108;

        protected void OnUShortChange(ushort state, ushort index, ushort type)
        {
            var handler = UShortChange;
            if (handler != null)
            {
                var args = new UshrtChangeEventArgs(state, type);
                args.Index = index;
                UShortChange(this, args);
            }
        }
    }
    public class portComSpec
    {
        [JsonProperty("Port")]
        public ushort Port { get; set; }

        [JsonProperty("Baud")]
        public ushort Baud { get; set; }

        [JsonProperty("Parity")]
        public ushort Parity { get; set; }

        [JsonProperty("DataBits")]
        public ushort DataBits { get; set; }

        [JsonProperty("StopBit")]
        public ushort StopBit { get; set; }

        [JsonProperty("SoftHS")]
        public ushort SoftHS { get; set; }

        [JsonProperty("HardHS")]
        public ushort HardHS { get; set; }

        [JsonProperty("Protocol")]
        public ushort Protocol { get; set; }

        [JsonProperty("Pacing")]
        public ushort Pacing { get; set; }

    }
}
