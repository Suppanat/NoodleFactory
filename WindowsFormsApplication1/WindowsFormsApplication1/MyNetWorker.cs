using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Lidgren.Network;
using System.Threading;

namespace WindowsFormsApplication1
{
    public class MyNetWorker
    {
        NetClient peer = null;
        Form1 formthread = null;
        // NetManager netManager = null;
        public volatile bool shouldQuit = false;

        public MyNetWorker(NetClient inPeer, Form1 f)//,NetManager inNetManager) 
        {
            peer = inPeer;
            formthread = f;
            //netManager = inNetManager;
        }

        public void ProcessNet()
        {
            // read messages
            while (!shouldQuit)
            {
                Thread.Sleep(5);
                if (peer == null)
                    continue;
                NetIncomingMessage msg;
                while ((msg = peer.ReadMessage()) != null)
                {
                    Thread.Sleep(10);
                    switch (msg.MessageType)
                    {
                        case NetIncomingMessageType.DiscoveryRequest:
                            formthread.BeginInvoke((Action)(()=>formthread.setText("ReceivePeersData DiscoveryRequest")));
                            //peer.SendDiscoveryResponse(null, msg.SenderEndpoint);
                            break;
                        case NetIncomingMessageType.DiscoveryResponse:
                            // just connect to first server discovered
                            formthread.BeginInvoke((Action)(()=>formthread.setText("ReceivePeersData DiscoveryResponse CONNECT")));
                            //peer.Connect(msg.SenderEndpoint);
                            break;
                        case NetIncomingMessageType.ConnectionApproval:
                            formthread.BeginInvoke((Action)(()=>formthread.setText("ReceivePeersData ConnectionApproval")));
                            msg.SenderConnection.Approve();
                            //broadcast this to all connected clients
                            //msg.SenderEndpoint.Address, msg.SenderEndpoint.Port
                            //netManager.SendPeerInfo(msg.SenderEndpoint.Address, msg.SenderEndpoint.Port);
                            break;
                        case NetIncomingMessageType.Data:
                            //another client sent us data
                            formthread.BeginInvoke((Action)(()=>formthread.setText("BEGIN ReceivePeersData Data")));
                            String temp = msg.ReadString();
                            formthread.BeginInvoke((Action)(()=>formthread.setText(temp)));
                            //MessageType mType = (MessageType)msg.ReadInt32();
                            /*  if (mType == MessageType.StringMessage) {
                                  Console.WriteLine("Message received: " + msg.ReadString());
                              }
                              else if (mType == MessageType.PeerInformation) {
                                  Console.WriteLine("Data::PeerInfo BEGIN");
                                  int byteLenth = msg.ReadInt32();
                                  byte[] addressBytes = msg.ReadBytes(byteLenth);
                                  IPAddress ip = new IPAddress(addressBytes);
                                  int port = msg.ReadInt32();
                                  //connect
                                  IPEndPoint endPoint = new IPEndPoint(ip, port);
                                  Console.WriteLine("Data::PeerInfo::Detecting if we're connected");
                                  if (peer.GetConnection(endPoint) == null) {//are we already connected?
                                      //Don't try to connect to ourself!
                                      if (peer.Configuration.LocalAddress.GetHashCode() != endPoint.Address.GetHashCode()
                                              || peer.Configuration.Port.GetHashCode() != endPoint.Port.GetHashCode()) {
                                          Console.WriteLine(string.Format("Data::PeerInfo::Initiate new connection to: {0}:{1}",
                                              endPoint.Address.ToString(), endPoint.Port.ToString()));
                                          peer.Connect(endPoint);
                                      }
                                  }
                                  Console.WriteLine("Data::PeerInfo END");
                              }
                              Console.WriteLine("END ReceivePeersData Data");*/

                            break;
                        case NetIncomingMessageType.UnconnectedData:
                            string orphanData = msg.ReadString();
                            formthread.BeginInvoke((Action)(()=>formthread.setText("UnconnectedData: " + orphanData)));
                            break;
                        default:
                            //formthread.BeginInvoke((Action)(()=>formthread.setText("ReceivePeersData Unknown type: " + msg.MessageType.ToString())));
                            try
                            {
                                //formthread.BeginInvoke((Action)(()=>formthread.setText(msg.ReadString())));
                            }
                            catch
                            {
                                //formthread.BeginInvoke((Action)(()=>formthread.setText("Couldn't parse unknown to string.")));
                            }
                            break;
                    }
                }
            }
           // Console.WriteLine("Exiting net thread!");
        }
    }
}
