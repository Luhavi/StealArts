using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float movespeed = 1;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Time.deltaTime * movespeed, 0, 0);
        if(this.transform.position.x > 11)
        {
            Destroy(this.gameObject);
        }
    }
}
