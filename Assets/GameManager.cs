using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

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
        SetPos();
        SetCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPos()
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
    void SetCard()
    {
        UnitGen unit = UnitGen.GetComponent<UnitGen>();
        
        GameObject curUnit = Instantiate(unit.Card, new Vector3(0, 0, 0), Quaternion.identity);
        UnitGen curStat = curUnit.GetComponent<UnitGen>();
        //unit.icon = MyFi[0].image;
        curStat.nameTxt.text = MyFi[0].name;
        MyCard.Add(curUnit);
        
    }
}
