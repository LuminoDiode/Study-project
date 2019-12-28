using System;
using System.Collections.Generic;

// Array<T>
static partial class Binary
{
    /// <summary>
    /// Возвращает индекс элемента из переданной коллекции.
    /// Если элементы не найден возвращает -1.
    /// </summary>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int Search<T>(in T[] Arr, in T Value) where T : struct //Debugged
    {
        int Min = 0, Max = Arr.Length, Mid, Compare;
        while (Min != Max - 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = Comparer<T>.Default.Compare(Value, Arr[Mid]);
            if (Compare < 0) Max = Mid;
            else if (Compare > 0) Min = Mid;
            else return Mid;
        }
        return -1; ; // Not Found
    }

    /// <summary>
    /// Возвращает индекс, на которые следует вставить в сортированную коллекцию
    /// переданный элемент, что бы сохранить сортировку.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int InsertionIndex<T>(in T[] Arr, in T Value) where T : struct //Debugged
    {
        //Если элемент больше последнего.
        int Compare = Comparer<T>.Default.Compare(Value, Arr[Arr.Length - 1]); ;
        if (Compare > 0) return Arr.Length;

        int Min = 0, Max = Arr.Length, Mid;
        while (Max - Min != 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = Comparer<T>.Default.Compare(Value, Arr[Mid]);
            if (Compare < 0) Max = Mid;
            else if (Compare > 0) Min = Mid;
            else return Mid;
        }
        return Comparer<T>.Default.Compare(Value, Arr[Min]) < 0 ? Min : Max;
    }

    /// <summary>
    /// Вставляет элемент в сортированную коллекцию
    /// с сохранением сортировки.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    public static void Insert<T>(ref T[] Arr, in T Value) where T : struct //Debugged
    {
        General.InsertToArr(ref Arr, Value, InsertionIndex(Arr, Value));
    }
}

// List<T>
static partial class Binary
{
    /// <summary>
    /// Возвращает индекс элемента из переданной коллекции.
    /// Если элементы не найден возвращает -1.
    /// </summary>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int Search<T>(in List<T> Arr, in T Value) where T : struct //Debugged
    {
        int Min = 0, Max = Arr.Count, Mid, Compare;
        while (Min != Max - 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = Comparer<T>.Default.Compare(Value, Arr[Mid]);
            if (Compare < 0) Max = Mid;
            else if (Compare > 0) Min = Mid;
            else return Mid;
        }
        return -1; ; // Not Found
    }

    /// <summary>
    /// Возвращает индекс, на которые следует вставить в сортированную коллекцию
    /// переданный элемент, что бы сохранить сортировку.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int InsertionIndex<T>(in List<T>Arr, in T Value) where T : struct //Debugged
    {
        //Если элемент больше последнего.
        int Compare = Comparer<T>.Default.Compare(Value, Arr[Arr.Count - 1]); ;
        if (Compare > 0) return Arr.Count;

        int Min = 0, Max = Arr.Count, Mid;
        while (Max - Min != 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = Comparer<T>.Default.Compare(Value, Arr[Mid]);
            if (Compare < 0) Max = Mid;
            else if (Compare > 0) Min = Mid;
            else return Mid;
        }
        return Comparer<T>.Default.Compare(Value, Arr[Min]) < 0 ? Min : Max;
    }

    /// <summary>
    /// Вставляет элемент в сортированную коллекцию
    /// с сохранением сортировки.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    public static void Insert<T>(ref List<T> Arr, in T Value) where T : struct //Debugged
    {
        General.InsertToList(ref Arr, Value, InsertionIndex(Arr, Value));
    }
}

// Array<string>
static partial class Binary
{
    /// <summary>
    /// Возвращает индекс элемента из переданной коллекции.
    /// Если элементы не найден возвращает -1.
    /// </summary>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int Search(in string[] Arr, in string Value) //Debugged
    {
        int Min = 0, Max = Arr.Length, Mid, Compare;
        while (Min != Max - 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = General.CompareStrings(Value, Arr[Mid]);
            if (Compare == 1) Max = Mid;
            else if (Compare == 2) Min = Mid;
            else return Mid;
        }
        return -1; // Not Found
    }

    /// <summary>
    /// Возвращает индекс, на которые следует вставить в сортированную коллекцию
    /// переданный элемент, что бы сохранить сортировку.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int InsertionIndex(in string[] Arr, in string Value) //Debugged
    {
        //Если элемент больше последнего.
        int Compare = General.CompareStrings(Value, Arr[Arr.Length - 1]);
        if (Compare == 2) return Arr.Length;

        int Min = 0, Max = Arr.Length, Mid;
        while (Min != Max - 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = General.CompareStrings(Value, Arr[Mid]);
            if (Compare == 1) Max = Mid;
            else if (Compare == 2) Min = Mid;
            else return Mid;
        }
        return General.CompareStrings(Value, Arr[Min]) == 1 ? Min : Max;
    }

    /// <summary>
    /// Вставляет элемент в сортированную коллекцию
    /// с сохранением сортировки.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    public static void Insert(ref string[] Arr, in string Value) //Debugged
    {
        General.InsertToArr(ref Arr, Value, InsertionIndex(Arr, Value));
    }
}

// List<string>
static partial class Binary
{
    /// <summary>
    /// Возвращает индекс элемента из переданной коллекции.
    /// Если элементы не найден возвращает -1.
    /// </summary>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int Search(in List<string> Arr, in string Value) //Debugged
    {
        int Min = 0, Max = Arr.Count, Mid, Compare;
        while (Min != Max - 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = General.CompareStrings(Value, Arr[Mid]);
            if (Compare == 1) Max = Mid;
            else if (Compare == 2) Min = Mid;
            else return Mid;
        }
        return -1; // Not Found
    }

    /// <summary>
    /// Возвращает индекс, на которые следует вставить в сортированную коллекцию
    /// переданный элемент, что бы сохранить сортировку.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    /// <returns></returns>
    public static int InsertionIndex(in List<string> Arr, in string Value) //Debugged
    {
        //Если элемент больше последнего.
        int Compare = General.CompareStrings(Value, Arr[Arr.Count - 1]);
        if (Compare == 2) return Arr.Count;

        int Min = 0, Max = Arr.Count, Mid;
        while (Min != Max - 1)
        {
            Mid = General.Middle(Min, Max);
            Compare = General.CompareStrings(Value, Arr[Mid]);
            if (Compare == 1) Max = Mid;
            else if (Compare == 2) Min = Mid;
            else return Mid;
        }
        return General.CompareStrings(Value, Arr[Min]) == 1 ? Min : Max;
    }

    /// <summary>
    /// Вставляет элемент в сортированную коллекцию
    /// с сохранением сортировки.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="Value"></param>
    public static void Insert(ref List<string> Arr, in string Value) //Debugged
    {
        General.InsertToList(ref Arr, Value, InsertionIndex(Arr, Value));
    }
}
