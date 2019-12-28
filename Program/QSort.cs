using System;
static class QSort
{
    /// <summary>
    /// Быстрая сортировка.
    /// </summary>
    /// <param name="Arr"></param>
    /// <returns></returns>
    public static string[] Sort(string[] Arr)
    {
        if (Arr.Length < 2) return Arr;
        //else if (Arr.Length < 3) { SortTwo(ref Arr); return Arr; }
        string[] LeftArr; string[] RightArr; string BaseEl;
        General.SplitArr(Arr, out LeftArr, out RightArr, out BaseEl);
        return General.CombineArrs(Sort(LeftArr), Sort(RightArr), BaseEl);
    }

    /// <summary>
    /// Быстрая сортировка.
    /// </summary>
    /// <param name="Arr"></param>
    /// <returns></returns>
    public static T[] Sort<T>(T[] Arr)where T:struct //Debugged
    {
        if (Arr.Length < 2) return Arr; 
        T[] LeftArr; T[] RightArr; T BaseEl;
        General.SplitArr(Arr, out LeftArr, out RightArr, out BaseEl);
        return General.CombineArrs(Sort(LeftArr),Sort(RightArr),BaseEl);
    }
}
