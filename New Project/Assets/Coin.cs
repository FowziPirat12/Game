using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    float time = 0;
    void Update()
    {
        float startYPos = 1.5f;
        float yPos = startYPos+  (float) Math.Sin(time);
        Vector3 position = transform.position;
        position.y = yPos;
        transform.position = position;

        time += Time.deltaTime;
    }
     void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            other.GetComponent<Player>().AddPoints(10);
            Destroy(gameObject);
        }

    }

}
