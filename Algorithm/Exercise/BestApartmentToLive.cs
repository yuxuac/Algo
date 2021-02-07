using System.Collections.Generic;
using System.Linq;

namespace Algo.Algorithm.Exercise
{
    /*
    [
        {
            "gym": false,     1
            "school": true,   0
            "store": false    4
        },
        {
            "gym": true,      0
            "school": false,  1
            "store": false    3
        },
        {
            "gym": true,      0
            "school": true,   0
            "store": false    2
        },
        {
            "gym": false,     1
            "school": true,   0
            "store": false    1
        },
        {
            "gym": false,     2
            "school": true,   0
            "store": true     0
        }
    ]

    input = ["gym", "school", "store"]

    input = [0, 1, 2]

    output = 3

    */
    // TODO:
    public class BestApartmentToLive
    {
        /*
        010
        100
        110
        010
        011

        111
        */

        //private HashSet<ApartmentProperty> data = new HashSet<ApartmentProperty>();
        List<Dictionary<string, bool>> data = new List<Dictionary<string, bool>>();

        public static int Find(List<Dictionary<string, bool>> data, string[] input)
        {
            int resultIndex = -1;
            int resultVal = -1;
            // For each apartment
            for (int i = 0; i < data.Count; i++)
            {
                int maxLength = -1;
                // For each item, find the longest distance among items
                foreach (var item in input)
                {
                    int currentItemDistance = -1;

                    for (int jr = i, jl = i; jl >= 0 || jr < data.Count; jr++, jl--)
                    {
                        if (jl < 0) jl = 0;
                        if (jr > data.Count - 1) jr = data.Count - 1;

                        // Found it
                        if (data[jr][item] == true && data[jl][item] == true)
                        {
                            currentItemDistance = (i - jl) <= (jr - i) ? (i - jl) : (jr - i);
                            break;
                        }
                        else if (data[jr][item] == true)
                        {
                            currentItemDistance = (jr - i);
                            break;
                        }
                        else if (data[jl][item] == true)
                        {
                            currentItemDistance = (i - jl);
                            break;
                        }
                    }

                    if (currentItemDistance == -1)
                        currentItemDistance = int.MaxValue;

                    if (maxLength < currentItemDistance)
                        maxLength = currentItemDistance;
                }
                if (maxLength == -1)
                    maxLength = int.MaxValue;

                if (i == 0)
                {
                    resultVal = maxLength;
                    resultIndex = 0;
                }
                else
                {
                    if (resultVal > maxLength)
                    {
                        resultVal = maxLength;
                        resultIndex = i;
                    }
                }
            }
            return resultIndex;
        }
    }


    public class ApartmentProperty
    {
        public bool gym { get; set; }
        public bool school { get; set; }
        public bool store { get; set; }
    }


}