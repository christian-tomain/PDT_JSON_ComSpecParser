using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace ComSpecParser
{
    //**************************************************************************************************//
    public class BoolChangeEventArgs : EventArgs
    {
        public bool State { get; set; }
        public ushort StateValue { get { return (ushort)(State ? 1 : 0); } }
        public ushort Type { get; set; }
        public ushort Index { get; set; }
        public BoolChangeEventArgs()
        {
        }
        public BoolChangeEventArgs(bool state, ushort type)
        {
            State = state;
            Type = type;
        }
        public BoolChangeEventArgs(bool state, ushort type, ushort index)
        {
            State = state;
            Type = type;
            Index = index;
        }
    }
    //**************************************************************************************************//
    public class UshrtChangeEventArgs : EventArgs
    {
        public ushort IntValue { get; set; }
        public ushort Type { get; set; }
        public ushort Index { get; set; }
        public UshrtChangeEventArgs()
        {
        }
        public UshrtChangeEventArgs(ushort intValue, ushort type)
        {
            IntValue = intValue;
            Type = type;
        }
        public UshrtChangeEventArgs(ushort intValue, ushort type, ushort index)
        {
            IntValue = intValue;
            Type = type;
            Index = index;
        }
    }
    //**************************************************************************************************//
    public class StringChangeEventArgs : EventArgs
    {
        public string StringValue { get; set; }
        public ushort Type { get; set; }
        public ushort Index { get; set; }
        public StringChangeEventArgs()
        {
        }
        public StringChangeEventArgs(string stringValue, ushort type)
        {
            StringValue = stringValue;
            Type = type;
        }
        public StringChangeEventArgs(string stringValue, ushort type, ushort index)
        {
            StringValue = stringValue;
            Type = type;
            Index = index;
        }
    }
}