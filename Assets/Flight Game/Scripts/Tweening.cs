using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweening : MonoBehaviour
{
    /*private Vector3 startPos;
    private Vector3 pos1; //new Vector3(-4, 0, 0);
    private Vector3 pos2; //new Vector3(4, 0, 0);
    public float speed = 0.5f;
    */

    public float smoothTime = 0.5F;
    public Transform target1;
    public Transform target2;
    private Vector3 velocity = Vector3.zero;



    public bool moveBoolean = true;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ToggleBool(moveBoolean));

    }

    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition1 = target1.TransformPoint(new Vector3(0, 0, 0));
        Vector3 targetPosition2 = target2.TransformPoint(new Vector3(0, 0, 0));

        if (moveBoolean == true)
        {
            // Smoothly move the camera towards that target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition1, ref velocity, smoothTime);
        } else
        {
            // Smoothly move the camera towards that target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition2, ref velocity, smoothTime);
        }
        //transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }




    IEnumerator ToggleBool(bool mybobol)
    {
        while(true)
        {
            //Generate two random numbers between 3 to 10 seconds
            float rnd1 = Random.Range(10f, 20f);
            float rnd2 = Random.Range(10f, 20f);

            
            yield return new WaitForSeconds(rnd1); //wait x seconds
            moveBoolean = false; //set moveBoolean to false (move left)
            print(rnd1); //print value of rnd1

            yield return new WaitForSeconds(rnd2); //wait x seconds
            moveBoolean = true; //set moveBoolean to true (move right)
            print(rnd2); //print value of rnd2
        }
    }
}



