using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    Transform target;
    float speed = 90f;
    float back_speed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Cube").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        float back_step = back_speed * Time.deltaTime;


        //if (Input.GetAxisRaw("Vertical") == 1)
        //{
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30f, 0, 0), step);
        //}
        //if (Input.GetAxisRaw("Vertical") == -1)
        //{
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-30f, 0, 0), step);
        //}
        //else if (Input.GetAxisRaw("Vertical") == 0)
        //{
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), back_step);
        //}

        //if (Input.GetAxisRaw("Horizontal") == 1)
        //{
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 30f), step);
        //}
        //if (Input.GetAxisRaw("Horizontal") == -1)
        //{
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, -30f), step);
        //}
        //else if (Input.GetAxisRaw("Horizontal") == 0)
        //{
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), back_step);
        //}

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30f, 0, 0), step);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-30f, 0, 0), step);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 30f), step);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, -30f), step);
        }

        else if(Input.GetKey(KeyCode.None))
        {
            transform.localEulerAngles = Vector3.zero;
        }

    }
}
