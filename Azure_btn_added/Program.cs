using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;
using Microsoft.Azure.Devices;
using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Device.Gpio;
using System.Data.SqlClient;
using Azure87;
using System.Data;

namespace Azure68
{
    internal class Program
    {
        static RegistryManager registryManager;
        static string DeviceConnectionString = "HostName=IoTHub3.azure-devices.net;DeviceId=RP;SharedAccessKey=vESrek3yWdKZGTLwb6+awhgl5Wfu05Lrc8qZvrIRHpo=";
        static string connString = "HostName=IoTHub3.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=nYYH7CgByKmpmjKDgWmDhPl9B54JqfdAFAIoTDne/XI=";
        static DeviceClient Client = null;
        static ServiceClient client;
        static string targetDevice = "RP";



        //Trykknapp
        public static async Task BtnPush()
        {


            Console.WriteLine("ALARM!");


            //Prøver og sende opp til database
            string sqlQuery2 = @"alarmAktiv";
            try
            {
                SQLcon classConnection = new SQLcon();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery2, SQLcon.myCon);
                dt = new DataTable();
                sda.Fill(dt);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        static void Main(string[] args)
        {
            

            // Led Lys PÅ
            static Task<MethodResponse> on(MethodRequest methodRequest, object userContext)
            {

                try
                {
                    int pin = 18;
                    using var controller = new GpioController();
                    controller.OpenPin(pin, PinMode.Output);



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




            // Led lys AV
            static Task<MethodResponse> off(MethodRequest methodRequest, object userContext)
            {

                try
                {
                    int pin = 18;
                    using var controller = new GpioController();
                    controller.OpenPin(pin, PinMode.Output);



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
                  Microsoft.Azure.Devices.Client.TransportType.Mqtt);

                // setup callback for "reboot" method
                Client.SetMethodHandlerAsync("on", on, null).Wait(); //Definer hva vi må sende i consolen fra skya
                Client.SetMethodHandlerAsync("off", off, null).Wait();
                Console.WriteLine("Waiting for reboot method\nPress enter to exit.");
                Console.ReadLine();     // Denne gjør det mulig og vente på kommander fra skyen om led av/på
                Console.WriteLine();




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




            try
            {
                // Btn åpen RP
                while (true)
                {

                    string read = Console.ReadLine();
                    registryManager = RegistryManager.CreateFromConnectionString(connString);
                    //if (read == "a")
                    //{

                    //}
                    //else
                    //{
                    //    BtnPush().Wait();
                    //}

                    const int Pin = 21;
                    const string Alert = "ALERT 🚨";
                    const string Ready = "READY ✅";




                    using var controller = new GpioController();
                    controller.OpenPin(Pin, PinMode.InputPullUp);
                    //Her må vi legge inn logikk for knappen 
                    if (controller.Read(Pin) == PinValue.High)
                    {

                    }
                    else
                    {
                        BtnPush().Wait();

                    }


                    controller.RegisterCallbackForPinValueChangedEvent(
                        Pin,
                        PinEventTypes.Falling | PinEventTypes.Rising,
                        OnPinEvent);


                    System.Threading.Thread.Sleep(500);



                    static void OnPinEvent(object sender, PinValueChangedEventArgs args)
                    {

                    }
                }

                
            }
            catch (Exception)
            {

                throw;
            }


            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();

        }



    }
}
