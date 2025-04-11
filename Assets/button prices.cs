using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class buttonprices : MonoBehaviour
{
    public TMP_Text price;
    public int originalPrice;
    public clickamountscript cASScript;
    public double boostMulti;
    public double price1;
    public double priceMulti;
    public Boolean unlocked;
    public int unlockAmount;
    public RebirthMenu rebmenu;
    public TMP_Text buttonBoost;
    public int boughtAmount;


    void Start()
    {
    }

    void Update()
    {
        UnlockMechanic();
        if (unlocked)
        {
            price.text = cASScript.FormatNumber(price1);
            buttonBoost.text = boostMulti.ToString() + "x Clicks";
        }
        else
        {
            price.text = "Unlocked at " + unlockAmount.ToString() + " rebirth";
            buttonBoost.text = "";
        }

    }

    private void OnMouseDown()
    {

        if (cASScript.clicks >= price1 && unlocked)
        {
            cASScript.clicks -= price1;
            boughtAmount++;
            BoughtInitiate();
        }
    }

    public void UnlockMechanic()
    {
        if (!unlocked && rebmenu.rebirthCount >= unlockAmount)
        {
            unlocked = true;
        }
        if (rebmenu.rebirthCount < unlockAmount)
        {
            unlocked = false;
        }
    }

    public void BoughtInitiate()
    {
        cASScript.clickBoost = cASScript.clickBoost * boostMulti;
        price1 = Math.Round(price1 * priceMulti, 1);
    }
}
