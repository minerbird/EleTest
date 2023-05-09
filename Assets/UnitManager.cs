using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class UnitData
{
    public string name;
    public Sprite image;

    public int maxHp;
    int hp;

    public int atk;
    public int def;
    public int sp;

    public string Team;

    //public int lv;
    //public int maxXp;
    //int xp;

    //public string type;
    //public int mana;



    //public List<> skills = new List<>()

    /*public UnitData(string _name, int _hp, int _atk, int _def, int _sp)
    {
        name = _name;

        maxHp = _hp;
        hp = maxHp;

        atk = _atk;
        def = _def;
        sp = _sp;

        lv = 1;
        xp = 0;
        maxXp = 2;
    }*/
}


public class UnitManager : MonoBehaviour
{   
    public List<UnitData> unitList = new List<UnitData>();
    //UnitData unit1 = new UnitData(50, 20, 10, 3);
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
