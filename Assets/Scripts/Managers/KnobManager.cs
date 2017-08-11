using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnobManager : MonoBehaviour
{
    public void UpdateData(string text, Color color)
    {
        this.transform.GetComponentInChildren<Text>().text = text;
        this.transform.GetComponentInChildren<Image>().color = color;
    }
}
