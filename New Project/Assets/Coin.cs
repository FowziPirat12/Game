using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
     void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            Destroy(gameObject);
        }

    }

}
