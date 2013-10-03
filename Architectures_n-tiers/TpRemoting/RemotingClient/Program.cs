using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace RemotingSamples
{
    public class Client
    {
        public bool init = false;
        public static Thread thread1 = null;
        public static Thread thread2 = null;

        public static int Main(String[] args)
        {
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan, true);

            Client cl = new Client();

            thread1 = new Thread(new ThreadStart(cl.RunMe));
            thread2 = new Thread(new ThreadStart(cl.RunMe));

            thread1.Start();
            thread2.Start();

            Console.Read();

            return 0;
        }

        public void RunMe()
        {
            if (Thread.CurrentThread == thread1)
            {
                Console.WriteLine("Ceci est le Thread 1.");
                HelloServer obj = (HelloServer)Activator.GetObject(typeof(HelloServer), "tcp://localhost:8089/SayHello");

                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(obj.CountMe() + " depuis le Thread 1.");
                    Thread.Sleep(0);
                }
            }
            else if (Thread.CurrentThread == thread2)
            {
                Console.WriteLine("Ceci est le Thread 2.");
                HelloServer obj = (HelloServer)Activator.GetObject(typeof(HelloServer), "tcp://localhost:8089/SayHello");

                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(obj.CountMe() + " depuis le Thread 2.");
                    Thread.Sleep(0);
                }
            }
        }


    }
}
