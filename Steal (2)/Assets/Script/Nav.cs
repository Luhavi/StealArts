using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour {

    public GameObject[] dest;
    public int i = 1;
    public  int b = 0;
    Transform tr;

    NavMeshAgent nma;
    Vector3 prevPos;

    // Use this for initialization
    void Start () {
        nma = GetComponent<NavMeshAgent>();
        dest[0] = GameObject.Find("Player");
        i = 1;
        b = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (i > dest.Length - 1) // 마지막에서 1번으로
        {
            nma.speed = 1.5f;
            i = 1;
        }
        if(b == 0)
        {
            nma.SetDestination(dest[i].transform.position);
            prevPos = transform.position;

        }else if (b == 1) // 플레이어가 보일때
        {
            nma.SetDestination(dest[0].transform.position);
            prevPos = transform.position;

        } else if (b == 2)
        {
            tr = dest[0].transform;
            b = 3;

        } else if (b == 3)// CCTV에 걸렸을 때
        {
            nma.SetDestination(tr.position);
            prevPos = transform.position;

        }

        Vector3 len = dest[i].transform.position - transform.position; // 목표지점에 다 달았을 때
        if (len.magnitude < 1)
        {
            nma.speed = 1.5f;
            i++;
            b = 0;
        }

        Vector3 len1 = dest[0].transform.position - transform.position; // 플레이어가 보이는 범위를 벗어났을 때
        if (len1.magnitude > 3)
        {
            nma.speed = 1.5f;
            if (b == 1)
            {
                b = 0;
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            b = 1;
            nma.speed = 3;
        }
    }
}
