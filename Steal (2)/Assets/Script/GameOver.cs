using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    int CF;
    public GameObject Fail;
    public GameObject Clear;

	void Start () {
        if (Player.getart == 1)
        {
            Player.getart = 0;
            Instantiate(Clear);
        }
        else
        {
            Instantiate(Fail);
        } 
	}
}
