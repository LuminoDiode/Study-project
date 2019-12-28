using System;
using System.Collections.Generic;

static class General //General Purpose Functions
{
    static Random rnd = new Random();

    /// <summary>
    /// Str1 more than Str2 ret 1;
    /// Str1 less than Str2 ret -1;
    /// Str1 eqls Str2 ret 0;
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public static int CompareStrings(in string str1, in string str2) //Debugged
    {
        int steps = MinLen(str1, str2);
        for (int i = 0; i < steps; i++)
        {
            if (str1[i] < str2[i]) return -1;
            else if (str1[i] > str2[i]) return 1;
        }
        if (str1.Length < str2.Length) return -1;
        else if (str1.Length > str2.Length) return 1;
        return 0; // Equals
    }

    /// <summary>
    /// Возвращает наименьшую из длинн двух строк.
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public static int MinLen(in string str1, in string str2) //Debugged
    {
        if (str1.Length < str2.Length) return str1.Length;
        return str2.Length;
    }

    /// <summary>
    /// Возвращает среднее значение двух целочисленных переменных.
    /// (int1 + int2)/2
    /// </summary>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    /// <returns></returns>
    public static int Middle(in int i1, in int i2) //Debugged
    {
        return ((i1 + i2) / 2);
    }

    /// <summary>
    /// Возвращает массив случаных строк с символами A-Z.
    /// </summary>
    /// <param name="StrLen"></param>
    /// <param name="ArrLen"></param>
    /// <returns></returns>
    public static string[] RandomStringsArr(in int StrLen, in int ArrLen) //Debugged
    {
        string[] Out = new string[ArrLen];
        for (int i = 0; i < ArrLen; i++)
        {
            Out[i] += RandomString(StrLen);
        }
        return Out;
    }

    /// <summary>
    /// Возвращает случайную строку с символами A-Z.
    /// </summary>
    /// <param name="StrLen"></param>
    /// <returns></returns>
    public static string RandomString(int StrLen) //Debugged
    {
        Random rnd = new Random();
        string Out = string.Empty;
        for (; StrLen > 0; StrLen--)
        {
            Out += char.ConvertFromUtf32(rnd.Next(65, 91));
        }
        return Out;
    }

    /// <summary>
    /// Возвращает массив случаный целых чисел заданной длинны.
    /// </summary>
    /// <param name="NumLen"></param>
    /// <param name="ArrLen"></param>
    /// <returns></returns>
    public static int[] RandomIntArr(in int NumLen, in int ArrLen) //Debugged
    {
        Random rnd = new Random();
        int[] Out = new int[ArrLen];
        int Min = (int)Math.Pow(10, NumLen - 1);
        int Max = (int)Math.Pow(10, NumLen);
        for (int i = 0; i < ArrLen; i++)
        {
            Out[i] = rnd.Next(Min, Max);
        }
        return Out;
    }

    /// <summary>
    /// Возвращает массив случайных чисел в определенном диапазоне.
    /// </summary>
    /// <param name="Min"></param>
    /// <param name="Max"></param>
    /// <param name="ArrLen"></param>
    /// <returns></returns>
    public static int[] RandomIntArr(in int Min, in int Max, in int ArrLen) //Debugged
    {
        Random rnd = new Random();
        int[] Out = new int[ArrLen];
        for (int i = 0; i < ArrLen; i++)
        {
            Out[i] = rnd.Next(Min, Max);
        }
        return Out;
    }

    /// <summary>
    /// Возвращает случайное число заданной длинны.
    /// </summary>
    /// <param name="NumLen"></param>
    /// <returns></returns>
    public static int RandomInt(in int NumLen) //Debugged
    {
        Random rnd = new Random();
        int Min = (int)Math.Pow(10, NumLen - 1);
        int Max = (int)Math.Pow(10, NumLen);
        return rnd.Next(Min, Max);
    }

    /// <summary>
    /// Возвращает случайно число в заданном дапазоне.
    /// </summary>
    /// <param name="Min"></param>
    /// <param name="Max"></param>
    /// <returns></returns>
    public static int RandomInt(in int Min, in int Max) //Debugged
    {
        return rnd.Next(Min, Max);
    }

    /// <summary>
    /// Возвращает наибольший общий делитель для двух чисел.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static int GreatestCommonDivider(in int x, in int y) //Debugged
    {
        if (x - y * (x / y) == 0) return y;
        return GreatestCommonDivider(y, x - y * (x / y));
    }

