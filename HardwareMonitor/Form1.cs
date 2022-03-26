using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using Microsoft.Win32;
using System.Threading;

namespace HardwareMonitor
{
    public partial class Form1 : Form
    {
        Startup Startup = new Startup();

        int i, a = 0;
        float flt, y;
        string ramsize, name;

        string[] enHome = { "Model", "Base clock", "Usage", "Available", "Total", "Used", "Activity", "Used" };
        string[] itHome = { "Modello", "Frequenza base", "Utilizzo", "Disponibile", "Totale", "Utilizzata", "Attività", "Utilizzato" };

        PerformanceCounter CPU = new PerformanceCounter("Processore", "% Tempo Processore", "_Total"); //oggetto, contatore, istanza
        PerformanceCounter CPUfreq = new PerformanceCounter("Informazioni Processore", "Frequenza Processore", "_Total");
        PerformanceCounter RAM = new PerformanceCounter("Memoria", "MByte disponibili"); //oggetto, contatore
        PerformanceCounter HDD = new PerformanceCounter("Disco fisico", "% Tempo disco", "_Total");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startup.ShowDialog();
            this.Show();
            timer1.Start();

            lbltotal.Text = Convert.ToString(systemLanguage(enHome, itHome, 4)) + " " + totram() + " GB";//RAM totale

            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    lblmodel.Text = (string)processor_name.GetValue("ProcessorNameString");
                }
            }

            if (nameCPU() == "AMD" || nameCPU() == "Amd" || nameCPU() == "amd")
            {
                circularProgressBar1.ProgressColor = Color.FromArgb(237, 28, 36);
            }
            else if (nameCPU() == "INTEL" || nameCPU() == "Intel" || nameCPU() == "intel")
            {
                circularProgressBar1.ProgressColor = Color.FromArgb(0, 113, 197);
            }
            else
                circularProgressBar1.ProgressColor = Color.White;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cpupercent, ramused, rampercent, hddpercent;
            hddpercent = (int)HDD.NextValue();
            cpupercent = (int)CPU.NextValue();
            //ramused = (int)RAM.NextValue();

            //CPU
            lblbaseclock.Text = systemLanguage(enHome, itHome, 1) + " " + Convert.ToString(CPUfreq.NextValue()) + " MHz" + " (Boost Excluded)";
            lblusage.Text = systemLanguage(enHome, itHome, 2) + " " + cpupercent + " %"; //CPU%
            circularProgressBar1.Value = cpupercent;
            circularProgressBar1.Text = cpupercent + "%";

            //RAM
            float Ramgb = ramtotMB();//senza questo il form lagga

            ramused = (int)RAM.NextValue();
            lblavailable.Text = systemLanguage(enHome, itHome, 3) + " " + ramused + " MB"; //RAM%                       
            lblused.Text = systemLanguage(enHome, itHome, 5) + " " + Convert.ToString(Ramgb - (ramused * 1024 / 1000)) + " MB"; //RAM utilizzata + conversione
            rampercent = 100 - (ramused * 100 / (int)Ramgb);
            circularProgressBar2.Value = rampercent;
            circularProgressBar2.Text = rampercent + "%";

            //HDD
            if (hddpercent > 100)
            { 
                hddpercent = 100;//per qualche strano motivo la percentuale supera il 100%
            }
            circularProgressBar3.Value = hddpercent;
            circularProgressBar3.Text = hddpercent + "%";
            lblhddactivity.Text = systemLanguage(enHome, itHome, 6)  + " " + Convert.ToString(hddpercent) + " %";//HDD%
            lblhddused.Text = systemLanguage(enHome, itHome, 7) + " " + " GB";
            
        }

        private void btnINFO_Click(object sender, EventArgs e)// informazioni aggiuntive CPU
        {
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                sb.AppendLine(string.Format("Name : {0}", (string)mo["Name"]));
                sb.AppendLine(string.Format("BaseClock : {0}", mo["MaxClockSpeed"] + " MHz").ToString());
                sb.AppendLine(string.Format("CurrentClock : {0}", mo["CurrentClockSpeed"] + " MHz").ToString());
                sb.AppendLine(string.Format("Cores : {0}", mo["NumberOfCores"]).ToString());
                sb.AppendLine(string.Format("Threads : {0}", mo["NumberOfLogicalProcessors"]).ToString());
                sb.AppendLine(string.Format("L2Cache : {0}", mo["L2CacheSize"] + " KB").ToString());
                sb.AppendLine(string.Format("L3Cache : {0}", mo["L3CacheSize"] + " KB").ToString());
                sb.AppendLine(string.Format("Voltage : {0}", (ushort)mo["CurrentVoltage"] + " V"));
                sb.AppendLine(string.Format("Manufacturer: {0}", (string)mo["Manufacturer"]));

            }
            MessageBox.Show(sb.ToString());
        }

        //FUNZIONI

        public void hideHome()//funzione che nasconde la Home
        {
            menuStrip1.Hide();
            lblhddused.Hide();
            lblused.Hide();
            lblusage.Hide();
            lblavailable.Hide();
            lblhddactivity.Hide();
            lblbaseclock.Hide();
            lblmodel.Hide();
            lbltotal.Hide();
            lblCPU.Hide();
            lblRAM.Hide();
            lblHDD.Hide();
            circularProgressBar1.Hide();
            circularProgressBar2.Hide();
            circularProgressBar3.Hide();
            btnINFO.Hide();
            btncpu.Hide();
        }

        public void showHome()//funzione che mostra la Home
        {
            menuStrip1.Show();
            lblhddused.Show();
            lblused.Show();
            lblusage.Show();
            lblavailable.Show();
            lblhddactivity.Show();
            lblbaseclock.Show();
            lblmodel.Show();
            lbltotal.Show();
            lblCPU.Show();
            lblRAM.Show();
            lblHDD.Show();
            circularProgressBar1.Show();
            circularProgressBar2.Show();
            circularProgressBar3.Show();
            btnINFO.Show();
            btncpu.Show();
            
        }

        private void impostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                hideHome();
                menuStrip1.Show();
                a++;
            }
            else if (a == 1)
            {
                showHome();
                a--;
            }
        }

        private void informazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                hideHome();
                menuStrip1.Show();
                a++;
            }
            else if (a == 1)
            {
                showHome();
                a--;
            }
        }

        private void btncpu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm SettingsForm = new SettingsForm();
            SettingsForm.Show();
            SettingsForm.Left = this.Left;
            SettingsForm.Top = this.Top;
            SettingsForm.Size = this.Size;
        }

        public string nameCPU() //estrae il nome di riferimento della CPU (es. Intel, Amd)
        {
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                name = Convert.ToString(sb.AppendLine(string.Format((string)mo["Name"])));
            }

            string finalname = name.Substring(0, 6);

            if (finalname.Substring(0, 1) == "A" || finalname.Substring(0, 1) == "a")//se la prima lettera è "A" allora restituisce "AMD"
            {
                finalname = finalname.Substring(0, 3);
            }
            else if (finalname.Substring(0, 1) == "I" || finalname.Substring(0, 1) == "i")//se la prima lettera è "I" allora restituisce "Intel"
            {
                finalname = finalname.Substring(0, 5);
            }

            return finalname;
        }

        public float ramtotMB()//estrae la quantità totale di RAM (MB) utilizzabile dal sistema
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");//LENTOOO
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                ramsize = Convert.ToString(result["TotalVisibleMemorySize"]);
                y = Convert.ToInt32(ramsize);
                y = y / 1024; // conversione da KiloByte a MegaByte con decimali
                i = (int)y;
            }

            return i;
        }

        public float ramtotGB(float f)// trasforma la ram da MB a GB, con 2 numeri decimali (es 9,86 GB)
        {
            int int1;
            int1 = (int)f;
            f = (float)int1 / 1024;
            f =  f * 100;
            int1 = (int)f;
            f = (float)int1 / 100;
            return f;
        }

        public string systemLanguage(string[] eng, string[] ita, int n) // lingua di sistema
        {
            if (rdbtnita.Checked == true)
            {
                return ita[n];
            }
            return eng[n];
        }

        public float totram()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");//LENTOOOOO
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            flt = ramtotGB(ramtotMB());
            return flt;
        }
    }
}
