using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockController : MonoBehaviour
{
    private bool selectSprite = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                // raycast hit this gameobject
                selectSprite = true;
                Debug.Log(this.name + " PICK");
            }
            else
            {
                selectSprite = false;
            }
        }
    }

    public bool isSelect()
    {
        return selectSprite;
    }
}