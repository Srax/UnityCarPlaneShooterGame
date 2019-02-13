using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    public string tagname = "Player";

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == tagname)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();  // plays sound when collided.
            col.GetComponent<PlayerScript>().points++;
            Destroy(gameObject);
            Debug.Log("Removed Coin");
        }
    }
}
