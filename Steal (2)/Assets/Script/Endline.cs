using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endline : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if(Player.getart == 1)
            {
                if (ButtonManager.num == ButtonManager.gamenum)
                {
                    ButtonManager.num++;
                }
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
