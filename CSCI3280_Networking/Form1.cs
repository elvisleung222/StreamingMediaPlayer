using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//additional
using System.Net; //for getting IP

namespace CSCI3280_Networking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getMyip();
            loadMyPlyaList();
        }
        protected String getMyip()
        {
            
            try
            {
                // Get the local computer host name.
                //return Dns.GetHostName();
                IPAddress[] ips;
                String hostname = Dns.GetHostName();
                ips = Dns.GetHostAddresses(hostname);

                Console.WriteLine("GetHostAddresses({0}) returns:", hostname);

                foreach (IPAddress ip in ips)
                {
                    Console.WriteLine("    {0}", ip);
                }
                this.peerListBox.Items.Add(ips[5].ToString() + "(Yourself)");
                this.console.Text += "Ready.\r\n";
                return ips[5].ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        protected void loadMyPlyaList()
        {
            string line;
            try
            {

                System.IO.StreamReader file = new System.IO.StreamReader(".\\playList.txt");
                while ((line = file.ReadLine()) != null)
                {
                    this.playListBox.Items.Add(line + "(Yourself)");
                }
                file.Close();
                this.console.Text += "Play list is loaded.\r\n";
            }
            catch (Exception e)
            {
                this.console.Text += e.ToString();
                this.console.Text += "\r\n";
            }
            
        }
    }
}
