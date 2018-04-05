using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_COMSPEC
{
    public class UserModuleClass_COMSPEC : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.AnalogInput PORT;
        Crestron.Logos.SplusObjects.AnalogInput BAUD_RATE;
        Crestron.Logos.SplusObjects.AnalogInput PARITY;
        Crestron.Logos.SplusObjects.AnalogInput DATA_BITS;
        Crestron.Logos.SplusObjects.AnalogInput STOP_BITS;
        Crestron.Logos.SplusObjects.AnalogInput SOFTHANDSHAKE;
        Crestron.Logos.SplusObjects.AnalogInput HARDHANDSHAKE;
        Crestron.Logos.SplusObjects.AnalogInput PROTOCOL;
        Crestron.Logos.SplusObjects.AnalogInput PACING;
        Crestron.Logos.SplusObjects.DigitalInput REPORTCTS;
        Crestron.Logos.SplusObjects.DigitalInput SENDCOMSPEC;
        Crestron.Logos.SplusObjects.StringOutput OUT__DOLLAR__;
        
        
        
        
        
        
        
        
        
        
        
        
        private void MAKESPEC (  SplusExecutionContext __context__, ref CrestronString SPEC__DOLLAR__ ,  ushort CSPEC ) 
            { 
            ushort DEFPORT = 0;
            
            ushort DEFPACE = 0;
            
            
            __context__.SourceCodeLine = 128;
            DEFPORT = (ushort) ( PORT  .UshortValue ) ; 
            __context__.SourceCodeLine = 129;
            DEFPACE = (ushort) ( PACING  .UshortValue ) ; 
            __context__.SourceCodeLine = 131;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DEFPORT < 65 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( DEFPORT > 70 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 133;
                DEFPORT = (ushort) ( 65 ) ; 
                __context__.SourceCodeLine = 134;
                Print( "Invalid Port {0} specified - assuming Port A.\r\n", Functions.Chr ( PORT  .UshortValue ) ) ; 
                } 
            
            __context__.SourceCodeLine = 137;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DEFPACE > 31 ))  ) ) 
                { 
                __context__.SourceCodeLine = 139;
                DEFPACE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 140;
                Print( "Invalid Pacing {0:d} specified - assuming No Pacing.\r\n", (short)PACING  .UshortValue) ; 
                } 
            
            __context__.SourceCodeLine = 143;
            MakeString ( SPEC__DOLLAR__ , "{0}{1}{2}{3}{4}{5}{6}", Functions.Chr ( 18 ) , Functions.Chr ( (128 | (DEFPORT - 65)) ) , Functions.Chr ( 0 ) , Functions.Chr ( Functions.Low( (ushort) CSPEC ) ) , Functions.Chr ( Functions.High( (ushort) CSPEC ) ) , Functions.Chr ( DEFPACE ) , Functions.Chr ( 0 ) ) ; 
            
            }
            
        object SENDCOMSPEC_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort CSPEC = 0;
                
                CrestronString SPEC__DOLLAR__;
                SPEC__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 7, this );
                
                
                __context__.SourceCodeLine = 151;
                CSPEC = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 153;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)BAUD_RATE  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 1 ) )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 157;
                            MAKESPEC (  __context__ ,   ref  SPEC__DOLLAR__ , (ushort)( 65534 )) ; 
                            __context__.SourceCodeLine = 158;
                            OUT__DOLLAR__  .UpdateValue ( SPEC__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 159;
                            return  this ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 2 ) )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 164;
                            MAKESPEC (  __context__ ,   ref  SPEC__DOLLAR__ , (ushort)( 65533 )) ; 
                            __context__.SourceCodeLine = 165;
                            OUT__DOLLAR__  .UpdateValue ( SPEC__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 166;
                            return  this ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 3 ) )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 171;
                            MAKESPEC (  __context__ ,   ref  SPEC__DOLLAR__ , (ushort)( 65532 )) ; 
                            __context__.SourceCodeLine = 172;
                            OUT__DOLLAR__  .UpdateValue ( SPEC__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 173;
                            return  this ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 4 ) )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 178;
                            MAKESPEC (  __context__ ,   ref  SPEC__DOLLAR__ , (ushort)( 65531 )) ; 
                            __context__.SourceCodeLine = 179;
                            OUT__DOLLAR__  .UpdateValue ( SPEC__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 180;
                            return  this ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 300) ) ) ) 
                            {
                            __context__.SourceCodeLine = 184;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 600) ) ) ) 
                            {
                            __context__.SourceCodeLine = 187;
                            CSPEC = (ushort) ( (CSPEC | 1) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1200) ) ) ) 
                            {
                            __context__.SourceCodeLine = 190;
                            CSPEC = (ushort) ( (CSPEC | 2) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1800) ) ) ) 
                            {
                            __context__.SourceCodeLine = 193;
                            CSPEC = (ushort) ( (CSPEC | 128) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2400) ) ) ) 
                            {
                            __context__.SourceCodeLine = 196;
                            CSPEC = (ushort) ( (CSPEC | 3) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3600) ) ) ) 
                            {
                            __context__.SourceCodeLine = 199;
                            CSPEC = (ushort) ( (CSPEC | 129) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4800) ) ) ) 
                            {
                            __context__.SourceCodeLine = 202;
                            CSPEC = (ushort) ( (CSPEC | 4) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7200) ) ) ) 
                            {
                            __context__.SourceCodeLine = 205;
                            CSPEC = (ushort) ( (CSPEC | 130) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9600) ) ) ) 
                            {
                            __context__.SourceCodeLine = 208;
                            CSPEC = (ushort) ( (CSPEC | 5) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 14400) ) ) ) 
                            {
                            __context__.SourceCodeLine = 211;
                            CSPEC = (ushort) ( (CSPEC | 131) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 19200) ) ) ) 
                            {
                            __context__.SourceCodeLine = 214;
                            CSPEC = (ushort) ( (CSPEC | 6) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 28800) ) ) ) 
                            {
                            __context__.SourceCodeLine = 217;
                            CSPEC = (ushort) ( (CSPEC | 132) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 38400) ) ) ) 
                            {
                            __context__.SourceCodeLine = 220;
                            CSPEC = (ushort) ( (CSPEC | 7) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 57600) ) ) ) 
                            {
                            __context__.SourceCodeLine = 223;
                            CSPEC = (ushort) ( (CSPEC | 133) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 115) ) ) ) 
                            {
                            __context__.SourceCodeLine = 226;
                            CSPEC = (ushort) ( (CSPEC | 134) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 230;
                            CSPEC = (ushort) ( (CSPEC | 5) ) ; 
                            __context__.SourceCodeLine = 231;
                            Print( "Invalid baud rate {0:d} received - assuming 9600 baud.\r\n", (short)BAUD_RATE  .UshortValue) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 236;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_2__ = ((int)PROTOCOL  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                            {
                            __context__.SourceCodeLine = 240;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 243;
                            CSPEC = (ushort) ( (CSPEC | 256) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 246;
                            CSPEC = (ushort) ( (CSPEC | 8448) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 250;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            __context__.SourceCodeLine = 251;
                            Print( "Invalid Protocol {0:d} received - assuming RS-232\r\n", (short)PROTOCOL  .UshortValue) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 256;
                switch ((int)PARITY  .UshortValue)
                
                    { 
                    case 101 : 
                    case 69 : 
                    
                        { 
                        __context__.SourceCodeLine = 261;
                        CSPEC = (ushort) ( (CSPEC | 8) ) ; 
                        } 
                    
                    goto case 122 ;
                    case 122 : 
                    goto case 90 ;
                    case 90 : 
                    
                        { 
                        __context__.SourceCodeLine = 268;
                        CSPEC = (ushort) ( (CSPEC | 16) ) ; 
                        } 
                    
                    goto case 111 ;
                    case 111 : 
                    goto case 79 ;
                    case 79 : 
                    
                        { 
                        __context__.SourceCodeLine = 275;
                        CSPEC = (ushort) ( (CSPEC | 24) ) ; 
                        } 
                    
                    goto case 110 ;
                    case 110 : 
                    goto case 78 ;
                    case 78 : 
                    
                        { 
                        __context__.SourceCodeLine = 281;
                        CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                        } 
                    
                    goto default;
                    default : 
                    
                        { 
                        __context__.SourceCodeLine = 286;
                        CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                        __context__.SourceCodeLine = 287;
                        Print( "Invalid Parity {0:d} ({1}) received - assuming NONE\r\n", (short)PARITY  .UshortValue, Functions.Chr ( PARITY  .UshortValue ) ) ; 
                        } 
                    break;
                    
                    } 
                    
                
                __context__.SourceCodeLine = 291;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_3__ = ((int)DATA_BITS  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 7) ) ) ) 
                            {
                            __context__.SourceCodeLine = 294;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 8) ) ) ) 
                            {
                            __context__.SourceCodeLine = 297;
                            CSPEC = (ushort) ( (CSPEC | 32) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 301;
                            CSPEC = (ushort) ( (CSPEC | 32) ) ; 
                            __context__.SourceCodeLine = 302;
                            Print( "Invalid Data Bits {0:d} received - assuming 8 Data Bits\r\n", (short)DATA_BITS  .UshortValue) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 306;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_4__ = ((int)STOP_BITS  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 309;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 312;
                            CSPEC = (ushort) ( (CSPEC | 64) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 316;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            __context__.SourceCodeLine = 317;
                            Print( "Invalid Stop Bits {0:d} received - assuming 1 Stop Bit\r\n", (short)STOP_BITS  .UshortValue) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 321;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_5__ = ((int)SOFTHANDSHAKE  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 0) ) ) ) 
                            {
                            __context__.SourceCodeLine = 324;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 327;
                            CSPEC = (ushort) ( (CSPEC | 6144) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 330;
                            CSPEC = (ushort) ( (CSPEC | 2048) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 3) ) ) ) 
                            {
                            __context__.SourceCodeLine = 333;
                            CSPEC = (ushort) ( (CSPEC | 4096) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 337;
                            CSPEC = (ushort) ( (CSPEC | 32768) ) ; 
                            __context__.SourceCodeLine = 338;
                            Print( "Invalid Software Handshake {0:d} received - assuming No Software Handshake\r\n", (short)SOFTHANDSHAKE  .UshortValue) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 342;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_6__ = ((int)HARDHANDSHAKE  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 0) ) ) ) 
                            {
                            __context__.SourceCodeLine = 345;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 348;
                            CSPEC = (ushort) ( (CSPEC | 1024) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 351;
                            CSPEC = (ushort) ( (CSPEC | 512) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                            {
                            __context__.SourceCodeLine = 354;
                            CSPEC = (ushort) ( (CSPEC | (1024 | 512)) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 358;
                            CSPEC = (ushort) ( (CSPEC | 0) ) ; 
                            __context__.SourceCodeLine = 359;
                            Print( "Invalid Hardware Handshake {0:d} received - assuming No Hardware Handshake\r\n", (short)HARDHANDSHAKE  .UshortValue) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 363;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (REPORTCTS  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 364;
                    CSPEC = (ushort) ( (CSPEC | 16384) ) ; 
                    }
                
                __context__.SourceCodeLine = 366;
                MAKESPEC (  __context__ ,   ref  SPEC__DOLLAR__ , (ushort)( CSPEC )) ; 
                __context__.SourceCodeLine = 367;
                OUT__DOLLAR__  .UpdateValue ( SPEC__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        REPORTCTS = new Crestron.Logos.SplusObjects.DigitalInput( REPORTCTS__DigitalInput__, this );
        m_DigitalInputList.Add( REPORTCTS__DigitalInput__, REPORTCTS );
        
        SENDCOMSPEC = new Crestron.Logos.SplusObjects.DigitalInput( SENDCOMSPEC__DigitalInput__, this );
        m_DigitalInputList.Add( SENDCOMSPEC__DigitalInput__, SENDCOMSPEC );
        
        PORT = new Crestron.Logos.SplusObjects.AnalogInput( PORT__AnalogSerialInput__, this );
        m_AnalogInputList.Add( PORT__AnalogSerialInput__, PORT );
        
        BAUD_RATE = new Crestron.Logos.SplusObjects.AnalogInput( BAUD_RATE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( BAUD_RATE__AnalogSerialInput__, BAUD_RATE );
        
        PARITY = new Crestron.Logos.SplusObjects.AnalogInput( PARITY__AnalogSerialInput__, this );
        m_AnalogInputList.Add( PARITY__AnalogSerialInput__, PARITY );
        
        DATA_BITS = new Crestron.Logos.SplusObjects.AnalogInput( DATA_BITS__AnalogSerialInput__, this );
        m_AnalogInputList.Add( DATA_BITS__AnalogSerialInput__, DATA_BITS );
        
        STOP_BITS = new Crestron.Logos.SplusObjects.AnalogInput( STOP_BITS__AnalogSerialInput__, this );
        m_AnalogInputList.Add( STOP_BITS__AnalogSerialInput__, STOP_BITS );
        
        SOFTHANDSHAKE = new Crestron.Logos.SplusObjects.AnalogInput( SOFTHANDSHAKE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( SOFTHANDSHAKE__AnalogSerialInput__, SOFTHANDSHAKE );
        
        HARDHANDSHAKE = new Crestron.Logos.SplusObjects.AnalogInput( HARDHANDSHAKE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( HARDHANDSHAKE__AnalogSerialInput__, HARDHANDSHAKE );
        
        PROTOCOL = new Crestron.Logos.SplusObjects.AnalogInput( PROTOCOL__AnalogSerialInput__, this );
        m_AnalogInputList.Add( PROTOCOL__AnalogSerialInput__, PROTOCOL );
        
        PACING = new Crestron.Logos.SplusObjects.AnalogInput( PACING__AnalogSerialInput__, this );
        m_AnalogInputList.Add( PACING__AnalogSerialInput__, PACING );
        
        OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OUT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( OUT__DOLLAR____AnalogSerialOutput__, OUT__DOLLAR__ );
        
        
        SENDCOMSPEC.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDCOMSPEC_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_COMSPEC ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint PORT__AnalogSerialInput__ = 0;
    const uint BAUD_RATE__AnalogSerialInput__ = 1;
    const uint PARITY__AnalogSerialInput__ = 2;
    const uint DATA_BITS__AnalogSerialInput__ = 3;
    const uint STOP_BITS__AnalogSerialInput__ = 4;
    const uint SOFTHANDSHAKE__AnalogSerialInput__ = 5;
    const uint HARDHANDSHAKE__AnalogSerialInput__ = 6;
    const uint PROTOCOL__AnalogSerialInput__ = 7;
    const uint PACING__AnalogSerialInput__ = 8;
    const uint REPORTCTS__DigitalInput__ = 0;
    const uint SENDCOMSPEC__DigitalInput__ = 1;
    const uint OUT__DOLLAR____AnalogSerialOutput__ = 0;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
