using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    #region Graphic
    //Color Background
    public enum clBackground
    {
        Form,UserCotrol,BtnApply,BtnCancel,BtnExit,Panel,Label
    }
    //Color Font
    //Font Size
    //
    #endregion
    #region Device
    public enum TypeDev
    {
        Vision,
        PLC,
        Robot,
        Sensor

    }
    public enum GroupUnit
    {
        Connect,
        Position,
        Digital,
        Database,
        Calculation
      
    }
    public enum Brand
    {
        BeeEyes,
        Keyence,
        Mitsubishi,
        Delta,
        ABB,
        EPSON
    }
    public enum Model
    {
        BeeVision,
        KV3000,
        KV500,
        FX3U,
        FX1S
    }
    public enum Connect
    {
        Ethernet, 
        RS485,
        RS422,
        RS232,
        IO
    }
    public enum Protocol
    {
        TCP,
        Serial,
        None
    }
    #endregion
    #region Node
    public enum TypeVar
    {
        Position,
        Digit,
        Bool,
        In,
        Out,
        Timer
    }
    public enum Port
    {
        In,Out,Step
    }
    #endregion
    #region Function
    public enum Function
    {
        RW_PLC,
        RW_Vision,
        OneAxis,
        MutilAxis,
        Convert,
        Compare,
        Delay,
        Timer,
        ReadSensor,
        RW_Scales


    }
    #endregion
    public class Enum
    {
    }
}
