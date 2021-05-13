using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    /*struct Test
    {
        public static int x;
        public static int y;
    }*/

   /* public struct newStruct
    {
        public int m, n;
       *//* public newStruct(int pt1, int pt2)
        {
            m = pt1;
            n = pt2;
        }*//*
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            // dao nguoc so
            /*int n, sum = 0, r;
            Console.Write("Nhap so nguyen bat ky: n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n /= 10;
            }
            Console.WriteLine(sum);*/


            /*int n;
            char letter = 'A';
            do
            {
                Console.Write("Nhap so luong chu cai can hien thi (theo bang chu cai Tieng Anh): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0 || n > 26)
                {
                    Console.WriteLine("Xin hay nhap dung va phu hop voi so luong chu cai trong bang chu cai Tieng Anh!");
                }
            } while (n <= 0 || n > 26);

            for (int i = 0; i < n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0} ", letter++);
                }
                Console.WriteLine();
            }*/

            /*int i, j, n, numberOfPrints = 1;
            char letter = 'A';

            Console.Write("Ve tam giac chu cai trong C#:\n");
            Console.Write("Nhap so chu cai (nho hon 26): ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                // in ra n chu cai dau tien
                for (j = 0; j <= (numberOfPrints / 2); j++)
                {
                    Console.Write("{0} ", letter++);
                }
                letter--;
                letter--;

                // in bu vao phan con thieu trong hang
                for (j = 0; j < (numberOfPrints / 2); j++)
                {
                    Console.Write("{0} ", letter--);
                }
                numberOfPrints += 2;
                letter = 'A';
                Console.WriteLine();
            }*/

            /*int firstNumber, secondNumber, uscln = 1, bscnn = 0;
            Console.Write("Nhap so thu nhat: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int minNumber = Math.Min(firstNumber, secondNumber);

            Console.WriteLine("Ta co ket qua sau: ");
            for (int i = 1; i <= minNumber; i++)
            {
                if (firstNumber % i == 0 && secondNumber % i == 0)
                {
                    uscln = i;
                    bscnn = (firstNumber * secondNumber) / uscln;
                }
            }
            Console.WriteLine("----->{0} la USCLN cua {1} va {2}", uscln, firstNumber, secondNumber);
            Console.WriteLine("----->{0} la BSCNN cua {1} va {2}", bscnn, firstNumber, secondNumber);*/

            /*int firstNumber, secondNumber, bscnn = 0;
            Console.Write("Nhap so thu nhat: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int maxNumber = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            for (int i = maxNumber; ; i += maxNumber)
            {
                if (i % firstNumber == 0 && i % secondNumber == 0)
                {
                    bscnn = i;
                    break;
                }
            }
            Console.WriteLine("----->{0} la BSCNN cua {1} va {2}", bscnn, firstNumber, secondNumber);*/


            /*int n, sum = 0, r, temp;
            Console.Write("Nhap mot so nguyen duong bat ky: ");
            n = temp = Convert.ToInt32(Console.ReadLine());
            while (temp != 0)
            {
                int factorial = 1;
                r = temp % 10;
                for (int i = 1; i <= r; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                temp /= 10;
            }
            if (sum == n)
            {
                Console.WriteLine("{0} la Strong Number", n);
            }
            else
            {
                Console.WriteLine("{0} khong phai la Strong Number", n);
            }*/

            /*int min, max, r, temp;
            Console.Write("Nhap so bat dau cua day: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ket thuc cua day: ");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i = min; i <= max; i++)
            {
                int sum = 0;
                temp = i;
                while (temp != 0)
                {
                    int factorial = 1;
                    r = temp % 10;
                    for (int j = 1; j <= r; j++)
                    {
                        factorial *= j;
                    }
                    sum += factorial;
                    temp /= 10;
                }

                if (sum == i)
                {
                    Console.Write("{0} ", i);
                }
            }*/


            /*int n;
            Console.Write("Nhap mot so nguyen duong bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                int count = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine();
                }
            }*/

            /*// chuyen doi nhi phan sang thap phan (phuong phap nhan doi) nhung chua hoan thien
            // 1011001 (2) = 89 (10)
            int n, temp, r, newNumber, sum = 0;
            string result = "";
            Console.Write("Nhap mot so bat ky trong he nhi phan: ");
            n = temp = Convert.ToInt32(Console.ReadLine());

            // tach so trong n
            while (temp != 0)
            {
                r = temp % 10;
                temp /= 10;
                result += r;
                
            }
            newNumber = Convert.ToInt32(result);

            // tach so trong newNumber
            for (int i = newNumber; i > 0; i /= 10)
            {
                r = i % 10;
                sum = sum * 2 + r;
            }
            *//*while (newNumber != 0)
            {
                r = newNumber % 10;
                sum = sum * 2 + r;
                newNumber /= 10;
            }*//*
            Console.WriteLine("So tuong ung trong he thap phan la {0}", sum);*/


            /*int n, r, p = 1, i = 1, dec = 0;
            
            Console.Write("Nhap mot so bat ky trong he nhi phan: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (int j = n; j > 0; j /= 10)
            {
                r = j % 10;

                if (i == 1)
                    p *= 1;
                else
                    p *= 2;

                dec = dec + (r * p);

                i++;
            }
            Console.Write("\nSo trong he nhi phan: {0}\nSo thap phan tuong duong la: {1} \n\n", n, dec);*/


            /*int n, r,sum = 0, i = 0;
            
            Console.Write("Nhap mot so bat ky trong he nhi phan: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                r = n % 10;
                sum = (int)(sum + (r * Math.Pow(2, i)));
                n /= 10;
                i++;
            }
            Console.WriteLine("So tuong ung trong he thap phan la {0}", sum);*/

            /*int height, width, halfHeight;
            Console.WriteLine("In chu so B:");
            Console.Write("Nhap chieu cao cua chu: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong cua chu: ");
            width = Convert.ToInt32(Console.ReadLine());
            halfHeight = height / 2;

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (j == 1 || ((i == 1 || i == height || i == halfHeight) && j != width) ||
                        ((i > 1 && i <= halfHeight - 1) || (i >= halfHeight + 1 && i <= height - 1)) && j == width)
                    {
                        Console.Write("* ");
                    } else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }*/

            /*int height, width, i, j;
            Console.WriteLine("In chu so C:");
            Console.Write("Nhap chieu cao (lon hon 4) cua chu: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong (lon hon 3) cua chu: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (i = 1; i <= height; i++)
            {
                for (j = 1; j <= width; j++)
                {
                    if (
                        (j == 1 && (i > 1 && i < height)) ||

                        ((i == 1 || i == height) && (j > 1 && j < width)) ||

                        ((i == 2 || i == height - 1) && j == width)
                       )
                    {
                        Console.Write("* ");
                    } else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }*/


            /*int height, width, row, col, i = 1, j;
            Console.WriteLine("In chu cai K:");
            Console.Write("Nhap chieu cao cua chu cai: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong (>= 3) cua chu cai: ");
            width = j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (row = 1; row <= height; row++)
            {
                for (col = 1; col <= width; col++)
                {
                    if (col == 1 || ((row == col + 2) && col != 1))
                    {
                        Console.Write("*");
                    } else if (row == i && col == j)
                    {
                        Console.Write("*");
                        i += 1;
                        j -= 1;
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }*/


            /*int height, width, row, col;
            Console.WriteLine("In chu cai O:");
            Console.Write("Nhap chieu cao cua chu cai: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong cua chu cai: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (row = 1; row <= height; row++)
            {
                for (col = 1; col <= width; col++)
                {
                    if (
                        (col == 1 || col == width) && (row > 1 && row < height) ||
                        ((row == 1 || row == height) && (col > 1 && col < width))
                       )
                    {
                        Console.Write("* ");
                    } else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }*/


            /*int n, i;
            Console.Write("Nhap so luong phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            // mang chua so lan xuat hien cua cac phan tu trong mang arr[] voi moc = 0
            // 100 tuong trung cho do rong (co the lay so khac mien la > n)
            int[] temp = new int[100];
            for (i = 0; i < 100; i++)
            {
                temp[i] = 0;
            }

            Console.WriteLine("Nhap gia tri cho cac phan tu cua mang:");
            for (i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                temp[arr[i]]++;
            }

            for (i = 0; i < 100; i++)
            {
                // tim so lan xuat hien cua cac phan tu trong mang arr[]
                if (temp[i] > 0)
                {
                    Console.WriteLine("Gia tri {0} xuat hien {1} lan", i, temp[i]);
                }

                // tim cac phan tu xuat hien 1 lan trong mang arr[]
                *//*if (temp[i] == 1)
                {
                    Console.WriteLine("Cac gia tri trong mang xuat hien 1 lan la: {0}", i);
                }*//*
            }*/


            /*int[] temp = new int[100];
            int n, i, j, count;

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                // danh dau tat ca cac phan tu bang -1
                temp[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                count = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        // thay doi danh dau cho cac so giong nhau
                        temp[j] = 0;
                    }
                }

                if (temp[i] != 0)
                {
                    temp[i] = count;
                }
            }
            Console.Write("\nTan suat xuat hien cua tung phan tu trong mang la: \n");
            for (i = 0; i < n; i++)
            {
                if (temp[i] != 0)
                {
                    Console.Write("So {0} xuat hien {1} lan\n", arr[i], temp[i]);
                }
            }*/


            /*int n1, n2, i, j;

            Console.Write("Nhap so luong phan tu cho mang thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n1];

            Console.WriteLine("Nhap gia tri cho mang thu nhat:");
            for (i = 0; i < n1; i++)
            {
                Console.Write("arr1[{0}] = ", i + 1);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("----------------------------------");

            Console.Write("Nhap so luong phan tu cho mang thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[n2];

            Console.WriteLine("Nhap gia tri cho mang thu hai:");
            for (i = 0; i < n2; i++)
            {
                Console.Write("arr2[{0}] = ", i + 1);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // thuc hien ket hop mang
            int n = n1 + n2;
            int[] combinedArr = new int[n];

            Console.WriteLine("Mang ket hop co dang nhu sau: ");
            for (i = 0; i < n1; i++)
            {
                combinedArr[i] = arr1[i];
            }

            for (j = 0; j < n2; j++)
            {
                combinedArr[i] = arr2[j];
                i++;
            }

            // thuc hien sap xep mang theo thu tu tang dan
            int temp;
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (combinedArr[i] > combinedArr[j])
                    {
                        temp = combinedArr[i];
                        combinedArr[i] = combinedArr[j];
                        combinedArr[j] = temp;
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", combinedArr[i]);
            }*/


            /*int n, i, temp, j;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Nhap {0} gia tri cho cac phan tu cua mang sau:", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            *//*int min = arr[0], max = arr[0], tempMin, tempMax;
            for (i = 1; i < n; i++)
            {
                if (min > arr[i])
                {
                    tempMin = min;
                    min = arr[i];
                    arr[i] = tempMin;
                }
                if (max < arr[i])
                {
                    tempMax = max;
                    max = arr[i];
                    arr[i] = tempMax;
                }
            }
            Console.WriteLine("Gia tri nho nhat trong mang la {0}", min);
            Console.WriteLine("Gia tri lon nhat trong mang la {0}", max);*//*

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Gia tri nho nhat trong mang la {0}", arr[0]);
            Console.WriteLine("Gia tri lon nhat trong mang la {0}", arr[n-1]);*/


            /*int n, i, j = 0, k = 0;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] evenArr = new int[n]; // mang chan
            int[] oddArr = new int[n]; // mang le

            Console.WriteLine("Nhap {0} gia tri cho cac phan tu cua mang sau:", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    evenArr[j] = arr[i];
                    j++;
                }
                else
                {
                    oddArr[k] = arr[i];
                    k++;
                }
            }

            Console.WriteLine();
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", evenArr[i]);
            }

            Console.WriteLine();
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", oddArr[i]);
            }*/


            /*int n, i, j, temp;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n + 1];

            Console.WriteLine("Nhap {0} gia tri cho cac phan tu cua mang sau:", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Nhap them mot phan tu ban muon chen them: ");
            arr[n] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sau khi chen them ta co mang moi nhu sau (da sap xep): ");
            for (i = 0; i <= n; i++)
            {
                for (j = i + 1; j <= n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                if (i < n)
                {
                    Console.Write("{0} ", arr[i]);
                } else
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }*/


            /*int n, i, j, m;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];

            Console.WriteLine("Nhap {0} gia tri cho cac phan tu cua mang sau:", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Nhap vi tri ban muon chen: ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri ban muon chen them: ");
            m = Convert.ToInt32(Console.ReadLine());

            for (i = n; i >= j; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[j - 1] = m;

            for (i = 0; i <= n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }*/


            /*int n, i, j;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];

            Console.WriteLine("Nhap {0} gia tri cho cac phan tu cua mang sau:", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            do
            {
                Console.Write("Nhap vi tri ban muon xoa: ");
                j = Convert.ToInt32(Console.ReadLine());

                if (j >= n || j < 0)
                {
                    Console.WriteLine("Vi tri ban muon xoa khong ton tai trong mang. Xin hay kiem tra lai!");
                }
            } while (j >= n || j < 0);
            
            for (i = 0; i < n; i++)
            {
                if (i == j - 1)
                {
                    continue;
                }
                Console.Write("{0} ", arr[i]);
            }*/


            /*int n, i, j, temp;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];

            Console.WriteLine("Nhap {0} gia tri cho cac phan tu cua mang sau:", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                if (i == n - 1)
                {
                    continue;
                }
                
            }
            Console.WriteLine("{0} ", arr[n - 2]);*/


            /*int row1, col1, row2, col2, i, j;
            int[,] arr1 = new int[100,100];
            int[,] arr2 = new int[100,100];
            int[,] arr3 = new int[100,100];

            do
            {
                Console.Write("Nhap so hang cua mang 2 chieu dau tien: ");
                row1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so cot cua mang 2 chieu dau tien: ");
                col1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap so hang cua mang 2 chieu thu hai: ");
                row2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so cot cua mang 2 chieu thu hai: ");
                col2 = Convert.ToInt32(Console.ReadLine());

                if (col1 != row2)
                {
                    Console.WriteLine("\nKhong the nhan 2 ma tran nhu nay. Hay nhap so cot cua mang dau tien bang so hang cua mang thu hai");
                }
            } while (col1 != row2);

            Console.WriteLine("\nHay nhap gia tri cho mang hai chieu dau tien:");
            for (i = 0; i < row1; i++)
            {
                for (j = 0; j < col1; j++)
                {
                    Console.Write("arr1[{0}][{1}] = ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nHay nhap gia tri cho mang hai chieu thu hai:");
            for (i = 0; i < row2; i++)
            {
                for (j = 0; j < col2; j++)
                {
                    Console.Write("arr2[{0}][{1}] = ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // thuc hien nhan hai mang 2 chieu
            for (i = 0; i < row1; i++)
            {
                for (j = 0; j < col2; j++)
                {
                    arr3[i, j] = 0;
                }
            }
            for (i = 0; i < row1; i++)
            {
                for (j = 0; j < col2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        // arr1[row1, col1] * arr2[col1, col2]
                        sum += arr1[i, k] * arr2[k, j];
                    }
                    arr3[i, j] = sum;
                }
            }

            Console.WriteLine("\nKet qua nhan hai mang nhu sau:");
            for (i = 0; i < row1; i++)
            {
                for (j = 0; j < col2; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }
                Console.WriteLine();
            }*/


            /*int i, j, row, col;
            int[,] arr = new int[100, 100];

            Console.Write("Nhap so hang cua mang 2 chieu: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua mang 2 chieu: ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHay nhap gia tri cho mang 2 chieu sau day:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("arr[{0}][{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMang ban dau co dang:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(" {0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMang sau khi chuyen vi co dang:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(" {0}\t", arr[j, i]);
                }
                Console.WriteLine();
            }*/


            /*int i, j, row, col;
            int[,] arr = new int[100, 100];

            Console.Write("Nhap so hang cua mang 2 chieu: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua mang 2 chieu: ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHay nhap gia tri cho mang 2 chieu sau day:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("arr[{0}][{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMang 2 chieu co dang:");
            int sum = 0;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(" {0}\t", arr[i, j]);
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTong cac phan tu tren duong cheo chinh la {0}", sum);*/


            /*int i, j, row, col;
            int[,] arr = new int[100, 100];

            Console.Write("Nhap so hang cua mang 2 chieu: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua mang 2 chieu: ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHay nhap gia tri cho mang 2 chieu sau day:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("arr[{0}][{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMang 2 chieu co dang:");
            int sum = 0;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(" {0}\t", arr[i, j]);
                    if (i + j == row - 1)
                    {
                        sum += arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTong cac phan tu tren duong cheo phu la {0}", sum);*/


            /*int i, j, row, col;
            int[,] arr = new int[100, 100];

            Console.Write("Nhap so hang cua mang 2 chieu: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua mang 2 chieu: ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHay nhap gia tri cho mang 2 chieu sau day:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("arr[{0}][{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMang 2 chieu co dang:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(" {0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nKet qua co dang:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    if (i < j)
                    {
                        Console.Write(" {0}\t", 0);
                    } else
                    {
                        
                        Console.Write(" {0}\t", arr[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }*/


            /*int i, j, row, col, count1 = 0;
            int[,] arr = new int[100, 100];

            Console.Write("Nhap so hang cua mang 2 chieu: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua mang 2 chieu: ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHay nhap gia tri cho mang 2 chieu sau day:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("arr[{0}][{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i, j] == 0)
                    {
                        count1++;
                    }
                }
            }

            Console.WriteLine("\nMang 2 chieu co dang:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(" {0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }

            if (count1 > (row * col - count1))
            {
                Console.WriteLine("Ma tran tren la ma tran thua!");
            } else
            {
                Console.WriteLine("Ma tran tren khong phai la ma tran thua!");
            }*/


            /*int i, j, row, col;
            int[,] arr = new int[100, 100];
            int[] sumOfRow = new int[100];
            int[] sumOfCol = new int[100];

            Console.Write("Nhap so hang cua mang 2 chieu: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua mang 2 chieu: ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHay nhap gia tri cho mang 2 chieu sau day:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("arr[{0}][{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // tinh tong hang
            for (i = 0; i < row; i++)
            {
                int sum_row = 0;
                for (j = 0; j < col; j++)
                {
                    sum_row += arr[i, j];
                }
                sumOfRow[i] = sum_row;
            }

            // tinh tong cot
            for (i = 0; i < row; i++)
            {
                int sum_col = 0;
                for (j = 0; j < col; j++)
                {
                    sum_col += arr[j, i];
                }
                sumOfCol[i] = sum_col;
            }

            // in ket qua
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.Write("{0} ", sumOfRow[i]);
                Console.WriteLine();
            }

            Console.WriteLine();
            for (j = 0; j < col; j++)
            {
                Console.Write("{0}\t", sumOfCol[j]);
            }*/


            // insert sort
            /*InsertSort selection = new InsertSort();
            Console.WriteLine("Mang ban dau co dang:");
            selection.CreateArr(10);
            Console.WriteLine();
            Console.WriteLine("Mang sau khi duoc sap xep: ");
            selection.Sort();*/


            // merge sort
            // quick sort


            /*string str;
            int length = 0;
            Console.Write("Nhap vao mot chuoi bat ky: ");
            str = Console.ReadLine();

            foreach (char i in str)
            {
                length++;
            }
            Console.WriteLine("Do dai cua chuoi tren la: {0}", length);*/


            /*string str;
            Console.Write("Nhap vao mot chuoi bat ky: ");
            str = Console.ReadLine();

            // tinh do dai chuoi (khong dung ham co san)
            int length = str.Length;

            // in cac ky tu rieng le theo chieu nguoc lai

            // way 1
            *//*string temp = "";
            foreach (char s in str)
            {
                temp += s + " ";
            }
            Console.WriteLine(temp);

            for (int i = temp.Length - 2; i >= 0; i--)
            {
                Console.Write(temp[i]);
            }*//*

            // way 2
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", str[i]);
            }*/



            /* y tuong:
             - su dung regex de THAY THE nhung tu tim thay bang so 1
             - dem ky tu 1 xuat hien bao nhieu lan thi co duoc ket qua so luong ky tu co trong chuoi
             */
            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();

            string temp = Regex.Replace(str, @"\b[a-z]+\b", "1");
            int count = 0;
            foreach (char d in temp)
            {
                if (d == '1')
                {
                    count++;
                }
            }
            Console.WriteLine("Co {0} tu trong chuoi tren", count);*/


            /*Console.Write("Nhap chuoi thu nhat: ");
            string str1 = Console.ReadLine();
            int lenStr1 = str1.Length;
            Console.Write("Nhap chuoi thu hai: ");
            string str2 = Console.ReadLine();
            int lenStr2 = str2.Length;

            bool flag = false;
            if (lenStr1 != lenStr2)
            {
                Console.WriteLine("Hai chuoi tren khong bang nhau!");
            } else
            {
                for (int i = 0; i < lenStr1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        flag = false;
                        Console.WriteLine("Hai chuoi tren khong bang nhau!");
                        break;
                    } else
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine("Hai chuoi tren bang nhau!");
                }
            }*/


            /* ***Idea 1: dung regex, cu the la replace
             - (-): thay the cho cac chu cai
             - a: thay the cho cac chu so
             - so luong ky tu dac biet thi chi can tru di so luong cua 2 loai tren
              
               ***Idea 2: so sanh chu cai, so sanh chu so, ky tu dac biet thi tru so luong 2 loai kia di
             */
            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();

            string temp1 = Regex.Replace(str, @"[a-zA-Z]", "-");
            string temp2 = Regex.Replace(temp1, @"[0-9]", "a");

            int countCharacter = 0, countDigit = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (temp1[i] == '-')
                {
                    countCharacter++;
                }
                if (temp2[i] == 'a')
                {
                    countDigit++;
                }
            }
            Console.WriteLine("So luong chu cai trong chuoi tren la {0}", countCharacter);
            Console.WriteLine("So luong chu so trong chuoi tren la {0}", countDigit);
            Console.WriteLine("So luong ky tu dac biet trong chuoi tren la {0}", str.Length - countCharacter - countDigit);*/


            /* Idea: sao chep tung ky tu trong string thu nhat roi copy sang chuoi thu 2
              - Note: chuoi thu 2 co dang mang
             */
            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str1 = Console.ReadLine();
            int lenStr1 = str1.Length, i = 0;

            // khoi tao string moi (string kieu mang) de copy str1 sang
            string[] str2 = new String[lenStr1];

            // tach tung ky tu cua str1
            while (i < lenStr1)
            {
                str2[i] = str1[i].ToString();
                i++;
            }
            // String.Join("", str2): "" se duoc them vao giua cac phan tu cua mang str2
            Console.WriteLine("Chuoi duoc copy la: {0}", String.Join("", str2));*/


            /* Idea: dung regex replace
             - thay cac nguyen am bang 1
             - thay cac phu am bang 2
             */
            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();

            string temp1 = Regex.Replace(str, @"[ueoai]", "1");
            Console.WriteLine(temp1);
            string temp2 = Regex.Replace(temp1, @"[^ueoai\d\s]", "2");
            Console.WriteLine(temp2);

            int countVowel = 0, countConsonant = 0; 
            for (int i = 0; i < temp2.Length; i++)
            {
                if (temp2[i] == '1')
                {
                    countVowel++;
                }
                if (temp2[i] == '2')
                {
                    countConsonant++;
                }
            }
            Console.WriteLine("Co {0} nguyen am trong chuoi tren", countVowel);
            Console.WriteLine("Co {0} phu am trong chuoi tren", countConsonant);*/


            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();

            string newStr = Regex.Replace(str, @"\s", "");
            int lenNewStr = newStr.Length, i, j;

            int[] tempArr = new int[lenNewStr];
            int[] temp = new int[100];

            for (i = 0; i < lenNewStr; i++)
            {
                tempArr[i] = newStr[i];
                temp[i] = 1;
            }

            for (i = 0; i < lenNewStr; i++)
            {
                int count = 1;
                for (j = i + 1; j < lenNewStr; j++)
                {
                    if (tempArr[i] == tempArr[j])
                    {
                        count++;
                        temp[j] = 0;
                    }
                }
                if (temp[i] != 0)
                {
                    temp[i] = count;
                }
            }

            for (i = 0; i < lenNewStr; i++)
            {
                for (j = i + 1; j < lenNewStr; j++)
                {
                    if (temp[i] > temp[j])
                    {
                        int bien_tam = temp[i];
                        temp[i] = temp[j];
                        temp[j] = bien_tam;
                    }
                }
            }
            Console.WriteLine("So lan xuat hien nhieu nhat la: {0}", temp[lenNewStr - 1]);*/


            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();

            // loai bo khoang trang neu co
            string newStr = Regex.Replace(str, @"\s", "");

            // dua tat cac ky tu vao mang letters qua ham ToCharArray()
            char[] letters = newStr.ToCharArray();

            // so luong phan tu trong mang letters = do dai newStr
            int lenNewStr = newStr.Length, i, j;

            // duyet de doi vi tri theo bang chu cai Tieng Anh
            for (i = 0; i < lenNewStr; i++)
            {
                for (j = i + 1; j < lenNewStr; j++)
                {
                    if (letters[i] > letters[j])
                    {
                        char temp = letters[i];
                        letters[i] = letters[j];
                        letters[j] = temp;
                    }
                }
                Console.Write("{0} ", letters[i]);
            }*/


            /*int i, j;
            Console.Write("Nhap so luong chuoi: n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strArr = new String[n];

            Console.WriteLine("Nhap vao {0} chuoi:", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Chuoi {0}: ", i);
                strArr[i] = Console.ReadLine();
            }

            Console.WriteLine("Danh sach chuoi sau khi duoc sap xep nhu sau:");
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (strArr[i].CompareTo(strArr[j]) > 0)
                    {
                        string temp = strArr[i];
                        strArr[i] = strArr[j];
                        strArr[j] = temp;
                    }
                }
                Console.Write(strArr[i] + "\t");
            }*/


            /*int n, m, i, lenghtStr, j;
            Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();
            Console.Write("Nhap vi tri de bat dau lay chuoi con: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap do dai chuoi ban muon lay (khac 0): ");
            m = Convert.ToInt32(Console.ReadLine());

            // tach cac ky tu trong chuoi roi cho vao mang letters
            char[] letters = str.ToCharArray();
            lenghtStr = str.Length;

            // way 1
            for (i = 0; i < lenghtStr; i++)
            {
                if (i == n - 1 && n - 1 < lenghtStr && n - 1 >= 0)
                {
                    for (j = i; j < m + n - 1; j++)
                    {
                        Console.Write(letters[j]);
                    }
                }
            }

            //way 2
            *//* int c = 0;
             while (c < m)
             {
                 Console.Write(letters[n + c - 1]);
                 c++;
             }*/


            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();
            Console.Write("Nhap chuoi con ban muon kiem tra: ");
            string testStr = Console.ReadLine();

            bool flag = str.Contains(testStr);

            if (flag)
            {
                Console.WriteLine("'{0}' co ton tai trong chuoi", testStr);
            } else
            {
                Console.WriteLine("'{0}' khong ton tai trong chuoi", testStr);
            }*/


            /*Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine();
            int lengthStr = str.Length, i;

            char[] letters = str.ToCharArray();

            Console.WriteLine("Day la ket qua sau khi hoan doi chu hoa va chu thuong:");
            for (i = 0; i < lengthStr; i++)
            {
                if (Char.IsUpper(letters[i]))
                {
                    Console.Write(Char.ToLower(letters[i]));
                } else
                {
                    Console.Write(Char.ToUpper(letters[i]));
                }
            }*/


            /*int lengthStr, i, j, leninsertStr;
            string str, insertStr;

            do
            {
                Console.Write("Nhap mot chuoi bat ky: ");
                str = Console.ReadLine();
                lengthStr = str.Length;

                Console.Write("Nhap mot chuoi khac de kiem tra: ");
                insertStr = Console.ReadLine();
                leninsertStr = insertStr.Length;

                if (leninsertStr > lengthStr)
                {
                    Console.WriteLine("Hay nhap chuoi thu hai co do dai nho hon chuoi thu nhat!");
                }
            } while (leninsertStr > lengthStr);

            char[] lettersOfStr = str.ToCharArray();
            char[] lettersOfinsertStr = insertStr.ToCharArray();

            for (i = 0; i < lengthStr; i++)
            {
                for (j = 0; j < leninsertStr; j++)
                {
                    if (lettersOfStr[i] == lettersOfinsertStr[j])
                    {
                        Console.WriteLine(lettersOfStr[i]);
                    }
                }
            }*/


            /*Console.Write("Nhap '1' ky tu bat ky trong bang chu cai Tieng Anh: ");
            char character = Convert.ToChar(Console.ReadLine());

            // co the dung isLetter de kiem tra xem do co phai la chu cai hay khong
            if (Char.IsLetter(character))
            {
                if (Char.IsUpper(character))
                {
                    Console.WriteLine("Ky tu '{0}' la chu hoa", character);
                }
                else
                {
                    Console.WriteLine("Ky tu '{0}' la chu thuong", character);
                }
            } else
            {
                Console.WriteLine("Hay nhap ky tu la mot chu cai hop le!");
            }*/


            /*string str; //khai bao chuoi ban dau
            string chuoi_con; //khai bao chuoi con can tim
            int start = 0;
            int count = -1;
            int index = -1;

            Console.Write("Nhap chuoi ban dau: ");
            str = Console.ReadLine();
            Console.Write("Nhap chuoi con can tim: ");
            chuoi_con = Console.ReadLine();

            while (start != -1)
            {
                start = str.IndexOf(chuoi_con, index + 1); // neu start = -1 thi dung luon sau buoc nay

                // 2 dong lenh nay chi chay khi start != -1
                count += 1;
                index = start;
            }
            Console.Write("Chuoi con '{0}' xuat hien " + count + " lan.\n", chuoi_con);*/


            /*string str, insertStr, addSpace, result, temp;
            int pos;

            Console.Write("Nhap chuoi ban dau: ");
            str = Console.ReadLine();

            Console.Write("Nhap chuoi ban muon chen: ");
            insertStr = Console.ReadLine();
            addSpace = " " + insertStr.Trim() + " ";

            Console.Write("Nhap chuoi de tim vi tri ban muon chen vao: ");
            temp = Console.ReadLine();
            pos = str.IndexOf(temp);

            result = str.Insert(pos, addSpace);
            Console.WriteLine(result);*/


            // *********************************** Struct *****************************************

            /*Test.x = 15;
            Test.y = 85;
            int sum = Test.x + Test.y;
            Console.WriteLine(sum);*/


            /*newStruct myPoint;
            myPoint.m = 30;
            myPoint.n = 40;
            Console.Write("newStruct : ");
            Console.WriteLine("m = {0}, n = {1}", myPoint.m, myPoint.n);*/
        }
    }

    /*class InsertSort
    {
        int i, j;
        private int[] numbersArr;
        private static Random random = new Random();

        // tao mot mang voi size ngau nhien
        public void CreateArr(int size)
        {
            numbersArr = new int[size];
            for (i = 0; i < size; i++)
            {
                numbersArr[i] = random.Next(20, 90);
                Console.Write("{0}  ", numbersArr[i]);
            }
        }

        public void Sort()
        {
            int lengthOfNumbersArr = numbersArr.Length;
            for (i = 0; i < lengthOfNumbersArr - 1; i++)
            {
                for (j = i + 1; j < lengthOfNumbersArr; j++)
                {
                    if (numbersArr[i] > numbersArr[j])
                    {
                        // hoan doi vi tri
                        swap(i, j);
                    }
                }
            }
            showArrResult();
        }

        // ham hoan doi vi tri
        public void swap(int a,int b)
        {
            int temp = numbersArr[b];
            numbersArr[b] = numbersArr[a];
            numbersArr[a] = temp;
        }

        // hien thi mang da sap xep
        public void showArrResult()
        {
            foreach (var element in numbersArr)
            {
                Console.Write("{0}  ", element);
            }
            Console.WriteLine();
        }
    }*/
}