using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{
    public string tagName = "";
    public GameObject explosion; // drag your explosion prefab here

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == tagName)
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(col.gameObject);
            Destroy(expl, 1); // delete the explosion after 3 seconds
        }
    }
}
