using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ikiz_asallar

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("bu kod 0-100 e kadar olan ikiz asalları gösterecektir herhangi bir tuşa basarak kodu çalıştırabilirsiniz");

            Console.ReadKey();

            Console.Clear();

            //buradan üstü kodun amacını açıklar

            for (int i = 3; i < 100; i++)

            //for döngüsü i eğer 100 den küçükse birer birer arttırır

            {



                if ((i % 2 == 0 && i > 2) || (i % 3 == 0 && i > 3) || (i % 5 == 0 && i > 5) || (i % 7 == 0 && i > 7))

                //buradaki if i sayısının asal olup olmadığını anlamasını sağlar asal ise else deki komudu çalıştırır

                { }



                else

                {

                    if (((i + 2) % 2 == 0 && i > 2) || ((i + 2) % 3 == 0 && i > 3) || ((i + 2) % 5 == 0 && i > 5) || ((i + 2) % 7 == 0 && i > 7))

                    //burada ise i + 2 ifadesinin asal olup olmadığını anlar asal ise elsedeki komudu çalıştırır

                    {



                    }

                    else

                        Console.WriteLine(i + "-" + (i + 2));

                    //burda eğer iki if ifadesinede uygunsa ekrana 'i' ile 'i + 2' ifadelerini yazar 

                }

            }

            Console.ReadKey();

            //klavyeden herhangi bir tuşa basılmasını bekler

        }

    }

}

