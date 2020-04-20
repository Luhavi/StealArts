using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public GameObject map;
    bool Open = true;
    
	public void OpenMap () {
        map.SetActive(Open);
        Open = !Open;
	}
}
