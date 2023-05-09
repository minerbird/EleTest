using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button attack;
    void Start()
    {
        
    }

    private void OnMouseEnter()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                Debug.Log(click_obj.GetComponent<UnitGen>().atkTxt.text);

                Instantiate(attack, new Vector3(click_obj.transform.position.x, click_obj.transform.position.y-10, 0), Quaternion.identity);
                
            }
        }
    }
       
}
