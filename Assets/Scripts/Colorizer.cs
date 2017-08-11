using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorizer : MonoBehaviour
{

    public Dictionary<string, Transform> States = new Dictionary<string, Transform>();
    public Material[] UnemploymentDataMaterials;
    public Material[] ElectionDataMaterials;
    public Material DefaultMaterial;
    void Awake()
    {
        var states = this.transform.GetComponentsInChildren<Transform>();
        foreach (var state in states)
        {
            if (state == this.transform) continue;
            this.States.Add(state.name.Trim(), state);
        }

        // just for debugging
        // ColorizeByElectionData();
    }
    public void ColorizeByUnemployment()
    {
        var dataList = UnemploymentDataService.UnemploymentDataList;

        foreach (var state in dataList)
        {
            // Debug.Log(state.Name);

            States[state.Name].GetComponent<Renderer>().sharedMaterial = UnemploymentDataMaterials[state.UnemploymentDecile / 3];
        }
    }

	public void ColorizeByElectionData(){

		// get the election data
		var dataList = UnemploymentDataService.UnemploymentDataList;

        foreach (var state in dataList)
        {
            // Debug.Log(state.Name);

			// 
            States[state.Name].GetComponent<Renderer>().sharedMaterial = DefaultMaterial;
        }
	}

	public void ResetColors(){

        foreach (var state in dataList)
        {
            // Debug.Log(state.Name);

			// 
            States[state.Name].GetComponent<Renderer>().sharedMaterial = ElectionDataMaterials[Random.Range(0,2)];
        }
	}

    void Update()
    {

    }
}