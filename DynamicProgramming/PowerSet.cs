using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class PowerSet
    {
        public List<List<int>> getSubsets(List<int> set, int index)
        {
            List<List<int>> allsubsets;

            if (set.Count == index)
            {
                allsubsets = new List<List<int>>();
                allsubsets.Add(new List<int>());
            }
            else
            {
                allsubsets = getSubsets(set, index + 1);
                int item = set[index];
                List<List<int>> moreSubsets = new List<List<int>>();

                foreach(var subset in allsubsets)
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(item);
                    moreSubsets.Add(newSubset);
                }
                allsubsets.AddRange(moreSubsets);
            }
            return allsubsets;
        }
    }
}
