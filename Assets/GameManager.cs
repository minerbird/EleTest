using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using DG.Tweening;

[Serializable]
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public List<UnitData> MyFi = new List<UnitData>();
    public List<UnitData> EnFi = new List<UnitData>();
    
    public List<GameObject> MyCard = new List<GameObject>();
    public List<GameObject> EnCard = new List<GameObject>();

    public GameObject unitManager;
    public GameObject UnitGen;
    

    //gameObject.tag = "NewTag";
    void Start()
    {
        SetGame();
        GenCard(MyCard, MyFi, 0);
        GenCard(EnCard, EnFi, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetGame()
    {
        List<UnitData> Yebi = unitManager.GetComponent<UnitManager>().unitList;
        for (int i = 0; i < 3; i++)
        {
            int rand = UnityEngine.Random.Range(0, Yebi.Count);
            MyFi.Add(Yebi[rand]);
            Yebi.RemoveAt(rand);
        }
        EnFi = Yebi;
    }
    void GenCard(List<GameObject> CardL, List<UnitData> UnitL, float ypo)
    {
        UnitGen unit = UnitGen.GetComponent<UnitGen>();
        float xpo = 0;

        for (int i = 0; i < 3; i++)
        {
            GameObject curUnit = Instantiate(unit.Card, new Vector3(0, 0, 0), Quaternion.identity);
            UnitGen curStat = curUnit.GetComponent<UnitGen>();

            curStat.nameTxt.text = UnitL[i].name;
            curStat.hpTxt.text = UnitL[i].hp.ToString();
            curStat.atkTxt.text = UnitL[i].atk.ToString();
            curStat.defTxt.text = UnitL[i].def.ToString();
            curStat.spTxt.text = UnitL[i].sp.ToString();
            curStat.icon.sprite = UnitL[i].image;

            curUnit.transform.DOMove(new Vector3(3-xpo, -2+ypo, 0), 0.7f);
            xpo += 3;

            CardL.Add(curUnit);
        }
    }
    void SetCard()
    {
        
    }
}
