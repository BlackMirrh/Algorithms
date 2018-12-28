using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class DeliveryDistance
    {
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public List<List<int>> ClosestXdestinations(int numDestinations,
                                                    int[,] allLocations,
                                                    int numDeliveries)
        {
            List<List<int>> coordinates = new List<List<int>>();

            Dictionary<double, List<int>> distances = new Dictionary<double, List<int>>();

            Point a = new Point();
            a.x = 0;
            a.y = 0;

            for (int i = 0; i < numDestinations; i++)
            { 
                Point b = new Point();
                b.x = allLocations[i, 0];
                b.y = allLocations[i, 1];
                List<int> curLocation = new List<int>();
                curLocation.Add(b.x);
                curLocation.Add(b.y);
                double dist = distance(a, b);
                distances.Add(dist, curLocation);
            }

            int delivery = 1;
            foreach(var item in distances.OrderBy(k => k.Key))
            {
                if(delivery <= numDeliveries)
                {
                    coordinates.Add(item.Value);
                }
                delivery++;
            }

            return coordinates;
        }
        // METHOD SIGNATURE ENDS

        double distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        struct Point
        {
            public int x, y;
        }
    }
}
