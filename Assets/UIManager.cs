using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameClear;
    public GameObject gameOver;
    void Start()
    {
        //StartCoroutine("setup");
        //GameManager.instance.MyCard[0].GetComponent<UnitGen>().num;
    }

    void Update()
    {
        if (GameManager.instance.MyFi.Count == 0)
            gameOver.SetActive(true);
        else if (GameManager.instance.EnCard.Count == 0)
            gameClear.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
