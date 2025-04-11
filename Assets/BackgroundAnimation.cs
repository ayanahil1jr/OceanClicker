using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimation : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        Vector2 move = new Vector2(0, 2);
        transform.Translate(move * Time.fixedDeltaTime * speed);
        if (transform.position.y > 5)
        {
            transform.position = new Vector2(transform.position.x, -10);
        }
    }
}
