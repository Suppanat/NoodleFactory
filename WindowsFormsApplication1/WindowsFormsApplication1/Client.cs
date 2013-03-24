using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Lidgren.Network;
using System.Threading;

namespace WindowsFormsApplication1
{
    class Client
    {
        NetClient netClient;
        MyNetWorker NetWorker;
        Form1 form;

        public Client(Form1 f)
        {
            form=f;
        }

        public void Connect()
        {

            var config = new NetPeerConfiguration("test")
            {
                //SimulatedMinimumLatency = 0.2f, 
                //SimulatedLoss = 0.1f
            };

            config.EnableMessageType(NetIncomingMessageType.WarningMessage);
            config.EnableMessageType(NetIncomingMessageType.VerboseDebugMessage);
            config.EnableMessageType(NetIncomingMessageType.ErrorMessage);
            config.EnableMessageType(NetIncomingMessageType.DiscoveryRequest);
            config.EnableMessageType(NetIncomingMessageType.DiscoveryResponse);
            config.EnableMessageType(NetIncomingMessageType.Error);
            config.EnableMessageType(NetIncomingMessageType.DebugMessage);
            config.EnableMessageType(NetIncomingMessageType.UnconnectedData);
            config.EnableMessageType(NetIncomingMessageType.ConnectionApproval);

            netClient = new NetClient(config);
            netClient.Start();

            netClient.Connect(new IPEndPoint(NetUtility.Resolve("192.168.182.57"), Convert.ToInt32("14242")));

           NetWorker = new MyNetWorker(netClient,form);
           Thread NetThread = new Thread(NetWorker.ProcessNet);
           NetThread.Start();
        }

       public void SendMessage(string message)
        {
            if (netClient.Connections == null || netClient.Connections.Count == 0)
            {
                Console.WriteLine("No connections to send to.");
                return;
            }
            NetOutgoingMessage msg = netClient.CreateMessage();
            //msg.Write((int)MessageType.StringMessage);
            msg.Write(message);
            netClient.SendMessage(msg, netClient.Connections, NetDeliveryMethod.ReliableOrdered, 0);
        }


        
   
    }
}
