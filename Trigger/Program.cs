using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Shared;

namespace Trigger
{
    internal class Program
    {
        static RegistryManager registryManager;
        static string connString = "HostName=IoTHub3.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=nYYH7CgByKmpmjKDgWmDhPl9B54JqfdAFAIoTDne/XI=";
        static ServiceClient client;
        static string targetDevice = "RP";

        //Linje 14-18 henter raport fra twin target
        public static async Task QueryTwinRebootReported()
        {
            Twin twin = await registryManager.GetTwinAsync(targetDevice);
            Console.WriteLine(twin.Properties.Reported.ToJson());
        }

        public static async Task StartReboot()
        {
            client = ServiceClient.CreateFromConnectionString(connString);
            CloudToDeviceMethod method = new CloudToDeviceMethod("on"); //Sender melding opp til sky(reboot)
            //CloudToDeviceMethod off = new CloudToDeviceMethod("off");
            method.ResponseTimeout = TimeSpan.FromSeconds(30);
           // off.ResponseTimeout = TimeSpan.FromSeconds(30);

            CloudToDeviceMethodResult result = await
            //  client.InvokeDeviceMethodAsync(targetDevice, off);
              client.InvokeDeviceMethodAsync(targetDevice, method);

            //linje 21 til 28 sender en kommand til twin, som twin skal utføre.

            Console.WriteLine("Invoked firmware update on device.");
        }

        public static async Task Off()
        {
            client = ServiceClient.CreateFromConnectionString(connString);
            //CloudToDeviceMethod method = new CloudToDeviceMethod("on"); //Sender melding opp til sky(reboot)
            CloudToDeviceMethod off = new CloudToDeviceMethod("off");
            //method.ResponseTimeout = TimeSpan.FromSeconds(30);
            off.ResponseTimeout = TimeSpan.FromSeconds(30);

            CloudToDeviceMethodResult result = await
              client.InvokeDeviceMethodAsync(targetDevice, off);
            //client.InvokeDeviceMethodAsync(targetDevice, method);

            //linje 21 til 28 sender en kommand til twin, som twin skal utføre.

            Console.WriteLine("Invoked firmware update on device.");
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            registryManager = RegistryManager.CreateFromConnectionString(connString);

            while (true)
            {
                Console.WriteLine("Enter 'reboot' to send reboot command to device, or 'exit' to quit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "on") //ved å skrive on skrur led på
                {
                    StartReboot().Wait();
                }
                else if (input.ToLower() == "off") //sender off opp i skyen
                {
                    Off().Wait();
                    //break;
                }
                else if (input.ToLower() == "exit") //sender off opp i skyen
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command. Enter 'reboot' to send reboot command.");
                }
            }
            //StartReboot().Wait();
            QueryTwinRebootReported().Wait();
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}