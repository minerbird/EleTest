using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;

    private void Awake()
    {
        instance = this;
    }
    //public GameObject ai;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var query = from item in GameManager.instance.AllCard
                    where int.Parse(item.GetComponent<UnitGen>().hpTxt.text) == 0
                    select item;
        List<GameObject> Deader = query.ToList();

        Dead(Deader);
    }

   public void Attack(GameObject you, GameObject target)
    {
        int atk = int.Parse(you.GetComponent<UnitGen>().atkTxt.text);
        int def = int.Parse(target.GetComponent<UnitGen>().defTxt.text);
        float damage = atk - (def / 2);

        if (damage <= 0)
            damage = 1;


        Debug.Log(damage);
        Debug.Log(you.GetComponent<UnitGen>().nameTxt.text);
        int curHp = int.Parse(target.GetComponent<UnitGen>().hpTxt.text) - (int)damage;
        if (curHp < 0)
        {
            curHp = 0;
        }

        target.GetComponent<UnitGen>().hpTxt.text = curHp.ToString();

    }
    void Dead(List<GameObject> deader)
    {
        for (int i = 0; i < deader.Count; i++)
        {
            GameManager.instance.AllCard.Remove(deader[i]);
            if (GameManager.instance.MyCard.Contains(deader[i]))
                GameManager.instance.MyCard.Remove(deader[i]);
            else
                GameManager.instance.EnCard.Remove(deader[i]);
            Destroy(deader[i]);
        }

        /*IEnumerator AttackAni(GameObject you, GameObject target)
        {
            you.transform.DOMove(target.transform.position, 1);
            yield return new WaitForSeconds(1);
            you.transform.DOMove(new Vector3(3 - xpo, -2 + ypo, 0), 1.5f);
        }*/
    }
}
