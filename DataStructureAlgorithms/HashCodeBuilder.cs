using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public static class HashCodeBuilder
    {
        public static int ComputeHashForm(params object[] obj)
        {
            ulong res = 0;
            for(uint i =0; i < obj.Length; i++)
            {
                object val = obj[i];
                res += val == null ? i : (ulong)val.GetHashCode() * (1 + 2 * i);
            }
            return (int)(uint)(res ^ (res >> 32));
        }

    }
}
