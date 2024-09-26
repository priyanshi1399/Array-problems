namespace MajorityElementnby2Times
{
    internal class Program
    {

        #region BruteForce
        //public static int majorityElement(int[] arr)
        //{
        //    Dictionary<int, int> d1 = new Dictionary<int, int>();
        //    int n = arr.Length;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (d1.ContainsKey(arr[i]))
        //        {
        //            d1[arr[i]]++;
        //        }
        //        else
        //        {
        //            d1[arr[i]] = 1;
        //        }
        //    }

        //    foreach (KeyValuePair<int, int> entry in d1)
        //    {
        //        if (entry.Value > n / 2)
        //        {
        //            return entry.Key;
        //        }
        //    }
        //    return -1;

        //}

        //static void Main(string[] args)
        //{
        //    int[] arr = { 2, 2, 1, 1, 1, 2, 2 };
        //    int ans = majorityElement(arr);

        //} 
        #endregion




        public static int majorityElement(int[] arr)
        {
            int n = arr.Length;
            int cnt = 0;
            int ele = 0;


            for (int i = 0; i < n; i++)
            {
                if (cnt == 0)
                {
                    cnt = 1;
                    ele = arr[i];
                }
                else if (ele == arr[i])
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                }
            }

            //checking if element stored id the majority element

            int cnt1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == ele)
                {
                    cnt1++;
                }
            }
            if (cnt1 > (n / 2))
            {
                return ele;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 2, 1, 1, 1, 2, 2 };
            int ans = majorityElement(arr);

        }


    }
}
