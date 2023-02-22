using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace EbayScraperWPF
{
    internal class DataCommunicator
    {
        List<string> OUT_QUEUE = new List<string>();
        List<string> IN_QUEUE = new List<string>();
        DataSender PIPE_OUT = new DataSender();
        DataReciever PIPE_IN = new DataReciever();

        public void POPULATE_OUT_QUEUE(string data)
        {
            OUT_QUEUE.Add(data);
        }
        public void POPULATE_IN_QUEUE(string data)
        {
            IN_QUEUE.Add(data);
        }

        public void PIPE_OUT_QUEUE()
        {
            bool SUCCESS;
            foreach(string data in OUT_QUEUE)
            {
                PIPE_OUT.SendData(data);
                SUCCESS = checkData(PIPE_OUT.RecieveData());

                while(SUCCESS == false)
                {
                    Thread.Sleep(5);
                    PIPE_OUT.SendData(data);
                    SUCCESS = checkData(PIPE_OUT.RecieveData());
                }
            }
        }
        public void PIPE_IN_QUEUE(string message)
        {
            PIPE_IN.SendData(message);
            string inData = PIPE_IN.RecieveData();
            int j = 0;
            for(int i = 0; i>message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    inData = message.Substring(j,i-1);
                    IN_QUEUE.Add(inData);
                    j = i;
                }
                else if (message[i] == '\r')
                {
                    break;
                }
            }
        }
        public bool checkData(string data)
        {
            bool SUCCESS = false;
            if (data == "OK\r")
            {
                SUCCESS = true;
            }
            return SUCCESS;
        }
    }

    public class DataSender
    {
        public void SendData(string data)
        {
            using (var namedPipeStream =
                new NamedPipeServerStream("OUT_DataPipe", PipeDirection.InOut, 1, PipeTransmissionMode.Message))
            {
                namedPipeStream.WaitForConnection();

                byte[] messageBytes = Encoding.UTF8.GetBytes(data);
                namedPipeStream.Write(messageBytes, 0, messageBytes.Length);
            }
        }
        public string RecieveData()
        {
            string recievedData;
            using (var namedPipeClientStream = new NamedPipeClientStream(".", "OUT_DataPipe", PipeDirection.InOut))
            {
                namedPipeClientStream.Connect();
                namedPipeClientStream.ReadMode = PipeTransmissionMode.Message;
                StreamReader streamReader = new StreamReader(namedPipeClientStream);
                recievedData = streamReader.ReadToEnd();
            }
            return recievedData;
        }
    }

    public class DataReciever
    {
        public void SendData(string data)
        {
            using (var namedPipeStream =
                new NamedPipeServerStream("IN_DataPipe", PipeDirection.InOut, 1, PipeTransmissionMode.Message))
            {
                namedPipeStream.WaitForConnection();

                byte[] messageBytes = Encoding.UTF8.GetBytes(data);
                namedPipeStream.Write(messageBytes, 0, messageBytes.Length);
            }
        }
        public string RecieveData()
        {
            string recievedData;
            using (var namedPipeClientStream = new NamedPipeClientStream(".", "IN_DataPipe", PipeDirection.InOut))
            {
                namedPipeClientStream.Connect();
                namedPipeClientStream.ReadMode = PipeTransmissionMode.Message;
                StreamReader streamReader = new StreamReader(namedPipeClientStream);
                recievedData = streamReader.ReadToEnd();
                SendData("OK\r\n");
            }
            return recievedData;
        }
    }
}
