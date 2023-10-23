using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_group3.Classes;
using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Shared;

namespace Code_group3
{
    public partial class Monitoring : Form
    {
        static RegistryManager registryManager;
        static string connString = "HostName=IoTHub3.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=nYYH7CgByKmpmjKDgWmDhPl9B54JqfdAFAIoTDne/XI=";
        static ServiceClient client;
        static string targetDevice = "RP";

        //henter raport fra twin target
        public static async Task QueryTwinRebootReported()
        {
            Twin twin = await registryManager.GetTwinAsync(targetDevice);
        }

        public static async Task StartReboot()
        {
            try
            {
                client = ServiceClient.CreateFromConnectionString(connString);
                CloudToDeviceMethod method = new CloudToDeviceMethod("on"); //Sender melding opp til sky(reboot)
                method.ResponseTimeout = TimeSpan.FromSeconds(30);
                CloudToDeviceMethodResult result = await
                  client.InvokeDeviceMethodAsync(targetDevice, method);
            }
            catch (Exception)
            {

                
            }
            
            
        }

        public static async Task Off()
        {

            try
            {
                client = ServiceClient.CreateFromConnectionString(connString);
                CloudToDeviceMethod off = new CloudToDeviceMethod("off");
                off.ResponseTimeout = TimeSpan.FromSeconds(30);
                CloudToDeviceMethodResult result = await
                  client.InvokeDeviceMethodAsync(targetDevice, off);
            }
            catch (Exception ex)
            {

                
            }
           
            
        }

        public Monitoring()
        {   
            InitializeComponent();
            FillDgv fillDgv = new FillDgv();
            fillDgv.fillDgvM(dgvM);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();

            this.Hide();
        }

        private void btnLightOn_Click(object sender, EventArgs e)
        {
            pbLight.Visible = true;  // Vis PictureBox1

            registryManager = RegistryManager.CreateFromConnectionString(connString);
            try
            {
                StartReboot();
                QueryTwinRebootReported();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }    
            
        }

        private void btnLightOff_Click(object sender, EventArgs e)
        {
            pbLight.Visible = false; // Skjul PictureBox2
            registryManager = RegistryManager.CreateFromConnectionString(connString);

            try
            {
                Off();
                QueryTwinRebootReported();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
