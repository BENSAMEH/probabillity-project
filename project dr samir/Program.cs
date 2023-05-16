using System;

namespace project_dr_samir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of items:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the Values of the items:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Value of item {0} ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);

            double median1;
            if (n % 2 == 0)
            {
                median1 = (arr[(n / 2) - 1] + arr[n / 2]) / 2.0;
            }
            else
            {
                median1 = arr[(n - 1) / 2];
            }
            Console.WriteLine("---------------");

            Console.WriteLine("The median value is: " + median1);
            Console.WriteLine("---------------");
            Console.WriteLine("The range is: " + (arr[arr.Length - 1] - arr[0]));
            Console.WriteLine("---------------");

            int mode, max, count;
            int number;
            mode = 0;
            max = 0;
            for (int i = 0; i < n; i++)
            {
                number = arr[i];
                count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (number == arr[j])
                    {
                        count++;
                    }
                    if (count > max)
                    {
                        max = count;
                        number = arr[j];
                            
                        if (max == 1)
                        {
                            Console.WriteLine("There is no mode");
                        } 
						
                        else
                        {
                            mode = number;
                            Console.WriteLine("mode is :" + mode);
                        }
                        
                        
                    }
                   
                }
            }
          
            Console.WriteLine("---------------");


            double k1 = ((n) * .25);

            double quartile1;
            if ((k1) == Math.Floor(((n) * .25)))
            {
                int intQ1 = (int)(k1 - 1);
                quartile1 = arr[intQ1];

            }
            else
            {
                int uQ1;
                uQ1 = (int)Math.Round(k1 - 1);
                quartile1 = arr[uQ1];

            }
            double k3 = ((n) * .75);
            double quartile3;
            if (k3 == Math.Floor(((n) * .75)))
            {

                int intQ3 = (int)(k3 - 1);
                quartile3 = arr[intQ3];

            }
            else
            {
                int uQ3 = (int)Math.Round(k3 - 1);

                quartile3 = arr[uQ3];

            }
            Console.WriteLine("The Q1 is :" + quartile1);
            Console.WriteLine("---------------");
            Console.WriteLine("The Q3 is :" + quartile3);
            Console.WriteLine("---------------");


            double Interquartile = quartile3 - quartile1;
            Console.WriteLine("The Interquartile Range is : " + Interquartile);
            Console.WriteLine("---------------");
            double f = n * .9;
            int P90;
            if (f == Math.Floor(n * .9))
            {
                P90 = ((arr[(int)f]) + (arr[(int)f - 1]) / 2);
            }
            else
            {
                P90 = arr[((int)Math.Round(f)) - 1];

            }
            Console.WriteLine("The P90 is :" + P90);
            Console.WriteLine("---------------");
            double lowerBound = quartile1 - 1.5 * Interquartile;
            double upperBound = quartile3 + 1.5 * Interquartile;
            Console.WriteLine("the lowerOutlierBoundary is : " + lowerBound);
            Console.WriteLine("---------------");
            Console.WriteLine("the upperOutlierBoundary is : " + upperBound);
            Console.WriteLine("---------------");
            Console.WriteLine("Enter a value to check if it's an outlier:");
            Console.WriteLine("---------------");

            Console.Write("Enter a value to check if it is an outlier: ");
            double value = double.Parse(Console.ReadLine());


            bool isOutlier = value < lowerBound || value > upperBound;


            if (isOutlier)
            {
                Console.WriteLine("The value {0} is an outlier.", value);
            }
            else
            {
                Console.WriteLine("The value {0} is not an outlier.", value);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("--------Ahmed Sameh-------");


        }
        
     }  
   }     
            
            

              
        
       
    
