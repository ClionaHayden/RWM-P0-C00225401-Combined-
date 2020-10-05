using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return DecrementIfLessThanFirst.decrements(CubeFilter.fact(xs));
    }
}

