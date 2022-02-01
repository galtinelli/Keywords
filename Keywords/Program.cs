using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //break
            //continue
            //return anahar kelimeleri ne işe yarar?

            //BREAK KOMUTU
            //Break,genel anlamda döngü ya da switch koşulunun scope’u dışına çıkmamızı sağlar.
            //Break komutu döngü blogları ve switch kontrolünden başka yerde kullanamayız.


            //ÖRNEK

            for (int i = 0; i < 5; i++)
            {

                if (i == 3)
                {
                    break;
                }

                Console.WriteLine(i);

            }

            //Bu kodda i 3 olana kadar i sayısını yazdırır. i 3 olduğunda döngüden çıkar. Aslında for döngüsü i 5 olana kadar tekrar etmesi için tasarlanmıştır. Fakat break komutu buna izin vermemektedir.



            //CONTINUE

            //Continue komutu belirlediğimiz koşula göre döngünün akışını değiştirerek bir sonraki adıma geçmek için kullanılır. 

            //ÖRNEK

            for (int i = 0; i < 5; i++)
            {

                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine(i);

            }
            //Bu kodda i 3 olunca sonraki adıma geçmesi için yazılmıştır. Yani for döngüsü sanki 3 yokmuş gibi işlem yapacaktır. i değerleri 0124 olacaktır.

            //RETURN

            //return anahtar sözcüğü metotlarda belirlenen veri tipine göre değer döndürmesini sağlar.return deyimi kod satırında geriye döndürür ve kodun ileriki satırlara ilerlemesini engeller. Ayrıca isteğe bağlı olarak geriye bir değer de döndürebilir.

            //Kod akışı return deyimi ile hangi metot ve değerler ile çalışmaya devam edeceğini belirler.

           //ORNEK
                var result = Gather(5, 7);
                Console.WriteLine("Toplam: " + result);

                Console.ReadLine();
            }

            public static int Gather(int a, int b)
            {
                return a + b;
            }

        //Bu kodda Gather metodunda iki değer döndürülmesini sağlayarak ve main metodunun içerisinde değer atanarak toplama işleminin yapılması sağlanmış olur.
        }

    }
    
