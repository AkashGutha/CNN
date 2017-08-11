using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIVisualizer : MonoBehaviour {

    public Text UnemploymentRate;
    public Vector3 Offset;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 screenPos = Camera.main.WorldToScreenPoint(this.transform.position + Offset);
        UnemploymentRate.transform.position = screenPos;
		
	}
}
