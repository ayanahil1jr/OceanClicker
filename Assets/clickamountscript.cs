using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class clickamountscript : MonoBehaviour
{
    public TMP_Text clicksamount;
    public double clicks = 0;
    public double clickBoost = 1;

    void Start()
    {
        // Ensure everything is initialized if needed
    }

    void Update()
    {
            UpdateText();
     
    }

    void UpdateText()
    {
            clicksamount.text = "Clicks: " + FormatNumber(clicks);
    }

    public string FormatNumber(double num)
    {
        if (num >= 1e48) return num.ToString("0.##E+0");
        if (num >= 1e45) return (num / 1e45).ToString("0.##") + "QdDe";
        if (num >= 1e42) return (num / 1e42).ToString("0.##") + "TDe";
        if (num >= 1e39) return (num / 1e39).ToString("0.##") + "DDe";
        if (num >= 1e36) return (num / 1e36).ToString("0.##") + "UDe";
        if (num >= 1e33) return (num / 1e33).ToString("0.##") + "De";
        if (num >= 1e30) return (num / 1e30).ToString("0.##") + "No";
        if (num >= 1e27) return (num / 1e27).ToString("0.##") + "Oc";
        if (num >= 1e24) return (num / 1e24).ToString("0.##") + "Sp";
        if (num >= 1e21) return (num / 1e21).ToString("0.##") + "Sx";
        if (num >= 1e18) return (num / 1e18).ToString("0.##") + "Qn";
        if (num >= 1e15) return (num / 1e15).ToString("0.##") + "Qd";
        if (num >= 1e12) return (num / 1e12).ToString("0.##") + "T"; // Trillion
        if (num >= 1e9) return (num / 1e9).ToString("0.##") + "B";   // Billion
        if (num >= 1e6) return (num / 1e6).ToString("0.##") + "M";   // Million
        if (num >= 1e3) return (num / 1e3).ToString("0.##") + "K";   // Thousand
        return num.ToString("N0");
    }
}
