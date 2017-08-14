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
      States[state.Name].GetComponent<Renderer>().sharedMaterial = UnemploymentDataMaterials[state.UnemploymentDecile / 3];
    }
  }

  public void ColorizeByElectionData()
  {

    // get the election data
    var dataList = ElectionService.Results;

    foreach (var result in dataList)
    {
      States[result.StateName].GetComponent<Renderer>().sharedMaterial = ElectionDataMaterials[result.Result == "Trump" ? 0 : 1];
    }
  }

  public void ResetColors()
  {

    var stateList = StatesService.states_names;
    foreach (var state in stateList)
    {
      States[state].GetComponent<Renderer>().sharedMaterial = DefaultMaterial;
    }
  }

  void Update()
  {

  }
}