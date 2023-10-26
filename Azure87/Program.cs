using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;
using Microsoft.Azure.Devices;
using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Device.Gpio;
using TransportType = Microsoft.Azure.Devices.Client.TransportType;

namespace Azure68
{
    internal class Program
    {
        static string DeviceConnectionString = "HostName=IoTHub3.azure-devices.net;DeviceId=RP;SharedAccessKey=vESrek3yWdKZGTLwb6+awhgl5Wfu05Lrc8qZvrIRHpo=";
        static DeviceClient Client = null;
        static ServiceClient client;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            static Task<MethodResponse> onReboot(MethodRequest methodRequest, object userContext)
            {
                // In a production device, you would trigger a reboot 
                //   scheduled to start after this method returns.
                // For this sample, we simulate the reboot by writing to the console
                //   and updating the reported properties.
                try
                {
                    

                    // Update device twin with reboot time. 
                    //TwinCollection reportedProperties, reboot, lastReboot;
                    //lastReboot = new TwinCollection();
                    //reboot = new TwinCollection();
                    //reportedProperties = new TwinCollection();
                    //lastReboot["lastReboot"] = DateTime.Now;
                    //reboot["reboot"] = lastReboot;
                    //reportedProperties["iothubDM"] = reboot;

                    //Console.WriteLine("Blinking LED. Press Ctrl+C to end.");
                    int pin = 18;
                    using var controller = new GpioController();
                    controller.OpenPin(pin, PinMode.Output);

                    //bool ledOn = true;
                    //while (true)
                    //{
                    //    controller.Write(pin, ((ledOn) ? PinValue.High : PinValue.Low));
                    //    Thread.Sleep(1000);
                    //    ledOn = !ledOn;

                    //    //Client.UpdateReportedPropertiesAsync(reportedProperties).Wait();


                    //}

                    controller.Write(pin, PinValue.High);

                    Console.WriteLine("LED PÅ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error in sample: {0}", ex.Message);
                }

                string result = @"{""result"":""Reboot started.""}";
                return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 200));
            }

            static Task<MethodResponse> off(MethodRequest methodRequest, object userContext)
            {
                // In a production device, you would trigger a reboot 
                //   scheduled to start after this method returns.
                // For this sample, we simulate the reboot by writing to the console
                //   and updating the reported properties.
                try
                {
                    

                    // Update device twin with reboot time. 
                    //TwinCollection reportedProperties, reboot, lastReboot;
                    //lastReboot = new TwinCollection();
                    //reboot = new TwinCollection();
                    //reportedProperties = new TwinCollection();
                    //lastReboot["lastReboot"] = DateTime.Now;
                    //reboot["reboot"] = lastReboot;
                    //reportedProperties["iothubDM"] = reboot;

                    //Console.WriteLine("Blinking LED. Press Ctrl+C to end.");
                    int pin = 18;
                    using var controller = new GpioController();
                    controller.OpenPin(pin, PinMode.Output);


                    //bool ledOn = true;
                    //while (true)
                    //{
                    //    controller.Write(pin, ((ledOn) ? PinValue.High : PinValue.Low));
                    //    Thread.Sleep(1000);
                    //    ledOn = !ledOn;

                    //    //Client.UpdateReportedPropertiesAsync(reportedProperties).Wait();


                    //}

                    controller.Write(pin, PinValue.Low);

                    Console.WriteLine("LED AV");
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error in sample: {0}", ex.Message);
                }

                string result = @"{""result"":""Reboot started.""}";
                return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 200));
            }







            try
            {
                Console.WriteLine("Connecting to hub");
                Client = DeviceClient.CreateFromConnectionString(DeviceConnectionString,
                  TransportType.Mqtt);

                // setup callback for "reboot" method
                Client.SetMethodHandlerAsync("on", onReboot, null).Wait(); //Definer hva vi må sende i consolen fra skya
                Client.SetMethodHandlerAsync("off", off, null).Wait();
                Console.WriteLine("Waiting for reboot method\n Press enter to exit.");
                Console.ReadLine();

                Console.WriteLine("Exiting...");

                // as a good practice, remove the "reboot" handler
                Client.SetMethodHandlerAsync("reboot", null, null).Wait();
                Client.SetMethodHandlerAsync("off", null, null).Wait();
                Client.CloseAsync().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Error in sample: {0}", ex.Message);
            }
        }
    }
}
