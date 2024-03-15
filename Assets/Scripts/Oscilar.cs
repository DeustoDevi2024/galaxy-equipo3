using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilar : MonoBehaviour
{
    private double x = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        this.transform.Translate(new Vector3(0.0f, 0.0f, (float)((Math.Sin(x) * 20) * Time.deltaTime * 0.1)));
        x++;
    }
}
