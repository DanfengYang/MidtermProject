using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//
        Ray2D myRay1 = new Ray2D(transform.position, Vector2.left);
        Ray2D myRay2 = new Ray2D(transform.position, Vector2.right);
        Ray2D myRay3 = new Ray2D(transform.position, Vector2.up);
        Ray2D myRay4 = new Ray2D(transform.position, Vector2.down);

        float maxRayDist = 3f;
        //visualize the raycast
        Debug.DrawRay(myRay1.origin, myRay1.direction * maxRayDist, Color.yellow);
        Debug.DrawRay(myRay2.origin, myRay2.direction * maxRayDist, Color.yellow);
        Debug.DrawRay(myRay3.origin, myRay3.direction * maxRayDist, Color.yellow);
        Debug.DrawRay(myRay4.origin, myRay4.direction * maxRayDist, Color.yellow);
        //RaycastHit2D myRayHit = Physics2D.Raycast();
    }
}
