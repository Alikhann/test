using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
            public static List<int>[] sleeve = new List<int>[12];
            public static List<int>[] skirt = new List<int>[9];
            public static List<int>[] neck = new List<int>[12];
            public static double[] probability = new double[sleeve.Length];
            public static double[] pro2 = new double[skirt.Length];
            public static double[] pro3 = new double[neck.Length];

            public static Random rand = new Random();
            public static double maxSleeve, maxSkirt, maxNeck;
        
        static void Main(string[] args)
        {
            #region sleeve data
            sleeve[0] = new List<int> { 0,0,0,0 };
            sleeve[1] = new List<int> { 0,0,0,1 };
            sleeve[2] = new List<int> { 0,0,1,0 };
            sleeve[3] = new List<int> { 0,0,1,1 };
            sleeve[4] = new List<int> { 0,1,0,0 };
            sleeve[5] = new List<int> { 0,1,0,1 };
            sleeve[6] = new List<int> { 0,1,1,0 };
            sleeve[7] = new List<int> { 0, 1, 1, 1 };
            sleeve[8] = new List<int> { 1,0,0,0};
            sleeve[9] = new List<int> { 1,0,0,1 };
            sleeve[10] = new List<int> { 1,0,1,0 };
            sleeve[11] = new List<int> { 1,0,1,1 };
            #endregion
            #region skirt data
            skirt[0] = new List<int> { 0, 0, 0, 0 };
            skirt[1] = new List<int> { 0, 0, 0, 1 };
            skirt[2] = new List<int> { 0, 0, 1, 0 };
            skirt[3] = new List<int> { 0, 0, 1, 1 };
            skirt[4] = new List<int> { 0, 1, 0, 0 };
            skirt[5] = new List<int> { 0, 1, 0, 1 };
            skirt[6] = new List<int> { 0, 1, 1, 0 };
            skirt[7] = new List<int> { 0, 1, 1, 1 };
            skirt[8] = new List<int> { 1, 0, 0, 0 };
            #endregion
            #region neck data
            neck[0] = new List<int> { 0, 0, 0, 0 };
            neck[1] = new List<int> { 0, 0, 0, 1 };
            neck[2] = new List<int> { 0, 0, 1, 0 };
            neck[3] = new List<int> { 0, 0, 1, 1 };
            neck[4] = new List<int> { 0, 1, 0, 0 };
            neck[5] = new List<int> { 0, 1, 0, 1 };
            neck[6] = new List<int> { 0, 1, 1, 0 };
            neck[7] = new List<int> { 0, 1, 1, 1 };
            neck[8] = new List<int> { 1, 0, 0, 0 };
            neck[9] = new List<int> { 1, 0, 0, 1 };
            neck[10] = new List<int> { 1, 0, 1, 0 };
            neck[11] = new List<int> { 1, 0, 1, 1 };
            #endregion
            
            for (int i = 0; i < probability.Length; i++)
            {
                probability[i] = rand.NextDouble() * 100;
                pro3[i] = rand.NextDouble() * 100;
                if (i < skirt.Length)
                    pro2[i] = rand.NextDouble() * 100;

                Console.WriteLine(probability[i] + " " + pro3[i]);
            }
            
            maxSleeve = probability.Max();
            maxSkirt = pro2.Max();
            maxNeck = pro3.Max();

            Console.ReadKey();
        }
        
        
    }
}
