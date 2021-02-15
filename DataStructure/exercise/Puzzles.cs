using System.Collections.Generic;

namespace Algo.Exercise
{
    public class Puzzles
    {
		/*
		array1: [-1， 3， 8， 2， 9， 5]
		array2: [4， 1， 2， 10， 5， 20]
		sum = 24
		=》
		(5, 20), (3, 20)
		*/
		
		public static List<int[]> GetClosestPairOfSum(int[] array1, int[] array2, int sum)
		{
			List<int[]> result = new List<int[]>();
			
			// O(n)
			// 1. Add array1 to the hash set.
			HashSet<int> hs = new HashSet<int>();
			for(int i = 0; i < array1.Length; i++)
			{
				hs.Add(array1[i]);
			}
			
			int offset = 0;
			// O(sum * n)
			while(offset <= sum)
			{
				for(int i = 0; i < array2.Length; i++)
				{
					if(hs.Contains(sum - array2[i] + offset))
					{
						result.Add(new int[]{sum - array2[i] + offset, array2[i]});
					}
					if (hs.Contains(sum - array2[i] - offset))
					{
						result.Add(new int[]{sum - array2[i] - offset, array2[i]});
					}
				}
				if(result != null && result.Count > 0)
					break;
				offset++;
			}
			return result;
		}
	}
}