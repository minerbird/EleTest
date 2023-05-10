using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

[Serializable]
public class UnitData
{
    public string name;
    public Sprite image;

    public int hp;

    public int atk;
    public int def;
    public int sp;

    public string tag;
    public string plaver;

    public int num;
}

public class UnitManager : MonoBehaviour
{
    public static UnitManager instance;

    private void Awake()
    {
        instance = this;
    }

    public List<UnitData> unitList = new List<UnitData>();
    //UnitData unit1 = new UnitData(50, 20, 10, 3);
    public Button attck1;
    public Button attck2;
    public Button attck3;

    public Text t1;
    public Text t2;
    public Text t3;

    void Start()
    {
        ButtonSet();
    }

    void Update()
    {
        
    }

    void ButtonSet()
    {

        attck1.onClick.AddListener(() => skills(GameManager.instance.MyCard[2].GetComponent<UnitGen>().num));
        //t1.text = GameManager.instance.MyCard[2].GetComponent<UnitGen>().plaver;
        
        attck2.onClick.AddListener(() => skills(GameManager.instance.MyCard[1].GetComponent<UnitGen>().num));
        //t2.text = GameManager.instance.MyCard[1].GetComponent<UnitGen>().plaver;
        
        attck3.onClick.AddListener(() => skills(GameManager.instance.MyCard[0].GetComponent<UnitGen>().num));
        //t3.text = GameManager.instance.MyCard[0].GetComponent<UnitGen>().plaver;
    }

    public void skills(int num)
    {
        switch (num)
        {
            case 1:
                sword(GameManager.instance.MyCard, GameManager.instance.EnCard);
                break;
            case 2:
                shild(GameManager.instance.MyCard, GameManager.instance.EnCard);
                break;
            case 3:
                axe(GameManager.instance.MyCard, GameManager.instance.EnCard);
                break;
            case 4:
                flower(GameManager.instance.MyCard, GameManager.instance.EnCard);
                break;
            case 5:
                stone(GameManager.instance.MyCard, GameManager.instance.EnCard);
                break;
            case 6:
                ghost(GameManager.instance.MyCard, GameManager.instance.EnCard);
                break;
            default:
                Debug.Log("asdfg");
                break;
        }
    }

