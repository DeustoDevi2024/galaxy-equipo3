using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation *= Quaternion.Euler(0.0f, speed * Time.deltaTime, 0.0f);
    }
}
