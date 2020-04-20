using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
    public GameObject cube;
    float time;
    bool start = false;
    Vector3 cubevec;
    float speed = 1.5f;

    void Start()
    {
        cubevec = cube.transform.position;
    }

    void Update()
    {
        if (start && time <= 1) {
            time += speed * Time.deltaTime;
            cube.transform.position = Vector3.Lerp(cubevec, new Vector3(cube.transform.position.x, 1, cube.transform.position.z), time);
        }
    }

	void OnTriggerEnter(Collider Col)
    {
        if(Col.tag == "Player")
        {
            start = true;
        }

    }
}
