using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private GameObject gO;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        gO = GameObject.Find("Asteroids Belt");
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }

    private void rotate()
    {
        this.transform.rotation *= Quaternion.Euler(0.0f, (speed / rb.mass) * Time.deltaTime, 0.0f); 
    }
}
