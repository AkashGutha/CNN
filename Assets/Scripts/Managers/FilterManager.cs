using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CNN;

public class FilterManager : MonoBehaviour
{

    public ViewManager viewManager;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        viewManager.SetFilter(Filter.None);
    }
    public void FilterData(Int32 index)
    {
        Debug.Log(index);
        viewManager.SetFilter((Filter)index);
    }
}
