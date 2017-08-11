using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Namer : MonoBehaviour
{
    void Start()
    {
        string[] Counties = CountiesService.Counties;

        var children = gameObject.GetComponentsInChildren<Transform>();
        for (int i = 0; i < children.Length - 1; i++)
        {
            // if (children[i] == this.transform) continue;
            children[i + 1].name = Counties[i];
        }
    }
}
