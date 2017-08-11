using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeHeights : MonoBehaviour
{
    public float heightOffset;
    public float originalHeight;
    void Awake()
    {
        originalHeight = this.transform.position.z;
        Randomize();

    }

    public void Randomize()
    {
        var children = gameObject.GetComponentsInChildren<Transform>();
        for (int i = 0; i < children.Length; i++)
        {
            if (children[i] == this.transform) continue;

            // got all children excluding the parent
            var r = Random.Range(-0.2f, 0.1f);
            children[i].transform.position += new Vector3(0, 0, r);
        }

    }

    public void ResetHeights()
    {
        var children = gameObject.GetComponentsInChildren<Transform>();
        for (int i = 0; i < children.Length; i++)
        {
            if (children[i] == this.transform) continue;

            children[i].transform.position = new Vector3(children[i].transform.position.x, children[i].transform.position.y, this.originalHeight);
        }

    }
}