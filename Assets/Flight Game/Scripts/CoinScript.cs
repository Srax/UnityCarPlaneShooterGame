using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 90 * Time.deltaTime, -90 * Time.deltaTime);
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
