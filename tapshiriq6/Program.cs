namespace tapshiriq6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //    Console.WriteLine("Masivin daxilindeki elementler ile muqayise C:");
            //l1:
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("eded duzgun daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.WriteLine("Masivin Uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    int[] a = new int[n];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.WriteLine($"[{i + 1}]");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded Daxil Edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (Math.Abs(a[i]) < c)
            //        {
            //            Console.WriteLine($"{c} > {a[i]}");
            //        }
            //        else if (a[i] == c)
            //        {
            //            Console.WriteLine($"{c} = {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{c}<{a[i]}");
            //        }

            //    }
            #endregion

            #region Task2

            //    Console.WriteLine("Masivin daxilindeki elementler ile muqayise C:");
            //l1:
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("eded duzgun daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.WriteLine("Masivin Uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    int[] a = new int[n];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.WriteLine($"[{i + 1}]");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded Daxil Edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    int sum = 0;
            //    int count = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (Math.Abs(a[i]) < c)
            //        {
            //            sum += a[i];
            //            count++;
            //        }

            //    }

            //    int num = sum / count;
            //    Console.WriteLine($"{num}");
            #endregion
            #region Task3

            //    string strC, strN, strA;
            //    int c, n;
            //    double geometricMean;
            //    int product = 1;
            //    int count = 0;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
            //    }
            //    //================================
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (Math.Abs(a[i]) > c)
            //        {
            //            product *= a[i];
            //            count++;
            //        }
            //    }
            //    geometricMean = Math.Pow(product, (1.0 / count));
            //    Console.WriteLine($"Hendesi ortasi: {geometricMean}");

            //    Console.ReadKey();
            #endregion
            #region Task4
            //    string strB, strD, strC;
            //    int c, n;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strB = Console.ReadLine();
            //    if (!int.TryParse(strB, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strD = Console.ReadLine();
            //    if (!int.TryParse(strD, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strC = Console.ReadLine();
            //        if (!int.TryParse(strC, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
            //    }
            //    if (a[n - 1] > c)
            //    {
            //        Array.Sort(a);
            //        Array.Reverse(a);
            //    }

            //    Console.WriteLine($"Massivde mutleq deyeri {c}-den boyuk olan elementlerdir");
            //    foreach (int i in a)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    Console.ReadKey();
            #endregion
            #region Task5
            //    string strA, strB, strC;
            //    int c, n;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strB = Console.ReadLine();
            //    if (!int.TryParse(strB, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strC = Console.ReadLine();
            //        if (!int.TryParse(strC, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
            //    }
            //    if (a[n - 1] > c)
            //    {
            //        Array.Sort(a);
            //        Array.Reverse(a);
            //    }

            //    Console.WriteLine($"Massivde icindeki maximum element {c}");
            //    Console.WriteLine(a[0]);
            //    Console.ReadKey();
            #endregion
            #region Task6
            //    string strA, strB, strX, strY;
            //    int n1, n2;
            //L1:
            //    Console.Write("X(n) massivin uzunluğunu daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out n1))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //    int[] x = new int[n1];

            //    for (int i = 0; i < n1; i++)
            //    {
            //    l2:
            //        Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //        strX = Console.ReadLine();
            //        if (!int.TryParse(strX, out x[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l2;
            //        }
            //    }
            //L3:
            //    Console.Write("Y(n) massivin uzunluğunu daxil edin: ");
            //    strB = Console.ReadLine();
            //    if (!int.TryParse(strB, out n2))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L3;
            //    }
            //    int[] y = new int[n2];

            //    for (int j = 0; j < n2; j++)
            //    {
            //    l4:
            //        Console.Write("Y[" + (j + 1) + "] deyerini daxil edin: ");
            //        strY = Console.ReadLine();
            //        if (!int.TryParse(strY, out y[j]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l4;
            //        }
            //    }
            //    Console.Write("Netice: ");
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        for (int j = 0; j < y.Length; j++)
            //        {
            //            if (x[i] == Math.Pow(y[j], 2))
            //            {
            //                Console.Write($"{x[i]} ");
            //            }
            //        }
            //    }

            //    Console.ReadKey();
            #endregion
            #region Task7
            //    string strA, strB;
            //    int a;
            //L1:
            //    Console.Write("X(n) massivin uzunluğunu daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out a))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //    int[] x = new int[a];

            //    for (int i = 0; i < a; i++)
            //    {
            //    l2:
            //        Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //        strB = Console.ReadLine();
            //        if (!int.TryParse(strB, out x[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l2;
            //        }
            //    }
            //    Array.Sort(x);


            //    double numAverage;
            //    double geometricMean;
            //    double product = x[0] * x[x.Length - 1];

            //    geometricMean = Math.Pow(product, 1.0 / 2);

            //    double One = x[0];
            //    double Two = x[x.Length - 1];
            //    numAverage = (double)(One + Two) / 2.0;
            //    Console.WriteLine($"Ededi ortasi: {numAverage}");

            //    Console.WriteLine($"Hendesi ortasi: {geometricMean}");
            #endregion
            #region Task8
            //string strA, strB;
            //int netice;

            //int[] x = new int[14];

            //for (int i = 0; i < 14; i++)
            //{
            //l1:
            //    Console.Write("A[" + (i + 1) + "] deyerini daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out x[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //}

            //int[] y = new int[14];

            //for (int i = 0; i < 14; i++)
            //{
            //l2:
            //    Console.Write("B[" + (i + 1) + "] deyerini daxil edin: ");
            //    strB = Console.ReadLine();
            //    if (!int.TryParse(strB, out y[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l2;
            //    }
            //}
            //int[] result = new int[14];
            //Console.WriteLine(" ");
            //Console.Write("Yeni massivin elementleri: ");
            //for (int i = 0; i < 14; i++)
            //{
            //    netice = x[i] * y[i];
            //    if (netice > 0)
            //    {
            //        result[i] = netice;
            //    }
            //    Console.Write(result[i] + " ");
            //}
            #endregion
            #region Task9
            //string strA;

            //int[] x = new int[25];

            //for (int i = 0; i < 25; i++)
            //{
            //l1:
            //    Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out x[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //}

            //int[] netice = new int[8];
            //Console.WriteLine("Yeni 1-ci masivin elementleri(kvadrati artirilanlar): ");
            //for (int i = 0; i < 8; i++)
            //{
            //    netice[i] = (int)Math.Pow(x[i], 2);
            //}
            //foreach (var item in netice)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] netice1 = new int[17];

            //Console.WriteLine("Yeni 2-ci masivin elementleri(4e bolunenler): ");
            //for (int i = 8; i < 25; i++)
            //{
            //    netice1[i - 8] = x[i] / 4;
            //}
            //foreach (var item in netice1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Task10
            //    string strA, strB;
            //    int n;

            //l1:
            //    Console.Write("X(n) massivinin uzunluğunu daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //    int[] x = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l2:
            //        Console.Write("x[" + (i + 1) + "] deyerini daxil edin: ");
            //        strB = Console.ReadLine();
            //        if (!int.TryParse(strB, out x[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l2;
            //        }
            //    }

            //    Array.Sort(x);

            //    int result = x[0];
            //    Console.WriteLine(result);
            #endregion
            #region Task11
            //    string strA;
            //    int n;

            //l1:
            //    Console.Write("X(n) massivinin uzunluğunu daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //    int[] x = new int[n];

            //    Random random = new Random();

            //    for (int i = 0; i < n; i++)
            //    {
            //        x[i] = random.Next(101);
            //    }
            //    Array.Sort(x);
            //    Array.Reverse(x);
            //    Console.WriteLine("X(n) massivinin ededleri azalma sirasina gore: ");
            //    foreach (var item in x)
            //    {
            //        Console.WriteLine(item);
            //    }
            #endregion
            #region Task12
            //string strA;

            //int[] x = new int[20];

            //for (int i = 0; i < 20; i++)
            //{
            //l1:
            //    Console.Write("A[" + (i + 1) + "] deyerini daxil edin: ");
            //    strA = Console.ReadLine();
            //    if (!int.TryParse(strA, out x[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //}
            //int sum = 0;
            //int a = 0;
            //int b = 0;
            //int hasil = 1;
            //double numAverage;
            //double geometricMean;

            //for (int i = 0; i < 10; i++)
            //{
            //    sum += x[i];
            //    a++;
            //}
            //numAverage = sum / a;
            //Console.WriteLine($"Ilk yarisinin elementlerinin ededi ortasi: {numAverage}");

            //for (int i = 10; i < 20; i++)
            //{
            //    hasil *= x[i];
            //    b++;
            //}
            //geometricMean = Math.Pow(hasil, 1.0 / b);

            //Console.WriteLine($"Hendesi ortasi: {geometricMean}");
            #endregion

        }
    }

    }