    public void sword(List<GameObject> ju, List<GameObject> ene)
    {
        //공격력이 가장 높은 적을 공격

        Debug.Log("sw");
        int h_atk = int.Parse(ene[0].GetComponent<UnitGen>().atkTxt.text);
        int d_atk;
        for (int i = 0; i < ene.Count; i++)
        {
            d_atk = int.Parse(ene[i].GetComponent<UnitGen>().atkTxt.text);
            if (h_atk < d_atk)
            {
                h_atk = d_atk;
            }

        }

        var query = from item in ene
                    where int.Parse(item.GetComponent<UnitGen>().atkTxt.text) == h_atk
                    select item;

        List<GameObject> DaL = query.ToList();
        //Debug.Log(DaL.Count);

        GameObject target;
        GameObject you = null;

        if (DaL.Count >= 2)
        {
            int ran = UnityEngine.Random.Range(0, DaL.Count);
            target = DaL[ran];
        }
        else
            target = DaL[0];

        for (int i = 0; i < ju.Count; i++)
        {
            if (ju[i].GetComponent<UnitGen>().taging == "sw")
            {
                you = ju[i];
            }
        }

        BattleManager.instance.Attack(you, target);
    }
    public void shild(List<GameObject> ju, List<GameObject> ene)
    {
        // 방어력이 가장 높은 적을 공격

        Debug.Log("sh");
        int h_def = int.Parse(ene[0].GetComponent<UnitGen>().defTxt.text);
        int d_def;
        for (int i = 0; i < ene.Count; i++)
        {
            d_def = int.Parse(ene[i].GetComponent<UnitGen>().defTxt.text);
            if (h_def < d_def)
            {
                h_def = d_def;
            }

        }

        var query = from item in ene
                    where int.Parse(item.GetComponent<UnitGen>().defTxt.text) == h_def
                    select item;

        List<GameObject> DaL = query.ToList();
        //Debug.Log(DaL.Count);
        //Debug.Log(DaL.Count);

        GameObject target;
        GameObject you = null;

        if (DaL.Count >= 2)
        {
            int ran = UnityEngine.Random.Range(0, DaL.Count);
            target = DaL[ran];
        }
        else
        {
            target = DaL[0];
        }

        for (int i = 0; i < ju.Count; i++)
        {
            if (ju[i].GetComponent<UnitGen>().taging == "sh")
            {
                you = ju[i];
            }
        }

        BattleManager.instance.Attack(you, target);
    }
    public void axe(List<GameObject> ju, List<GameObject> ene)
    {
        // 체력이 가장 높은 적을 공격

        Debug.Log("ax");
        int h_hp = int.Parse(ene[0].GetComponent<UnitGen>().hpTxt.text);
        int d_hp;
        for (int i = 0; i < ene.Count; i++)
        {
            d_hp = int.Parse(ene[i].GetComponent<UnitGen>().hpTxt.text);
            if (h_hp < d_hp)
            {
                h_hp = d_hp;
            }

        }

        var query = from item in ene
                    where int.Parse(item.GetComponent<UnitGen>().hpTxt.text) == h_hp
                    select item;

        List<GameObject> DaL = query.ToList();
        //Debug.Log(DaL.Count);

        GameObject target;
        GameObject you = null;

        if (DaL.Count >= 2)
        {
            int ran = UnityEngine.Random.Range(0, DaL.Count);
            target = DaL[ran];
        }
        else
            target = DaL[0];

        for (int i = 0; i < ju.Count; i++)
        {
            if (ju[i].GetComponent<UnitGen>().taging == "ax")
            {
                you = ju[i];
            }
        }

        BattleManager.instance.Attack(you, target);
    }
    public void flower(List<GameObject> ju, List<GameObject> ene)
    {
        // 모든 적을 공격

        Debug.Log("fl");
        List<GameObject> DaL = ene;

        GameObject target;
        GameObject you = null;

        for (int i = 0; i < ju.Count; i++)
        {
            if (ju[i].GetComponent<UnitGen>().taging == "fl")
            {
                you = ju[i];
            }
        }

        for (int i = 0; i < DaL.Count; i++)
        {
            target = DaL[i];
            BattleManager.instance.Attack(you, target);
        }
    }
    public void stone(List<GameObject> ju, List<GameObject> ene)
    {
        // 무작위의 적을 공격

        Debug.Log("st");
        List<GameObject> DaL = ene;

        GameObject target;
        GameObject you = null;

        int ran = UnityEngine.Random.Range(0, DaL.Count);
        target = DaL[ran];

        for (int i = 0; i < ju.Count; i++)
        {
            if (ju[i].GetComponent<UnitGen>().taging == "st")
            {
                you = ju[i];
            }
        }

        BattleManager.instance.Attack(you, target);
    }
    public void ghost(List<GameObject> ju, List<GameObject> ene)
    {
        // 공격과 방어의 합이 가장 높은 적을 공격

        Debug.Log("gh");

        int h_stat = int.Parse(ene[0].GetComponent<UnitGen>().atkTxt.text) + 
                        int.Parse(ene[0].GetComponent<UnitGen>().defTxt.text);

        string hs_name = ene[0].GetComponent<UnitGen>().nameTxt.text;

        int d_stat;
        for (int i = 0; i < ene.Count; i++)
        {
            d_stat = int.Parse(ene[i].GetComponent<UnitGen>().atkTxt.text) +
                        int.Parse(ene[i].GetComponent<UnitGen>().defTxt.text);
            if (h_stat < d_stat)
            {
                h_stat = d_stat;
                hs_name = ene[i].GetComponent<UnitGen>().nameTxt.text;
            }
        }

        var query = from item in ene
                    where item.GetComponent<UnitGen>().nameTxt.text == hs_name
                    select item;

        List<GameObject> DaL = query.ToList();
        //Debug.Log(DaL.Count);

        GameObject target;
        GameObject you = null;

        if (DaL.Count >= 2)
        {
            int ran = UnityEngine.Random.Range(0, DaL.Count);
            target = DaL[ran];
        }
        else
            target = DaL[0];

        for (int i = 0; i < ju.Count; i++)
        {
            if (ju[i].GetComponent<UnitGen>().taging == "gh")
            {
                you = ju[i];
            }
        }

        BattleManager.instance.Attack(you, target);

    }
}
