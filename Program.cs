// C# program for reversal algorithm 
// of array rotation 
using SimpleEncrDecr;
using System;
using System.Diagnostics;

class GFG
{
    /* Function to left rotate arr[] 
	of size n by d */
    static int[] leftRotate(int[] arr, int d)
    {

        if (d == 0)
            return arr;
        int n = arr.Length;
        // in case the rotating factor is 
        // greater than array length 
        d = d % n;

        int[] result = new int[n];

        int j = 0;
        for (int i = d; i < n; i++)
        {
            result[j++] = arr[i];
        }

        for (int i = 0; i < d; i++)
        {
            result[j++] = arr[i];
        }

        return result;
        //      reverseArray(arr, 0, d - 1);
        //      reverseArray(arr, d, n - 1);
        //      reverseArray(arr, 0, n - 1);
        //return arr;
    }

    /* Function to reverse arr[] from 
	index start to end*/
    static void reverseArray(int[] arr, int start,
                            int end)
    {
        int temp;
        while (start < end)
        {
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    /*UTILITY FUNCTIONS*/
    /* function to print an array */
    static void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }

    // Driver code 
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int d = 4;
        Stopwatch t = new Stopwatch();
        t.Start();
        // Rotate array by 2 
        printArray(leftRotate(arr, d));
        t.Stop();
        Console.WriteLine("\ntotal time:");
        Console.WriteLine(t.ElapsedMilliseconds);

        string sample = "Hello World!";
        string encrText = Cryptographer.EncryptText(sample);
        Console.WriteLine(encrText);
        Console.WriteLine(Cryptographer.DecryptText(encrText));
    }
}
