using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace work_process_control
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            Console.ReadLine();
        }
        private static void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs  e)
        {
            Console.WriteLine("{0}", e.Category);
        }
        private static void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            Console.WriteLine("Session {0}", e.Reason);
        }

    }
   

}
