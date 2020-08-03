using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obelisco : MonoBehaviour
{
    public LayerMask layerMask;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit Hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out Hit, Mathf.Infinity, layerMask))
            {
                //CODE
                Debug.Log(Hit.collider.name);
            }
        }
    }
}
