using System;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using Memory;

namespace csharpassault
{
    public partial class cheat : Form
    {

        public static string currentweaponammo = "ac_client.exe+0x10F4F4,374,14,0";

        Mem wrm = new Mem();

        public cheat()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // checks for appid (in this case assault cube)
            int pid = wrm.GetProcIdFromName("ac_client");

            // if client isnt open, open the process... durr
            if (pid > 0)
            {
                wrm.OpenProcess(pid);


                // Thread that writes to the ammo
                // isbackground makes thread run in background
                Thread WrteAm = new Thread(writeweaponammo) { IsBackground = true };

                // starts thread
                WrteAm.Start();
            }
        }


        // method for memory edit
        private void writeweaponammo()
        {


            while (true)
            {
                if (ammo.Checked)
                {
                    wrm.WriteMemory(currentweaponammo, "int", "9999");
                    Thread.Sleep(2);
                }
            }


        }

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // hp

        public static string CurrentHealthAddr = "ac_client.exe+10F4F4,F8";
        private void health_CheckedChanged(object sender, EventArgs e)
        {
            int pid = wrm.GetProcIdFromName("ac_client");

            if (pid > 0)
            {
                wrm.OpenProcess(pid);

                Thread wrtehp = new Thread(writeplayerhealth) { IsBackground = true }; 

                wrtehp.Start();
            }

            void writeplayerhealth()
            {


                while (true)
                {
                    if (health.Checked)
                    {
                        wrm.WriteMemory(CurrentHealthAddr, "int", "9999");
                        Thread.Sleep(2);
                    }
                }


            }


        }
    }
}