    /// <summary>
    /// Возвращает наименьшее общее кратное для двух чисел.
    /// </summary>
    public static int LeastCommonMultiple(in int x, in int y) //Debugged
    {
        return ((x * y) / GreatestCommonDivider(x, y));
    }

    /// <summary>
    /// Возвращает количество символов в целом числе.
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static int NumLen(in int num) //Debugged
    {
        int count = 1;
        for (int i = 10; (num / i) != 0; i *= 10, count++) ;
        return count;
    }

    /// <summary>
    /// Возводит целое число в целую степень.
    /// Возвращает целое число.
    /// </summary>
    /// <param name="num"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int Pow(in int num, int x) //Debugged
    {
        if (x == 0) return 1;
        int Out = num;
        for (; x > 1; x--) Out *= num;
        return Out;
    }

    /// <summary>
    /// Проверяет числа на соответсвие одного зеркальному отражению другого.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int IsSpecular(int a, int b) //Debugged
    {
        for (int i = (NumLen(a) - 1); i != -1; i--)
        {
            if (a % 10 != b / Pow(10, i)) return 0;
            a /= 10;
            b -= (b / Pow(10, i)) * Pow(10, i);
        }
        return 1;
    }

    /// <summary>
    /// Проверяет строку на полиндромность, т.е. на соответсвие
    /// отраженной строки исходной.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static int IsPolindrome(in string str) //Debugged
    {
        for (int i = 0; i < str.Length; i++)
            if (str[i] != str[(str.Length - i)]) return 0;
        return 1;
    }

    /// <summary>
    /// Разбивает массив на два массива, где в одном - все элементы меньше опорного(в левом),
    /// в другом - больше(в правом), опорный элемент возвращается отдельно).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="LeftArr"></param>
    /// <param name="RightArr"></param>
    /// <param name="BaseEl"></param>
    public static void SplitArr<T>(in T[] Arr, out T[] LeftArr, out T[] RightArr, out T BaseEl) //Debugged
    {
        List<T> LeftArrO = new List<T>();
        List<T> RightArrO = new List<T>();
        int BaseIndex = Arr.Length / 2, Compare;
        for (int i = 0; i < Arr.Length; i++)
        {
            if (i != BaseIndex)
            {
                Compare = Comparer<T>.Default.Compare(Arr[i], Arr[BaseIndex]);
                if (Compare < 0) LeftArrO.Add(Arr[i]);
                else RightArrO.Add(Arr[i]);
            }
        }
        LeftArr = LeftArrO.ToArray();
        RightArr = RightArrO.ToArray();
        BaseEl = Arr[BaseIndex];

    }

    /// <summary>
    /// Соединяет два массива в один, между ними вставляет опорный элемент.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="LeftArr"></param>
    /// <param name="RightArr"></param>
    /// <param name="BaseEl"></param>
    /// <returns></returns>
    public static T[] CombineArrs<T>(T[] LeftArr, in T[] RightArr, in T BaseEl) //Debugged
    {
        Array.Resize(ref LeftArr, LeftArr.Length + RightArr.Length + 1);
        RightArr.CopyTo(LeftArr, LeftArr.Length - RightArr.Length);
        LeftArr[LeftArr.Length - RightArr.Length - 1] = BaseEl;
        return LeftArr;
    }

    /// <summary>
    /// Соединяет два массива в один.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="LeftArr"></param>
    /// <param name="RightArr"></param>
    /// <param name="BaseEl"></param>
    /// <returns></returns>
    public static T[] CombineArrs<T>(T[] LeftArr, in T[] RightArr) //Debugged
    {
        Array.Resize(ref LeftArr, LeftArr.Length + RightArr.Length);
        RightArr.CopyTo(LeftArr, LeftArr.Length - RightArr.Length);
        return LeftArr;
    }

    /// <summary>
    /// Возвращает цифру из числа по индексу.
    /// </summary>
    /// <param name="Num"></param>
    /// <param name="Index"></param>
    /// <returns></returns>
    public static int GetDigitByIndex(in int Num, in int Index) //Debugged
    {
        return (Num / Pow(10, NumLen(Num) - Index-1) % 10);
    }

    /// <summary>
    /// Возвращает нуль, если входное число меньше нуля.
    /// Иначе - входное число.
    /// </summary>
    /// <param name="Num"></param>
    /// <returns></returns>
    public static int NotLessThenZero(in int Num) //Debugged
    {
        if (Num < 0) return 0;
        return Num;
    }

    /// <summary>
    /// Вставляет значение в коллекцию по заданному индексу.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <param name="Index"></param>
    public static void InsertToArr<T>(ref T[]Arr, in T Value, in int Index) //Debugged
    {
        Array.Resize(ref Arr, Arr.Length + 1);
        for (int i = Arr.Length-1; i>Index; i--)
        {
            Arr[i] = Arr[i - 1];
        }
        Arr[Index] = Value;
    }

