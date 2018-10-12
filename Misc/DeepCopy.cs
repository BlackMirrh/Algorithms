using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    [Serializable]
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    [Serializable]
    public class Employee:ICloneable
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }

        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if(this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    return formatter.Deserialize(stream);
                }
                return null;
            }
        }
    }

    public class DeepCopy
    {
    }
}
