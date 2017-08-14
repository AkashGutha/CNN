using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CNN;

public class ViewManager : MonoBehaviour
{
    Filter filter;
    View view;
    public Canvas canvas;
    public GameObject Knob;
    public Text Title;
    public GameObject UnemploymentRateUI;
    public Colorizer USA_Colorizer;
    public GameObject USA;

    public Color[] colors;

    public Dictionary<string, Transform> States = new Dictionary<string, Transform>();

    public GameObject textObj;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        ResetState();
        this.SetView(view);
        var states = USA.GetComponentsInChildren<Transform>();
        foreach (var state in states)
        {
            if (state == USA.transform) continue;
            this.States.Add(state.name.Trim(), state);
        }
    }

    public void ChangeView(int viewId)
    {
        SetView((View)viewId);
        Debug.Log("here");
        UpdateView();
    }

    public void UpdateView()
    {
        ResetState();

        if (view == View.None)
        {
            return;
        }
        else if (view == View.Unemployment)
        {
            Title.text = "U.S Unemploment";

            if (filter == Filter.None)
            {
                // UnemploymentRateUI.SetActive(true);
                USA_Colorizer.ColorizeByUnemployment();
                ActivateStateTexts();
            }

            if (filter == Filter.Elections_2016)
            {
                USA_Colorizer.ColorizeByElectionData();
                ActivateStateKnobs();
            }
        }
    }

    public void SetFilter(Filter f)
    {
        this.filter = f;
        UpdateView();
    }

    public void SetView(View v)
    {
        this.view = v;
    }

    void ResetState()
    {
        Title.text = "";
        USA_Colorizer.ResetColors();
        UnemploymentRateUI.SetActive(false);
        DeactivateStateKnobs();
        DeactivateStateTexts();
    }

    void ActivateStateKnobs()
    {
        // get the election data
        var dataList = UnemploymentDataService.UnemploymentDataList;

        foreach (var state in dataList)
        {

            Vector2 screenPos = Camera.main.WorldToScreenPoint(States[state.Name].position);

            var knob = Instantiate(this.Knob, Vector3.zero, Quaternion.identity);
            knob.transform.position = screenPos;
            knob.transform.SetParent(canvas.transform);
            string text = string.Format("{0:0.00}", state.UnemploymentRate * 100);
            knob.GetComponent<KnobManager>().UpdateData(text, colors[state.UnemploymentDecile / 3]);
        }


    }
    void ActivateStateTexts()
    {
        // get the election data
        var dataList = UnemploymentDataService.UnemploymentDataList;

        foreach (var state in dataList)
        {
            Vector2 screenPos = Camera.main.WorldToScreenPoint(States[state.Name].position);

            var spawn = Instantiate(this.textObj, Vector3.zero, Quaternion.identity);
            spawn.transform.position = screenPos;
            spawn.transform.SetParent(canvas.transform);
            string text = string.Format("{0:0.00}", state.UnemploymentRate * 100);
            spawn.GetComponent<Text>().text = text;
        }


    }

    void DeactivateStateKnobs()
    {
        var knobs = canvas.GetComponentsInChildren<Transform>();

        foreach (var knob in knobs)
        {
            if (knob.name == "Knob(Clone)")
            {
                Destroy(knob.gameObject);
            }
        }
    }



    void DeactivateStateTexts()
    {
        var texts = canvas.GetComponentsInChildren<Transform>();

        foreach (var text in texts)
        {
            if (text.name == "Text(Clone)")
            {
                Destroy(text.gameObject);
            }
        }
    }
}
