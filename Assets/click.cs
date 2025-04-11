using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    // Start is called before the first frame update
    public clickamountscript cs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        cs.clicks = cs.clicks + (1 * cs.clickBoost);
        cs.clicksamount.color = Color.white; // Make sure the text isn't black on a black background
        cs.clicksamount.gameObject.SetActive(true); // Force-enable the text
    }
}
