using System;
using Logix;

namespace NETLOGIX.CS.Console
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
            string cpuType;
			string ipaddress;
			string path;
			string tagname;

			// display app info
			System.Console.WriteLine("INGEAR.NET.LOGIX 7.1 C# Console Example");


LBL_STEP_1:
			System.Console.WriteLine();
            // CPU Type
            System.Console.Write("Select CPU Type  0 = ControlLogix/CompactLogix  1 = Micro850 ");
            cpuType = System.Console.ReadLine();

            System.Console.WriteLine();

			// prompt for IP Address
			System.Console.Write("Enter IP Address of ControlLogix: ");
			ipaddress = System.Console.ReadLine();

			// make sure user entered something
			if (0 == ipaddress.Length)
			{
				System.Console.WriteLine("Please enter an IP Address");
				goto LBL_STEP_1;
			}
			
LBL_STEP_2:
			System.Console.WriteLine();
			// prompt for CPU Slot or CIP Path
			System.Console.Write("Enter CPU Slot/CIP Path of CPU.  If this is 5069 CompactLogix 5380 or 5480 leave blank ");
			path = System.Console.ReadLine();

LBL_STEP_3:
			System.Console.WriteLine();
			// prompt for Tag Name
			System.Console.Write("Enter Tagname: ");
			tagname = System.Console.ReadLine();

			// make sure user entered something
			if (0 == tagname.Length)
			{
				System.Console.WriteLine("Please enter a Tagname");
				goto LBL_STEP_3;
			}
			
				// create Controller instance and connect to Allen-Bradley device
			Controller ControlLogix = new Controller();
            if (cpuType.Contains("1"))
                ControlLogix.CPUType = Controller.CPU.MICRO;
            else
                ControlLogix.CPUType = Controller.CPU.LOGIX;

            ControlLogix.IPAddress = ipaddress;
            ControlLogix.Path = path;
            ControlLogix.Timeout = 3000;

			System.Console.WriteLine();

			// check for errors
			if (ControlLogix.Connect()!= ResultCode.E_SUCCESS)
			{
				System.Console.Write("Controller Error = ");
				System.Console.WriteLine(ControlLogix.ErrorString);

				// prompt for exit
				System.Console.WriteLine();
				System.Console.Write("Press any key");
				System.Console.ReadLine();
				return;
			}


			// create instance of Tag class and immediately read
			Tag ControlLogixTag = new Tag(ControlLogix, tagname);

			// quality = QUAL_GOOD
            if (ControlLogixTag.QualityCode == Logix.ResultCode.QUAL_GOOD)
            {
                
                System.Console.WriteLine("** SUCCESS **");
                // display value
                System.Console.WriteLine("Value = " + ControlLogixTag.Value.ToString());

                System.Console.WriteLine("Type  = " + ControlLogixTag.NetType.ToString());
                System.Console.WriteLine("Time  = " + ControlLogixTag.TimeStamp.ToString());
            }
            else
          
                // display the error
                System.Console.WriteLine("Tag Error = " + ControlLogixTag.ErrorString);

           
			System.Console.WriteLine("Quality = " + ControlLogixTag.QualityString);
			
			
			// prompt for exit
			System.Console.WriteLine();
			System.Console.Write("Press any key");
			System.Console.ReadLine();

		
		}
	}
}
