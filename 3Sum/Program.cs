IList<IList<int>> ThreeSum(int[] nums)
{
    List<IList<int>> result = new List<IList<int>>();

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            for (int k = j + 1; k < nums.Length; k++)
            {
                if (nums[i] + nums[j] + nums[k] == 0)
                {
                    List<int> list = new List<int>();
                    list.Add(nums[i]);
                    list.Add(nums[j]);
                    list.Add(nums[k]);

                    list.Sort();

                    result.Add(list);
                }
            }
        }
    }

   
    result = result.Distinct().ToList();

    return result;
}

int[] nums = { -1, 0, 1, 2, -1, -4 };
ThreeSum(nums);