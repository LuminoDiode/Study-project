using System;


static class Graph
{
    //public static int MinWay = 0;
    // Генери
    public static int[,] RandomCtScheme(int CtNum, int MinDist = 2, int MaxDist = 10)
    {
        // -1 Current ct
        // 0  No connection
        // x  Distance
        int[,] Cts = new int[CtNum, CtNum];
        for (int i = 0; i < CtNum; i++)
            for (int r = 0; r < CtNum; r++)
            {
                Cts[r, i] = Cts[i, r] = General.RandomInt(MinDist, MaxDist);
                if (r == i) Cts[r, i] = -1;
            }
        return Cts;
    }
    /*public static int ShortestWay(in int[,] CtScheme, in int FromCt = 0, int ToCt = int.MaxValue)
    {
        int ToCtCheck = (int)Math.Sqrt(CtScheme.Length) - 1;
        if (ToCt == int.MaxValue) ToCt = (int)ToCtCheck;
        else if (ToCt > ToCtCheck) return -1;

        int FromCtCheck = (int)Math.Sqrt(CtScheme.Length)-1;
        if (FromCt > FromCtCheck || FromCt > ToCt) return -1;

        return GetShortestWay(CtScheme,FromCt, (int)(ToCtCheck), 0, FromCt==0 ? 1:0);
    }*/
    /*private static int ShortestWayP(in int[,] CtScheme, in int FromCt, in int ToCt, in int OnGoing=0, int OnlyForward=0)
    {
        if (FromCt == ToCt) return 0;
        else if (FromCt == 0) OnlyForward = 1;

        int
            ToCheck = (int)Math.Sqrt(CtScheme.Length),
            MinDist = int.MaxValue,
            Current;
        
        for(int i = ToCt; i < ToCheck; i++)
        {
            Current = ShortestWayP(CtScheme, ToCt, i, OnGoing + CtScheme[ToCt, i], OnlyForward);
            if (Current < MinDist) MinDist = Current;
        }

        return Dist.Where(x=>x!=0).Min();
    }*/

    /// <summary>
    /// Алгоритм вычисления кратчайшего пути от одного пункта графа до другого при условии движения только вперед.
    /// Рекурсивный.
    /// </summary>
    /// <param name="CtScheme"></param>
    /// <param name="FromCt"></param>
    /// <param name="ToCt"></param>
    /// <param name="OnGoing"></param>
    /// <param name="StartPassed"></param>
    /// <returns></returns>
    public /*private?*/ static int GetShortestWay(in int[,] CtScheme, in int FromCt, in int ToCt, in int OnGoing, int[]CtPassed)
    {
        if (FromCt == ToCt) return OnGoing;
        int
            MinDist = int.MaxValue,
            Current;

        
        Console.WriteLine("CYCLE =>");
        for (int i = 0; i < CtPassed.Length; i++)
        {
            if (CtPassed[i] == 0 && CtScheme[FromCt, i]!=-1)
            {
                Console.WriteLine("I == "+i);
                Console.WriteLine("MOVE : FROM_{0} TO_{1}", FromCt, i);
                CtPassed[i] = 1;
                Current = GetShortestWay(CtScheme, i, ToCt, OnGoing + CtScheme[FromCt, i], CtPassed);
                if (Current < MinDist) MinDist = Current;
                CtPassed[i] = 0;
            }
        }
        Console.WriteLine("CYCLE <=");
        return MinDist;
    }

}