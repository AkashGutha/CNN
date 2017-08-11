using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{

    public GameObject UnemploymentRateUI;
    public Colorizer USA_Colorizer;

    public void ChangeView(int viewId)
    {
        ResetState();

        switch (viewId)
        {
            case 0:

                break;
            //  unemployment view
            case 1:
                // set the unemployment rate to active
                UnemploymentRateUI.SetActive(true);
                USA_Colorizer.ColorizeByUnemployment();
                break;
            default:

                break;
        }
    }

	void ResetState(){
        USA_Colorizer.ResetColors();
        UnemploymentRateUI.SetActive(false);
    }
}
