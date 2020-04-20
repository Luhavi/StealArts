using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
    public static int gamenum = 1;
    public static int num = 1;
    public GameObject[] stage;

	public void Scene1 () {
        SceneManager.LoadScene("1");
        gamenum = 1;
	}
    public void Scene2()
    {
        SceneManager.LoadScene("2");
        gamenum = 2;
    }
    public void Scene3()
    {
        SceneManager.LoadScene("3");
        gamenum = 3;
    }
    public void Scene4()
    {
        SceneManager.LoadScene("4");
        gamenum = 4;
    }
    public void Scene5()
    {
        SceneManager.LoadScene("5");
        gamenum = 5;
    }
    public void Scene6()
    {
        SceneManager.LoadScene("6");
        gamenum = 6;
    }
    public void Scene7()
    {
        SceneManager.LoadScene("7");
        gamenum = 7;
    }
    public void Scene8()
    {
        SceneManager.LoadScene("8");
        gamenum = 8;
    }
    public void Scene9()
    {
        SceneManager.LoadScene("9");
        gamenum = 9;
    }
    public void Scene10()
    {
        SceneManager.LoadScene("10");
        gamenum = 10;
    }
    public void Scene11()
    {
        SceneManager.LoadScene("11");
        gamenum = 11;
    }
    public void Scene12()
    {
        SceneManager.LoadScene("12");
        gamenum = 12;
    }
    public void Scene13()
    {
        SceneManager.LoadScene("13");
        gamenum = 13;
    }
    public void Scene14()
    {
        SceneManager.LoadScene("14");
        gamenum = 14;
    }
    public void Scene15()
    {
        SceneManager.LoadScene("15");
        gamenum = 15;
    }
    public void Scene16()
    {
        SceneManager.LoadScene("16");
        gamenum = 16;
    }
    public void Scene17()
    {
        SceneManager.LoadScene("17");
        gamenum = 17;
    }
    public void Stage()
    {
        SceneManager.LoadScene("Stage");
    }
    public void restart(){
        switch (gamenum)
        {
            case 1: Scene1(); break;
            case 2: Scene2(); break;
            case 3: Scene3(); break;
            case 4: Scene4(); break;
            case 5: Scene5(); break;
            case 6: Scene6(); break;
            case 7: Scene7(); break;
            case 8: Scene8(); break;
            case 9: Scene9(); break;
            case 10: Scene10(); break;
            case 11: Scene11(); break;
            case 12: Scene12(); break;
            case 13: Scene13(); break;
            case 14: Scene14(); break;
            case 15: Scene15(); break;
            default:
                break;
        }
    }
    public void Update()
    {
        Activestage(2);
        Activestage(3);
        Activestage(4);
        Activestage(5);
        Activestage(6);
        Activestage(7);
        Activestage(8);
        Activestage(9);
        Activestage(10);
        Activestage(11);
        Activestage(12);
        Activestage(13);
        Activestage(14);
        Activestage(15);
        Activestage(16);
        Activestage(17);
    }
    void Activestage(int n)
    {
        if (num >= n)
        {
            stage[n].SetActive(true);
        }
    }
}
