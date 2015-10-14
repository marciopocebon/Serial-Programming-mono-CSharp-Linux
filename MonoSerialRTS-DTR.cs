    //====================================================================================================//
	// Serial Port Programming using Mono and C# on Linux                                                 //
	// (Controls the RTS and DTR pins of serial port)                                                     //
	//====================================================================================================//
	
	//====================================================================================================//
	// www.xanthium.in										                                              //
	// Copyright (C) 2015 Rahul.S                                                                         //
	//                                                                                                    //
	// Visit http://xanthium.in/Serial-Programming-using-Mono-and-CSharp-on-Linux                         //
	//====================================================================================================//
	
	//====================================================================================================//
	// The Program runs on the PC side and uses mono framework to communicate with the serial port or     //
	// USB2SERIAL board and controls the RTS and DTR pins                                                 //       
	//====================================================================================================//
	// Compiler/IDE  :	mcs (Mono Framework)                                                              //
	// Library       :  Mono Framework on Linux                                                           //
	// Commands      :  mcs MonoSerialRTS-DTR.cs                                                          //
	// OS            :	Linux                                                                             //
	// Programmer    :	Rahul.S                                                                           //
	// Date	         :	14-October-2015                                                                   //
	//====================================================================================================//

using System;
using System.IO.Ports;

namespace MonoSerialRTSDTRControl
{
	class Program
	{
		public static void Main()
		{
			 string ttyname = "/dev/ttyUSB0"; // port name 
			 SerialPort Serial_tty = new SerialPort();
			 Serial_tty.PortName = ttyname;
			 Serial_tty.Open();             // Open the port
             Serial_tty.RtsEnable = true;   // RTS pin = 1 ,~RTS = 0
             Console.Read();                // Press any key
             Serial_tty.RtsEnable = false;  // RTS pin = 0 ,~RTS = 1
             Console.Read();              
             Serial_tty.DtrEnable = true;   // DTR pin = 1, ~DTR = 0
             Console.Read();
             Serial_tty.DtrEnable = false;  // DTR pin = 0, ~DTR = 1
             Console.Read();

             Serial_tty.Close();             // Close port
		}
	}
}
