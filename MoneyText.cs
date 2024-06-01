using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using static BreakInfinity.BigDouble;

public class MoneyText : MonoBehaviour
{
    
    public string ConvertBigNumberToString(BigDouble x)
    {
        
        var exponent = Floor(Log10(x));
        var thirdExponent = 3 * Floor(exponent / 3);
        var mantissa = (x / Pow(10,thirdExponent));
        if (x<1000)
        {
            return x.ToString("F2");
        }
        if (x>=1e84)
        {
            return mantissa.ToString("F2") + "e" + thirdExponent;
            
        }
        if (x>=1000)
        {
            return mantissa.ToString("F2") + prefixes[(int)thirdExponent.ToDouble()];
        }
       
        return "0";
       
     
    }
    
    private static readonly Dictionary<int,string> prefixes = new Dictionary<int, string>
    {
        {3,"K" },
        {6,"m" },
        {9,"T" },
        {12,"Aa" },
        {15,"Ab" },
        {18,"Ac" },
        {21,"Ad" },
        {24,"Ba" },
        {27,"Bb" },
        {30,"Bc" },
        {33,"Bd" },
        {36,"Ca" },
        {39,"Cb" },
        {42,"Cc" },
        {45,"Cd" },
        {48,"Da" },
        {51,"Db" },
        {54,"Dc" },
        {57,"Dd" },
        {60,"Ea" },
        {63,"Eb" },
        {66,"Ec" },
        {69,"Ed" },
        {72,"Fa" },
        {75,"Fb" },
        {78,"Fc" },
        {81,"Fd" }

    };
}
