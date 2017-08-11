﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesNamer : MonoBehaviour {

    void Awake()
    {
      var state_names = StatesService.states_names;
      var state_abbs = StatesService.states_abbrevation;

      var children = gameObject.GetComponentsInChildren<Transform>();
      for (int i = 0; i < children.Length - 1; i++)
      {
        // if (children[i] == this.transform) continue;
        children[i + 1].name = state_names[i];

        // children[i + 1].GetComponent<Renderer>().material = Resources.Load("States_Materials/MT_" + state_abbs[i] + "_" + state_names[i], typeof(Material)) as Material; ;
      }
    }
}
