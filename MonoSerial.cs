    //====================================================================================================//
	// Serial Port Programming using Mono and C# on Linux                                                 //
	// (Open's serial port)                                                                      //
	//====================================================================================================//
	
	//====================================================================================================//
	// www.xanthium.in										                                              //
	// Copyright (C) 2015 Rahul.S                                                                         //
	//                                                                                                    //
	// Visit http://xanthium.in/Serial-Programming-using-Mono-and-CSharp-on-Linux                         //
	//====================================================================================================//
	
	//====================================================================================================//
	// The Program runs on the PC side and uses mono framework to open the serial port                    //	
	//====================================================================================================//
	// Compiler/IDE  :	mcs (Mono Framework)                                                              //
	// Library       :  Mono Framework on Linux                                                           //
	// Commands      :  mcs MonoSerial.cs                                                             //
	// OS            :	Linux                                                                             //
	// Programmer    :	Rahul.S                                                                           //
	// Date	         :	14-October-2015                                                                   //
	//====================================================================================================//
	
	
using System;
using System.IO.Ports;             // used for accessing SerialPort Class

namespace MonoSerial
{
   class Program
   {
       public static void Main()
       {
	  SerialPort Serial_tty = new SerialPort(); //Create a new Serial Port Object

	  Serial_tty.PortName = "/dev/ttyUSB0";     // Assign the port name,
                                                // here ttyUSB0 is the name of the USB to Serial Converter used. 

	  try
          {
             Serial_tty.Open(); //O pen the Port
             Console.WriteLine("Serial Port {0} Opened",Serial_tty.PortName);
          }	
	  catch
          {
              Console.WriteLine("ERROR in Opening Serial Port");
          }  
       }
    }
}
