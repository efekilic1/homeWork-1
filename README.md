# homeWork-1
Algoritma Soruları app.patika.dev


# Question-1

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

<img width="510" alt="Ekran Resmi 2022-05-21 16 46 58" src="https://user-images.githubusercontent.com/105243448/169655823-817d3bcd-ae03-4f83-afcf-a63561d90b7e.png">

<img width="527" alt="Ekran Resmi 2022-05-21 16 47 29" src="https://user-images.githubusercontent.com/105243448/169655830-c5f7cebd-8658-459e-a7d8-60e17c10d1aa.png">


# Question-2

Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


<img width="394" alt="Ekran Resmi 2022-05-21 16 49 01" src="https://user-images.githubusercontent.com/105243448/169655864-a4f1b7a4-bf94-4d0b-a21c-b46b6a16a0a7.png">

# Question-3

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

<img width="563" alt="Ekran Resmi 2022-05-21 16 50 06" src="https://user-images.githubusercontent.com/105243448/169655892-230a00f2-508c-4171-8796-8af0dd17a5c1.png">

# Question-4

Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
<img width="542" alt="Ekran Resmi 2022-05-21 16 53 53" src="https://user-images.githubusercontent.com/105243448/169655924-06862e2c-8250-4b5d-b232-7fbfefe829f6.png">




```

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


```


