using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseEnter()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseP = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        transform.position = Camera.main.ScreenToWorldPoint(mouseP);
    }
       
}
