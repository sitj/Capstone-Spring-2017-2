using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icycle : MonoBehaviour {
    private float X;
    private float Y;
    private float Z;
    bool destroyed = false;
    private Vector3 spawnPot;
    // Update is called once per frame
    void Start()
    {
        spawnPot = gameObject.transform.position;
    }
    void OnCollisionEnter2D(Collision2D other) {
        var spawnRot = gameObject.transform.rotation;
        if (destroyed == false)
        {
            if (other.gameObject.tag == "ground")
            {
                gameObject.transform.position = spawnPot;
            }
        }

    }
}
