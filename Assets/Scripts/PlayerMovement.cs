using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //inputHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += new Vector3(0f, 0.1f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += new Vector3(0f, -0.1f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += new Vector3(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += new Vector3(0.1f, 0f, 0f);
        }

    }
}
    