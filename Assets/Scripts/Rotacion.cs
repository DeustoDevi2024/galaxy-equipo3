using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation *= Quaternion.Euler(0.0f, (speed/rb.mass), 0.0f);
    }
}
