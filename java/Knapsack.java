import java.io.*;
import java.util.Scanner;

class Knapsack
{
 
    static int max(int x, int y)
    { return (x > y)? x : y; }
      
 
    static int knapSack(int W, int wt[], int val[], int n)
    {
         int i, w;
     int ks[][] = new int[n+1][W+1];
      
 
     for (i = 0; i <= n; i++)
     {
         for (w = 0; w <= W; w++)
         {
             if (i==0 || w==0)
                  ks[i][w] = 0;
             else if (wt[i-1] <= w)
                   ks[i][w] = max(val[i-1] + ks[i-1][w-wt[i-1]],  ks[i-1][w]);
             else
                   ks[i][w] = ks[i-1][w];
         }
      }
      return ks[n][W];
    }
 
    public static void main(String args[])
    {
    	int W, n;
    	Scanner sc = new Scanner(System.in);

    	System.out.println("Enter the Weight and no. of items");
    	W = sc.nextInt();
    	n = sc.nextInt();
    	System.out.println("Enter the Weights of items");
    	int wt[] = new int[n]; int val[] = new int[n];
    	for(int x = 0; x<n; x++)
    	{
    		wt[x] = sc.nextInt();
    	}
    	System.out.println("Enter the value of items");
    	for(int x = 0; x<n; x++)
    	{
    		val[x] = sc.nextInt();
    	}

    System.out.println(knapSack(W, wt, val, n));
    }
}