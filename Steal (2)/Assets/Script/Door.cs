using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject target;
    public GameObject DS;

    void Update()
    {
        Vector3 len = target.transform.position - transform.position; // 목표지점에 다 달았을 때
        if (len.magnitude < 1)
        {
            Instantiate(DS);
            Destroy(this.gameObject);
            Destroy(target);
        }
    }
}
