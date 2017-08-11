using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountiesService
{

    // return the list of all the counnties sorted into states
    public static string[] Counties
    {
        get
        {
            var countiesString = (Resources.Load("counties_only", typeof(TextAsset)) as TextAsset).text;
            countiesString = countiesString.Trim();
            var _Counties = new List<string>();
            var countiesStringArray = countiesString.Split('\n');
            return countiesStringArray;
        }
    }
}


