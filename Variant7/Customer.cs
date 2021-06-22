using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant7
{
    [Serializable]
    public class Customer
    {
        public string name;
        public string topic;
        public int price;

        public Customer()
        {
            this.name = "noname";
            this.topic = "noname";
            this.price = 0;
        }

        public void SetCustomer(string name, string topic, int price)
        {
            this.name = name;
            this.topic = topic;
            this.price = price;
        }

        public Customer(string name, string topic, int price)
        {
            this.name = name;
            this.topic = topic;
            this.price = price;
        }

        public string GetTopic() {
            return topic;
        }
    }
}
