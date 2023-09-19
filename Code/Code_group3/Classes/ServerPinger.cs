using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

public class ServerPinger
{
    private string serverIpAddress;

    public ServerPinger(string ipAddress)
    {
        serverIpAddress = ipAddress;
    }

    public bool PingServer()
    {
        try
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(serverIpAddress);

            return (reply.Status == IPStatus.Success);
        }
        catch (Exception ex)
        {
            // Håndter feil her, for eksempel logg feilen eller returner false
            Console.WriteLine("Feil ved pinging av server: " + ex.Message);
            return false;
        }
    }
}
namespace Code_group3.Classes
{
    internal class ServerPinger
    {
    }
}
