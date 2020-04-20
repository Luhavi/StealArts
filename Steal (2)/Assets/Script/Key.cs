using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            this.gameObject.transform.position = col.transform.position;
        }
    }
}
