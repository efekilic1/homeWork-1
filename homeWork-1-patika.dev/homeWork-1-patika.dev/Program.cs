using System;

namespace homeWork1patika.dev
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            example1();
            example2();
            example3();
            example4();




        }



        public static void example1()
        {
            Console.WriteLine("*_*_* Example 1 *_*_*");
        Flag:
            Console.WriteLine("Enter a positive number:");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                int[] array = new int[num];

                

                Console.WriteLine("Enter " + num + " positive numbers.");

                for (int i = 0; i < num; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                int count = 0;
                foreach (var a in array)
                {
                    
                    if (a % 2 == 0)
                    {
                        Console.Write(a + " ");
                        count++;
                    }
                    

                }
                if(count == 0)
                {
                    Console.WriteLine("There is no even number:");
                }
            }
            else
            {
                Console.WriteLine("Error-5" +
                    "Please enter a positive number:");
                goto Flag;
            }
        }


        public static void example2()
        {
            Console.WriteLine("*_*_* Example 2 *_*_*");
            Console.WriteLine("Enter two positive number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter "+n+" positive number:");

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(var a in array)
            {
                if (a % m == 0)
                {
                 Console.Write(a+" ");
                }
            }


        }


        public static void example3()
        {
            Console.WriteLine("*_*_* Example-3 *_*_*");
            Console.WriteLine("Enter a positive number:");

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter "+ num+ " words");

            string[] array = new string[num];

            for (int i = 0; i < num; i++)
            {
                array[i] = Console.ReadLine();
            }


            Console.WriteLine();
            int count = num - 1;
            while (count >= 0)
            {
                Console.Write(array[count]+" ");
                count--;
            }






        }

        public static void example4()
        {
            string str;
            Console.WriteLine("*_*_* Example 4 *_*_*");
            Console.WriteLine("Enter a sentence:");
u            str = Console.ReadLine();

            char[] charArray = str.ToCharArray();

            

            int len = charArray.Length-1;
            int space = 0;

            while (len >= 0)
            {
                if(charArray[len] == 32)
                {
                    space++;
                }

                len--;

            }
            int word = space + 1;
            
            int letter = charArray.Length - space;
            Console.WriteLine("number of letters:  " + letter+" ... word count: "+ word);


            
            





        }



    }



}
