using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroyScript : MonoBehaviour
{

    void OnEnable()
    {
        Invoke("ReloadBullet", 10f); //time before reload
    }

    void ReloadBullet()
    {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke();
    }
}
