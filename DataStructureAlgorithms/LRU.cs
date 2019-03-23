using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public class LRU
    {
        private static readonly int SIZE = 5;
        private Dictionary<string, string> map = new Dictionary<string, string>();

        //private PriorityQueue<Element> pq = new PriorityQueue<Element>(SIZE, new Comparer()) {
        //});

    }

    public class Element
    {
        private string value;
        private DateTime timestamp;

        private string getValue()
        {
            return value;
        }

        public void setValue(string value)
        {
            this.value = value;
        }

        public DateTime getTimestamp()
        {
            return timestamp;
        }

        public void setTimestamp(DateTime timestamp)
        {
            this.timestamp = timestamp;
        }

        public bool equals(Element e)
        {
            return value.Equals(e.getValue());
        }

        public int hashCode()
        {
            return HashCodeBuilder.ComputeHashForm(value); 
        }
    }
}
