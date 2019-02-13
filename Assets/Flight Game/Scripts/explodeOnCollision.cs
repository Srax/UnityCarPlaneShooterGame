using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeOnCollision : MonoBehaviour
{
    public string tagName = "Ground";
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == tagName)
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(expl, 1); // delete the explosion after 3 seconds
        }
    }
}
