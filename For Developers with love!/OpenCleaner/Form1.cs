using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OpenCleaner
{
    public partial class ana : Form
    {
        public ana()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "Cleaning...";
            progressBar1.Value = 0;
            string temp = @"C:\\Windows\\Temp";
            string kullaniciadi = Environment.UserName;
            string appdatatemp = (@"C:\\Users\\" + kullaniciadi + "\\Appdata\\Local\\Temp");
            //string prefetch = @"C:\\Windows\\Prefetch";
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 50;
            Process cmd;
            if (checkBox1.Checked==false)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    Thread.Sleep(1000);
                    cmd.StandardInput.WriteLine("del /q/f/s %temp%\\");
                    if (checkBox2.Checked == true) { MessageBox.Show("%temp% and temp files deleted."); }
                    cmd.StandardInput.WriteLine("del /q/f/s C:\\Windows\\Temp");
                    Thread.Sleep(1000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    Directory.Delete(temp, true);
                }
                catch { }
            }
            if (checkBox1.Checked == true)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    Thread.Sleep(1000);
                    cmd.StandardInput.WriteLine("del /q/f/s %temp%\\");
                    cmd.StandardInput.WriteLine("del /q/f/s C:\\Windows\\Temp");
                    Thread.Sleep(1000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    Directory.Delete(temp, true);
                }
                catch { }
            }
            
            progressBar1.Value = 100;
            label3.Text = "Cleaned!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "Cleaning...";
            progressBar1.Value = 0;
            string prefetch = @"C:\\Windows\\Prefetch";
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 50;
            Process cmd;
            if (checkBox1.Checked == false)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    Thread.Sleep(1000);
                    cmd.StandardInput.WriteLine("del /q/f/s C:\\Windows\\Prefetch");
                    if (checkBox2.Checked == true) { MessageBox.Show("prefetch files deleted."); }
                    Thread.Sleep(1000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                }
                catch { }
            }
           if (checkBox1.Checked == true)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    Thread.Sleep(1000);
                    cmd.StandardInput.WriteLine("del /q/f/s C:\\Windows\\Prefetch");
                    Thread.Sleep(1000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                }
                catch { }
            }
            progressBar1.Value = 100;
            label3.Text = "Cleaned!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = "Cleaning...";
            progressBar1.Value = 0;
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 50;
            Process cmd;
            if (checkBox1.Checked == false)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    Thread.Sleep(1000);
                    cmd.StandardInput.WriteLine("ipconfig /release");
                    if (checkBox2.Checked == true) { MessageBox.Show("IP released and renewed."); }
                    cmd.StandardInput.WriteLine("ipconfig /renew");
                    Thread.Sleep(1000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                }
                catch { }
            }
           if (checkBox1.Checked == true)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    Thread.Sleep(1000);
                    cmd.StandardInput.WriteLine("ipconfig /release");
                    cmd.StandardInput.WriteLine("ipconfig /renew");
                    Thread.Sleep(1000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                }
                catch { }
            }

            progressBar1.Value = 100;
            label3.Text = "Cleaned!";
        }

        private void btjunk_Click(object sender, EventArgs e)
        {
            paneljunk.Visible = true;
            paneljunk.Location = new Point(12, 85);
            panelhealth.Visible = false;
            panelhealth.Location = new Point(830, 585);
            paneltools.Visible = false;
            paneltools.Location = new Point(830, 585);
            panelsettings.Visible = false;
            panelsettings.Location = new Point(830, 585);
            panel2.Visible = false;
            panel2.Location = new Point(830, 585);
        }

        private void bthealth_Click(object sender, EventArgs e)
        {
            paneljunk.Visible = false;
            paneljunk.Location = new Point(830, 585);
            panelhealth.Visible = true;
            panelhealth.Location = new Point(12, 85);
            paneltools.Visible = false;
            paneltools.Location = new Point(830, 585);
            panelsettings.Visible = false;
            panelsettings.Location = new Point(830, 585);
            panel2.Visible = false;
            panel2.Location = new Point(830, 585);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process cmd;
            progressBar2.Value = 1;
            label4.Text = ("Checking Windows Files...");
            if (checkBox1.Checked == false)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();

                    cmd.StandardInput.WriteLine("sfc /scannow");
                    Thread.Sleep(10000);
                    if (checkBox2.Checked == true) { MessageBox.Show("/sfc scannow is started."); }
                    cmd.StandardInput.WriteLine("sfc /scannow");
                    Thread.Sleep(10000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    progressBar2.Value = 33;
                    label4.Text = ("Checking Windows Update...");

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();

                    Thread.Sleep(10000);
                    cmd.StandardInput.WriteLine("DISM /Online /Cleanup-Image /ScanHealth");
                    Thread.Sleep(100000);
                    if (checkBox2.Checked == true) { MessageBox.Show("Doing some DISM work..."); }
                    cmd.StandardInput.WriteLine("DISM /Online /Cleanup-Image /RestoreHealth");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    progressBar2.Value = 66;
                    label4.Text = ("Checking Disks...");

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();

                    Thread.Sleep(10000);
                    cmd.StandardInput.WriteLine("chkdsk C:");
                    if (checkBox2.Checked == true) { MessageBox.Show("Who checks the disks anyways?"); }
                    Thread.Sleep(100000);
                    cmd.StandardInput.WriteLine("chkdsk D:");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    progressBar2.Value = 100;
                    label4.Text = ("Done!");

                }
                catch { }
            }
            if (checkBox1.Checked ==true)
            {
                try
                {

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();

                    cmd.StandardInput.WriteLine("sfc /scannow");
                    Thread.Sleep(10000);
                    cmd.StandardInput.WriteLine("sfc /scannow");
                    Thread.Sleep(10000);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    progressBar2.Value = 33;
                    label4.Text = ("Checking Windows Update...");

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();

                    Thread.Sleep(10000);
                    cmd.StandardInput.WriteLine("DISM /Online /Cleanup-Image /ScanHealth");
                    Thread.Sleep(100000);
                    cmd.StandardInput.WriteLine("DISM /Online /Cleanup-Image /RestoreHealth");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    progressBar2.Value = 66;
                    label4.Text = ("Checking Disks...");

                    cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();

                    Thread.Sleep(10000);
                    cmd.StandardInput.WriteLine("chkdsk C:");
                    Thread.Sleep(100000);
                    cmd.StandardInput.WriteLine("chkdsk D:");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    progressBar2.Value = 100;
                    label4.Text = ("Done!");

                }
                catch { }
            }
            
        }

        private void button1_Click(object sender, EventArgs e) //cmd
        {
            try { System.Diagnostics.Process.Start("cmd.exe"); }
            catch { MessageBox.Show("OpenCleaner was unable to perform this operation."); }
        }

        private void button10_Click(object sender, EventArgs e) //device manager
        {
            try { Process.Start("devmgmt.msc"); }
            catch { MessageBox.Show("OpenCleaner was unable to perform this operation."); }
        }

        private void button11_Click(object sender, EventArgs e) //control panel
        {
            Process p;
            try
            {
                p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                p.StandardInput.WriteLine("start control");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                Console.WriteLine(p.StandardOutput.ReadToEnd());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button12_Click(object sender, EventArgs e) //task manager
        {
            try { System.Diagnostics.Process.Start("taskmgr.exe"); }
            catch { MessageBox.Show("OpenCleaner was unable to perform this operation."); }
        }

        private void button13_Click(object sender, EventArgs e) //dxdiag
        {
            try { System.Diagnostics.Process.Start("dxdiag.exe"); }
            catch { MessageBox.Show("OpenCleaner was unable to perform this operation."); }
        }

        private void button14_Click(object sender, EventArgs e) //win update
        {
            Process p;
            try
            {
                p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                p.StandardInput.WriteLine("C:\\Windows\\System32\\control.exe /name Microsoft.WindowsUpdate");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                Console.WriteLine(p.StandardOutput.ReadToEnd());
            }
            catch (Exception ex) { MessageBox.Show("OpenCleaner was unable to perform this operation."); }
        }

        private void button15_Click(object sender, EventArgs e) //regedit
        {
            try { System.Diagnostics.Process.Start("regedit.exe"); }
            catch { MessageBox.Show("OpenCleaner was unable to perform this operation."); }
        }

        private void button16_Click(object sender, EventArgs e) //disk manager
        {
            try { Process.Start("diskmgmt.msc"); }
            catch { MessageBox.Show("OpenCleaner was unable to perform this operation."); }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yagisoft");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paneltools.Visible = true;
            paneltools.Location = new Point(12, 85);
            paneljunk.Visible = false;
            paneljunk.Location = new Point(830, 585);
            panelhealth.Visible = false;
            panelhealth.Location = new Point(830, 585) ;
            panelsettings.Visible = false;
            panelsettings.Location = new Point(830, 585);
            panel2.Visible = false;
            panel2.Location = new Point(830, 585);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelsettings.Visible = true;
            panelsettings.Location = new Point(12, 85);
            paneltools.Visible = false;
            paneltools.Location = new Point(830, 585);
            paneljunk.Visible = false;
            paneljunk.Location = new Point(830, 585);
            panelhealth.Visible = false;
            panelhealth.Location = new Point(830, 585);
            panel2.Visible = false;
            panel2.Location = new Point(830, 585);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yagisoft/OpenCleaner");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yagizzg.xyz/ycleaner-en");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ana_Load(object sender, EventArgs e)
        {
            panelsettings.Visible = false;
            panelsettings.Location = new Point(830, 585);
            paneltools.Visible = false;
            paneltools.Location = new Point(830, 585);
            paneljunk.Visible = false;
            paneljunk.Location = new Point(830, 585);
            panelhealth.Visible = false;
            panelhealth.Location = new Point(830, 585);
            panel2.Visible = true;
            panel2.Location = new Point(12, 85);
        }
    }
}
