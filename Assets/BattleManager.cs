using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Damage(GameManager.instance.)
    }

   public void Attack(GameObject you, GameObject target)
    {
        int atk = int.Parse(you.GetComponent<UnitGen>().atkTxt.text);
        int def = int.Parse(target.GetComponent<UnitGen>().defTxt.text);
        float damage = atk - (def / 2);

        if (damage <= 0)
            damage = 1;


        Debug.Log(damage);
        Debug.Log(you);
        int curHp = int.Parse(target.GetComponent<UnitGen>().hpTxt.text) - (int)damage;

        target.GetComponent<UnitGen>().hpTxt.text = curHp.ToString();

    }
    void Dead(GameObject obj)
    {
        Destroy(obj);
    }

}
