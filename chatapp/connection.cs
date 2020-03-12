using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Threading.Tasks;

namespace chatapp
{
    class connection
    {
        Form1 fr;
       
        public connection(Form1 a) { this.fr = a; }
       public  List<string> a = new List<string>();
        static string BrokerAddress = "broker.mqttdashboard.com";// "test.mosquitto.org";

        MqttClient client = new MqttClient(BrokerAddress);

         public void connect(string username)
        {

            client.Connect(Guid.NewGuid().ToString());
            Console.WriteLine("connect to server");

        }

        public void send_msg(string to, string msg)
        {
            client.Publish(to, Encoding.UTF8.GetBytes(msg), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            Console.WriteLine(client.ClientId);

        }
        public void wait_msg(string from)
        {
             client.Subscribe(new string[] { from }, new byte[] { 2 });
           client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            Console.WriteLine(client.ClientId);
       
           
        }

        public void deconnect()
        {
            client.Disconnect();
        }

        // this code runs when a message was received
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            if (e.Topic.Equals("list")) {

                fr.Invoke( fr.myDelegate, new object[] { ReceivedMessage});
                //  this.fr.Invoke(delegate  {
             //   fr.listView1.Items.Add(ReceivedMessage);
                //}) ;
               // fr.listView1.Update();
                }
            Console.WriteLine(ReceivedMessage + " hhhhhhhhhh ");
            
           

        }
    }
}