    /// <summary>
    /// Вставляет значение в коллекцию по заданному индексу.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <param name="Index"></param>
    public static void InsertToList<T>(ref List<T> Arr, in T Value, in int Index) //Debugged
    {
        Arr.Insert(Index, Value);
    }

    /// <summary>
    /// Меняет местами два элемента  коллекции.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    public static T[] Swap<T>(T[]Arr, in int i1, in int i2)
    {
        if (Arr.Length < Max(i1, i2) || i2 < 0 || i1 < 0) throw new Exception("Invalid params");
        T temp = Arr[i1];
        Arr[i1] = Arr[i2];
        Arr[i2] = temp;
        return Arr;
    }

    /// <summary>
    /// Меняет местами два элемента коллекции.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    public static void Swap<T>(List<T>Arr, in int i1, in int i2)
    {
        if (Arr.Count < Max(i1, i2) || i2 < 0 || i1 < 0) throw new Exception("Invalid params");
        T temp = Arr[i1];
        Arr[i1] = Arr[i2];
        Arr[i2] = temp;
    }

    /// <summary>
    /// Возвращает наибольшее из переданных значений.
    /// </summary>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    /// <returns></returns>
    public static int Max(in int i1,in int i2)
    {
        return i1 > i2 ? i1 : i2;
    }

    /// <summary>
    /// Возвращает наименьшее из переданных значений.
    /// </summary>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    /// <returns></returns>
    public static int Min(in int i1, in int i2)
    {
        return i1 < i2 ? i1 : i2;
    }

    /// <summary>
    /// Возвращает наибольшее из переданных значений.
    /// </summary>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    /// <returns></returns>
    public static T Max<T>(in T i1, in T i2)
    {
        return Comparer<T>.Default.Compare(i1, i2) > 0 ? i1 : i2;
    }

    /// <summary>
    /// Возвращает наименьшее из переданных значений.
    /// </summary>
    /// <param name="i1"></param>
    /// <param name="i2"></param>
    /// <returns></returns>
    public static T Min<T>(in T i1, in T i2)
    {
        return Comparer<T>.Default.Compare(i1, i2) < 0 ? i1 : i2;
    }

    /// <summary>
    /// Заменяет цифру в числе по индексу.
    /// </summary>
    /// <param name="Value"></param>
    /// <param name="Index"></param>
    /// <param name="NewNum"></param>
    /// <returns></returns>
    public static int ChangeNumByIndex(in int Value, int Index, in int NewNum)
    {
        if (NumLen(Value) < Index) throw new IndexOutOfRangeException();
        Index = NumLen(Value) - Index - 1;
        return (int)(Value - ((Value / (int)Math.Pow(10, Index)) % 10) * Math.Pow(10, Index) + NewNum * Math.Pow(10, Index));
    }
    /// <summary>
    /// Заменяет символ по индексу.
    /// </summary>
    /// <param name="Value"></param>
    /// <param name="Index"></param>
    /// <param name="NewChar"></param>
    /// <returns></returns>
    public static char[]ChangeSymByIndex(char[]Value, in int Index, in char NewChar)
    {
        if (Value.Length < Index) throw new IndexOutOfRangeException();
        Value[Value.Length - Index - 1] = NewChar;
        return Value;
    }
    /// <summary>
    /// Заменяет символ по индексу.
    /// </summary>
    /// <param name="Value"></param>
    /// <param name="Index"></param>
    /// <param name="NewChar"></param>
    /// <returns></returns>
    public static string ChangeSymByIndex(in string Value, in int Index, in char NewChar)
    {
        return new string(ChangeSymByIndex(Value.ToCharArray(), Index, NewChar));
    }

    public static char[][] RecombinateString(char[] str, in int StartIndex=0)
    {
        if (StartIndex == str.Length - 1) return new char[][] { };
        //char[,] Out = new char[Factorial(str.Length), str.Length];
        for(int i = StartIndex; i < str.Length; i++)
        {
            Console.WriteLine("STEP");
            for(int r = 0; r < str.Length; r++)
            {
                Console.WriteLine(new string(Swap(str, i, r)));
                RecombinateString(Swap(str, i, r), StartIndex + 1);
            }
        }


        return new char[][] { };
    }
    public static int Factorial(int Val)
    {
        int Out = 1;
        for (; Val > 0; Val--) Out *= Val;
        return Val;
    }

}