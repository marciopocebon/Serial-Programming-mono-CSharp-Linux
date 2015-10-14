    //====================================================================================================//
	// Serial Port Programming using Mono and C# on Linux                                                 //
	// (Reads data from serial port)                                                                      //
	//====================================================================================================//
	
	//====================================================================================================//
	// www.xanthium.in										                                              //
	// Copyright (C) 2015 Rahul.S                                                                         //
	//                                                                                                    //
	// Visit http://xanthium.in/Serial-Programming-using-Mono-and-CSharp-on-Linux                         //
	//====================================================================================================//
	
	//====================================================================================================//
	// The Program runs on the PC side and uses mono framework to communicate with the serial port or     //
	// USB2SERIAL board and reads the data from it.                                                       //       
	// BaudRate     -> 9600                                                                               //
	// Data formt   -> 8 databits,No parity,1 Stop bit (8N1)                                              //
	// Flow Control -> None                                                                               //
	//----------------------------------------------------------------------------------------------------//
	
	
	//====================================================================================================//
	// Compiler/IDE  :	mcs (Mono Framework)                                                              //
	// Library       :  Mono Framework on Linux                                                           //
	// Commands      :  mcs MonoSerialRead.cs                                                             //
	// OS            :	Linux                                                                             //
	// Programmer    :	Rahul.S                                                                           //
	// Date	         :	14-October-2015                                                                   //
	//====================================================================================================//

	
using System;
using System.IO.Ports;  // used for accessing SerialPort Class

namespace MonoSerialRead
{
	class Program
	{
		public static void Main()
		{
			string ttyname = "";         // for storing name of the serial port
			string ReceivedData = "";    // for storing received data from microcontroller
			
			SerialPort Serial_tty = new SerialPort(); //Create a new serialPort object
			
			Console.Write("\nEnter Your SerialPort[tty] name (eg ttyUSB0)->"); 
			ttyname = Console.ReadLine();             // Read the name of the port eg ttyUSB0
			ttyname = @"/dev/" + ttyname;             // Concatanate so name looks like /dev/ttyUSB0
			
			Serial_tty.PortName = ttyname;            // assign the port name 
			Serial_tty.BaudRate = 9600;               // Baudrate = 9600bps
			Serial_tty.Parity   = Parity.None;        // Parity bits = none  
			Serial_tty.DataBits = 8;                  // No of Data bits = 8
			Serial_tty.StopBits = StopBits.One;       // No of Stop bits = 1
			
			try
			{
				Serial_tty.Open();                             //open the port 
				Console.WriteLine("\nWaiting for Data......"); 
				ReceivedData = Serial_tty.ReadLine();     // Read the data send from microcontroller
                Serial_tty.Close();                       // Close port
				Console.WriteLine("\n{0} received\n", ReceivedData);
			}
			catch
			{
				Console.WriteLine("Error in Opening {0}\n",Serial_tty.PortName);
			}
			
		}
	}
}
