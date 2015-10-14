using System;
using System.IO.Ports;

namespace MonoSerialWrite
{
	class Program
	{
		public static void Main()
		{
			string ttyname;
			SerialPort Serial_tty = new SerialPort();
			
			Console.Write("\nEnter Your SerialPort[tty] name (eg ttyUSB0)->");
			ttyname = Console.ReadLine();
			ttyname = @"/dev/" + ttyname;
			
			Serial_tty.PortName = ttyname;
			Serial_tty.BaudRate = 9600;               // Baudrate = 9600bps
			Serial_tty.Parity   = Parity.None;        // Parity bits = none  
			Serial_tty.DataBits = 8;                  // No of Data bits = 8
			Serial_tty.StopBits = StopBits.One;       // No of Stop bits = 1
			
			try
			{
				Serial_tty.Open();
				Serial_tty.Write("A");                    // Write an ascii "A"
				Serial_tty.Close();                       // Close port
				Console.WriteLine("\nA written to port {0}\n", Serial_tty.PortName);
			}
			catch
			{
				Console.WriteLine("Error in Opening {0}\n",Serial_tty.PortName);
			}
			
		}
	}
}
