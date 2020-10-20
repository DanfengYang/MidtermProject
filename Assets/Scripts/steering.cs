using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//enermies sensing walls on them 
public class steering : MonoBehaviour
{  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//move along the x axis
        transform.Translate(5f * Time.deltaTime, 0f, 0f);
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myMaxRayDist = 1.5f;
        Debug.DrawRay(myRay.origin, myRay.direction * myMaxRayDist);

        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDist);



        //did the raycast hit
        if (myRayHit.collider != null)
        {
            if (myRayHit.collider.tag == "Player")
            {
                Global.health -= 1;
                Debug.Log(Global.health);
            }
            else
            {

                float randomNumber = Random.Range(0, 100);
                if (randomNumber < 50)
                {
                    //50% chances to turn left or right

                    transform.Rotate(0, 0, 90f);
                }
                else
                {
                    transform.Rotate(0, 0, -90f);
                }

            }
        }

        

        
    }
}
