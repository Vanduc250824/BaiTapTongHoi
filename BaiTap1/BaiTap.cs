using System.Text;

namespace BaiTapTongHop
{
    class BaiTap
    {
        public static bool Checks(int x, int y)
        {
            return x == y;

        }

        public void Bai1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            Console.WriteLine("Kết quả là: " + tong);

        }
        public void Bai2()
        {
            int dem = 0;
            string chuoi = Console.ReadLine();
            if (chuoi != null)
            {
                for (int i = 0; i < chuoi.Length; i++)
                {

                    if (chuoi[i] != ' ' && chuoi[i] != ',')
                    {
                        dem++;
                    }
                }
            }
            Console.WriteLine(dem);

        }
        public void Bai3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int max = 0;
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[max] < a[i])
                {
                    a[max] = a[i];
                }
            }
            Console.WriteLine("Giá trị lớn nhất: " + a[max]);
        }
        public void Bai4()
        {
            string chuoi = Console.ReadLine();
            char[] changes = chuoi.ToCharArray();
            Array.Reverse(changes);
            string newArray = new string(changes);
            Console.WriteLine(newArray);

        }
        public void Bai5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int hello = 0;
            for (int i = 0; i < n / 2; i++)
            {
                if (!Checks(a[i], a[n - i - 1]))
                {
                    hello = 1;
                    break;
                }
            }
            if (hello == 0)
            {
                Console.WriteLine("Đây là mảng đối xứng");
            }
            else
            {
                Console.WriteLine("Không phải là mảng đối xứng");
            }

        }
        public void Bai6()
        {
            string chuoi = Console.ReadLine();
            char[] array = chuoi.ToCharArray();
            char n = Convert.ToChar(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    dem++;
                }
            }
            Console.WriteLine($"So luon cua {n}: " + dem);
        }
    }

}
