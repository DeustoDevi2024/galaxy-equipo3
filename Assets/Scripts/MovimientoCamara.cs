using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public int speed;
    private float horizontal;
    private float vertical;
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
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        this.transform.Translate(new Vector3(horizontal * speed * Time.deltaTime, 0.0f, vertical * speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(new Vector3(0.0f, speed * Time.deltaTime, 0.0f));
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.Translate(new Vector3(0.0f, -speed * Time.deltaTime, 0.0f));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.rotation *= Quaternion.Euler(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.rotation *= Quaternion.Euler(0, speed * Time.deltaTime, 0);
        }
    }
}
