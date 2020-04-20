using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Art : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Player.getart = 1;
            Destroy(this.gameObject);
        }
    }
}
