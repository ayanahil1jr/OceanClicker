using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rebirth : MonoBehaviour
{
    public RebirthMenu rebmenu;
    public RebirthMenu rebScript;
    public clickamountscript cASScript;
    public buttonprices bp1;
    public buttonprices bp2;
    public buttonprices bp3;
    public double boostAmount;
    public int targetAmount;
    public Boolean isTranscend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if(cASScript.clicks >= rebScript.targetcost)
        {
            
            if(isTranscend)
            {
                rebmenu.rebirthCount = 0;
                rebmenu.targetcost = rebmenu.originalcost;
                cASScript.clickBoost = (double)Math.Pow(5, rebScript.rebirthCount);
            }
            cASScript.clicks = 0;
            rebScript.rebirthCount++;
            rebScript.targetcost *= targetAmount;
            cASScript.clickBoost = ((double)Math.Pow(boostAmount, rebScript.rebirthCount) * ((double)Math.Pow(5, rebmenu.rebirthCount)));
            bp1.price1 = bp1.originalPrice;
            bp2.price1 = bp2.originalPrice;
            bp3.price1 = bp3.originalPrice;
        }
    }
}
