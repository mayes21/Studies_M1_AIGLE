using System;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;


namespace RemotingSamples
{
    public class Serveur
    {
        public static int Main(String[] args)
        {

            TcpChannel chan1 = new TcpChannel(8089);

            ChannelServices.RegisterChannel(chan1, true);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloServer), "SayHello", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Appuyez sur <Entrée> pour sortir...");

            Console.ReadLine();

            return 0;
        }
    }
}
