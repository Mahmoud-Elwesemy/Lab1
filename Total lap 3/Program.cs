namespace Total_lap_3
{
    #region rectangle (part 2 - 1 )
    //public struct Rectangle
    //{
    //    public double Width
    //    {
    //        get
    //        {
    //            return Width;

    //        }
    //        set
    //        {
    //            if (Width >= 0) Width = value;
    //            else throw new Exception("invalid data");
    //        }
    //    }
    //    public double Height { get; set; }

    //    public double Area()
    //    {
    //        return (Width * Height);
    //    }
    //    public double Perimeter()
    //    {
    //        return ((Height + Width) * 2);
    //    }
    //    public void print()
    //    {
    //        Console.WriteLine($"the Height of your Rectangle is : {Height} \n the Width of your Rectangle is : {Width}");
    //    }

    //}
    #endregion
    #region Time span ( part 2 - 1 )
    public struct TimeSpan
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconde { get; set; }
        public int TotalSecondn()
        {

            return ((Hours * 3600) + (Minutes * 60) + Seconde);
        }
        public void Getstring()
        {
            Console.WriteLine($"H : {Hours} , M : {Minutes} , S : {Seconde}");
        }

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region multiplicate table (part 1 - 1)
            //int[,] multiplicate = new int[12,12];
            //Console.WriteLine("multiplicate tabel");
            //for (int i = 0; i <= 12; i++)
            //{
            //    for (int j = 0; j <= 12; j++)
            //    {
            //        Console.WriteLine($"{i+1} * {j} = {i*j}");
            //    }
            //}
            #endregion
            #region student age (part 1 - 2)
            //Console.WriteLine("enter the number of tracks");
            //int t = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the number of student in each track");
            //int s = int.Parse(Console.ReadLine());
            //int[,] aree = new int[t, s];
            //for (int i = 0; i < t; i++)
            //{
            //    Console.WriteLine($"enter age of students in track {i + 1}");
            //    for (int j = 0; j < s; j++)
            //    {
            //        Console.WriteLine($"enter age of student {j + 1}");
            //        aree[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < t; i++)
            //{
            //    Console.WriteLine($"age of students in track {i + 1}");
            //    for (int j = 0; j < s; j++)
            //    {
            //        Console.WriteLine($"age of student {j + 1} = {aree[i, j]}");
            //    }

            //}
            #endregion
            #region Bonus
            //Console.WriteLine("enter the number of tracks");
            //int t = int.Parse(Console.ReadLine());
            //int s;
            //int[][] aree = new int[t][];
            //for (int i = 0; i < t; i++)
            //{
            //    Console.WriteLine($"enter the number of student in track {i + 1}");
            //    s = int.Parse(Console.ReadLine());
            //    aree[i] = new int[s];
            //    for (int j = 0; j < s; j++)
            //    {
            //        Console.WriteLine($"enter age of student {j + 1}");
            //        aree[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < t; i++)
            //{
            //    Console.WriteLine($"the age of student in track {i + 1} is ");
            //    for (int j = 0; j < aree[i].Length; j++)
            //    {
            //        Console.WriteLine($"the age of student {j + 1} is {aree[i][j]}");
            //    }
            //}
            #endregion
            #region rectangle (pare 2 - 1 )
            //Rectangle x = new Rectangle();
            //Console.WriteLine("enter the width");
            //x.Width = double.Parse( Console.ReadLine() );
            //Console.WriteLine("enter the height");
            //x.Height = double.Parse(Console.ReadLine());
            //x.print();
            //x.Area ();
            //x.Perimeter ();
            //Console.WriteLine(x.Area());
            #endregion
            #region Time span ( part 2 - 1 )
            Console.WriteLine("enter number of time you want to enter");
            int x = int.Parse(Console.ReadLine());
            TimeSpan[] time = new TimeSpan[x];
            for (int i = 0; i < x; i++)
            {
                time[i] = new TimeSpan();
                Console.WriteLine($"time {i + 1}\n");
                Console.WriteLine("enter your number of Hours");
                time[i].Hours = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your number of Minutes");
                time[i].Minutes = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your number of Seconds");
                time[i].Seconde = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"the time {i + 1}");
                time[i].Getstring();
                Console.WriteLine($"total seconde of your time is : {time[i].TotalSecondn()}");
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = i + 1; j < x; j++)
                {
                    if (time[i].Hours < time[j].Hours)
                    {
                        int index = time[j].Hours;
                        time[j].Hours = time[i].Hours;
                        time[i].Hours = index;
                    }
                    else if (time[i].Minutes < time[j].Minutes)
                    {
                        int index = time[j].Minutes;
                        time[j].Minutes = time[i].Minutes;
                        time[i].Minutes = index;
                    }
                    else if (time[i].Seconde < time[j].Seconde)
                    {
                        int index = time[j].Seconde;
                        time[j].Seconde = time[i].Seconde;
                        time[i].Seconde = index;

                    }
                }
            }
            Console.WriteLine("the time after sorte");
            for (int i = 0; i < x; i++)
            {
                time[i].Getstring();
                Console.WriteLine($"total seconde of your time is : {time[i].TotalSecondn()}");
                }
                #endregion
            }

    }
}
