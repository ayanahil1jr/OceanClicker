using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RebirthMenu : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject rebirthbutton;
    public TMP_Text rebirth;
    public TMP_Text description;
    public double originalcost = 1500000;
    public double targetcost;
    public TMP_Text cost;
    public int rebirthCount = 0;
    public TMP_Text rebCount;
    public clickamountscript cASScript;
    public String rebType;
    public String boost;
    public RebirthMenu otherMenu;
    void Start()
    {
        mainScreen.SetActive(false); 
        rebirthbutton.SetActive(false);
        rebirth.text = "";
        description.text = "";
        cost.text = "";
        rebCount.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (mainScreen.activeInHierarchy == true)
        {
            cost.text = cASScript.FormatNumber(targetcost);
            rebCount.text = rebType + "s: " + rebirthCount + "";
        }
    }


    public void OnMouseDown()
    {
        if (mainScreen.activeInHierarchy == false)
        {
            mainScreen.SetActive(true);
            rebirthbutton.SetActive(true);
            rebirth.text = rebType + "!";
            description.text = boost + "x Clicks Per " + rebType;
            cost.text = cASScript.FormatNumber(targetcost);
            rebCount.text = rebType + ": " + rebirthCount + "";
            if (otherMenu.mainScreen.activeInHierarchy == true)
            {
                otherMenu.DeactivateScreen();
            }
        }
        else { DeactivateScreen(); }
    }
    public void DeactivateScreen()
    {
        if (mainScreen.activeInHierarchy == true)
        {
            mainScreen.SetActive(false);
            rebirthbutton.SetActive(false);
            rebirth.text = "";
            description.text = "";
            cost.text = "";
            rebCount.text = "";
        }
    }
}
