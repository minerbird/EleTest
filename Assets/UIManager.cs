using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button attack1;
    public Button attack2;
    public Button attack3;
    void Start()
    {
        StartCoroutine("setup");
        //GameManager.instance.MyCard[0].GetComponent<UnitGen>().num;
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                Debug.Log(click_obj.GetComponent<UnitGen>().atkTxt.text);

                Instantiate(attack, new Vector3(click_obj.transform.position.x, click_obj.transform.position.y-10, 0), Quaternion.identity);
                
            }
        }*/
    }

    IEnumerator setup()
    {
        Debug.Log("fgb");
        yield return new WaitForSeconds(3f);
        Debug.Log("qwer");
        attack1.onClick.AddListener(delegate
                           { UnitManager.instance.skills(GameManager.instance.MyCard[0].GetComponent<UnitGen>().num);  });
    }
}
