using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_group3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            Monitoring Monitoring = new Monitoring();
            Monitoring.Show();

            this.Hide();
        }

        private void btnAlarmHandling_Click(object sender, EventArgs e)
        {
            AlarmHandler Alarmhandler = new AlarmHandler();
            Alarmhandler.Show();

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string serverIpAddress = "8.8.8.8"; // Endre til den faktiske IP-adressen
            ServerPinger serverPinger = new ServerPinger(serverIpAddress);

            bool isServerOnline = serverPinger.PingServer();

            if (isServerOnline)
            {
                txtBoxServerStatus.Text = "online";
                txtBoxServerStatus.ForeColor = System.Drawing.Color.Green;
                //MessageBox.Show("Serveren er tilgjengelig.");
            }
            else
            {
                txtBoxServerStatus.Text = "offline";
                txtBoxServerStatus.ForeColor = System.Drawing.Color.Red;
                //MessageBox.Show("Serveren er ikke tilgjengelig.");
            }
        }


    }
}
