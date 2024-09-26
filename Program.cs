namespace _62._Unique_Paths
{
    internal class Program
    {



        #region brute force but goes to TLE.
        //public static void Main(string[] args)
        //{
        //    int m = 3;
        //    int n = 2;
        //    int k = UniquePaths(m, n);
        //}

        //public static int UniquePaths(int m, int n)
        //{
        //    return CountPath(0, 0, m, n);
        //}

        //public static int CountPath(int i, int j, int m, int n)
        //{
        //    if (i >= n || j >= m)
        //    {
        //        return 0; //out of value in  m or n
        //    }
        //    if (i == n - 1 && j == m - 1) //last element return 1
        //    {
        //        return 1;
        //    }
        //    else return CountPath(i + 1, j, m, n) + CountPath(i, j + 1, m, n);
        //} 
        #endregion


        public static int CountPaths(int i, int j, int m, int n, int[,] matrix)
        {
            if (i == (n - 1) && j == (m - 1))
            {
                return 1;
            }
            if (i >= n || j >= m)
            {
                return 0;
            }
            if (matrix[i, j] != -1)
            {
                return matrix[i, j];
            }
            else
            {
                matrix[i, j] = CountPaths(i + 1, j, m, n, matrix) + CountPaths(i, j + 1, m, n, matrix);
                return matrix[i, j];
            }
        }

        public static int UniquePaths(int m, int n)
        {
            int[,] matrix = new int[m+1, n+1];
            for (int i = 0; i < m+1; i++)
            {
                for (int j = 0; j < n+1; j++)
                {
                    matrix[i, j] = -1;
                }
            }

            int num = CountPaths(0, 0, m, n, matrix);
            if (m == 1 && n == 1)
            {
                return num;
            }
            return matrix[0, 0];
        }

        public static void Main(string[] args)
        {

            int totalCount = UniquePaths(3, 2);
            Console.WriteLine("The total number of Unique Paths are " + totalCount);
        }


    }
}
