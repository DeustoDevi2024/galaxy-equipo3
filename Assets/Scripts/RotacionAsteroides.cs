using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAsteroides : MonoBehaviour
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
        rotate();
    }

    private void rotate()
    {
        this.transform.rotation *= Quaternion.Euler(0.0f, 0.0f, (speed / rb.mass) * Time.deltaTime);
    }
}
