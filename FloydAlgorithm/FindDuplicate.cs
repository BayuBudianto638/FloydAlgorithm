using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydAlgorithm
{
    public class FindDuplicate
    {
        public static int findDuplicate(int[] nums)
        {
            var nilai_1 = nums[0];
            var nilai_2 = nums[0];

            while (true)
            {
                nilai_1 = nums[nilai_1];
                nilai_2 = nums[nums[nilai_2]];

                if (nilai_1 == nilai_2)
                    break;
            }

            var ptr1 = nums[0];
            var ptr2 = nilai_1;

            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }

            return ptr1;
        }

        public static int findDuplicateLinq(int[] nums)
        {
            var qryDuplicate = nums.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y)
              .ToList();

            var ret = qryDuplicate.FirstOrDefault();

            return ret.ElementAt(0);
        }
    }    
}
