using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int getart = 0;
    public static int getKey = 0;

    void Update()
    {

        GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");

        if (targets != null)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                Vector3 len = targets[i].transform.position - transform.position;
                if (len.magnitude < 1)
                {
                    Destroy(gameObject);
                    getart = 0;
                    SceneManager.LoadScene("GameOver");
                    break;
                }
            }
        }
    }
    
}
