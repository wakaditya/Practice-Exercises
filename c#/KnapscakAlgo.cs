using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

    public class KnapsackAlgo
    {

        public static int items = 0, result = 0, temp1 = 0, temp2 = 0;
        public static int capacity = 0;
    public static List<int> v = new List<int>(); public static List<int> w = new List<int>();
    //public static Dictionary<String, int> dic = new Dictionary<string, int>();

    public static void input_constraints()
        {   
            Console.WriteLine("Enter the number of items");
            items = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the capacity");
            capacity = Convert.ToInt32(Console.ReadLine());

        for (int z = 0; z < items; z++)
        { for (int p = 1; p <= capacity; p++)
            {
                dic.Add(System.String.Concat(z.ToString(),p.ToString()), -1);
            }
        }
        
            Console.WriteLine("Enter the weights");
        
            for (int i = 0; i < items; i++)
            {
            w.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Enter the values");
            for (int i = 0; i < items; i++)
            {
            v.Add(Convert.ToInt32(Console.ReadLine()));
        }
           
        }
    
    public static int KnapSack(int items, int capacity)
        {


        int n = items, C = capacity;

        if (dic[System.String.Concat(n.ToString(), C.ToString())] != -1)
        {
            return dic[System.String.Concat(n.ToString(), C.ToString())];
        }
            if (n == 0 || C == 0)
            { result = 0; }
            else if (w[n] > C)
            {
                result = KnapSack(n - 1, C);
            }
            else {
                temp1 = KnapSack(n - 1, C);
                temp2 = v[n] + KnapSack(n - 1, C - w[n]);
                result = Math.Max(temp1, temp2);
            }
        dic[System.String.Concat(n.ToString(), C.ToString())] = result;
            return result;
        }
        public static void Main()
        {
        input_constraints();
           int r = KnapSack(items-1, capacity);
        Console.WriteLine("Knapsack value is:");
          Console.WriteLine(r);
        }
    }
