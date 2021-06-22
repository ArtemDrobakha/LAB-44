using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Variant7
{
    [Serializable]
    public class Research //: IXmlSerializable
    {
        public Customer customer;
        public DateTime date;
        public List<Publication> list = new List<Publication>();
        public void AddPublication(Publication p)
        {
            list.Add(p);
        }
        public void AddDate(DateTime d)
        {
            date = d;
        }
        public void AddCustomer(Customer c) {
            customer = c;
        }
        public override string ToString()
        {
            string r = customer.GetTopic() + ":  " + date.ToShortDateString() + "\n";
            foreach (var item in list)
            {
                r += item + "\n";
            }
            return r;
        }
        public string ToShortString()
        {
            return customer.GetTopic() + ":  " + list.Count;
        }

        //public XmlSchema GetSchema()
        //{
        //    throw new NotImplementedException();
        //}

        //public void ReadXml(XmlReader reader)
        //{
        //    customer = reader.ReadString();
        //}

        //public void WriteXml(XmlWriter writer)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
