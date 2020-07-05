using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo28
{
    public class QueueBuffer
    {
        private Queue mBuffer;
        public QueueBuffer()
        {
            mBuffer = new Queue();
        }
        public void sendMessage(Messages msg)
        {
            //傳送進來的訊息存到集合
            mBuffer.Enqueue(msg);
        }

        public void receiveMessage()
        {
            //集合中的訊息傳遞出去
            Messages msg = (Messages)mBuffer.Dequeue();
            Console.WriteLine(msg.ToString());
        }
    }
    public class StackBuffer
    {
        private Stack mBuffer;
        public StackBuffer()
        {
            mBuffer = new Stack();
        }
        public void sendMessage(Messages msg)
        {
            //傳送進來的訊息存到集合
            mBuffer.Push(msg);
        }

        public void receiveMessage()
        {
            //集合中的訊息傳遞出去
            Messages msg = (Messages)mBuffer.Pop();
            Console.WriteLine(msg.ToString());
        }
    }
    public class Car
    {
        private int _no;//field
        private string _model;//field        
        public string Model {
            //property
            set
            {
                _model = value;
            }
        }
        public Car(int no, string model)
        {
            _no = no;
            _model = model;
        }

        public override string ToString()
        {
            return "NO:" + _no + "\tModel:" + _model;
        }
    }
    public class Messages
    {
        private string msgText;//field
        public Messages(string msg)
        {//constructor
            msgText = msg;
        }

        public override string ToString()
        {
            return msgText;
        }
    }
}
