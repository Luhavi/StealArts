using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC : MonoBehaviour {

    GameObject[] nvas;

    void Start()
    {
        nvas = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Player")
        {
            foreach (GameObject nav in nvas) {
                nav.GetComponent<Nav>().b = 2;
            }
        }
    }
}
