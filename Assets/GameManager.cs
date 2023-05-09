using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameManager : MonoBehaviour
{
    public List<UnitData> MyFi = new List<UnitData>();
    public List<UnitData> EnFi = new List<UnitData>();

    public GameObject unitManager;

    //gameObject.tag = "NewTag";
    void Start()
    {
        SetPos();
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
            //Random.Range(0, 
    }
}
