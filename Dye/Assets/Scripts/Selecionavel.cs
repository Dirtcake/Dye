using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;
using System;

public class Selecionavel : MonoBehaviour
{
    TapGesture tap;

    public Material White;
    void Awake()
    {
        tap = GetComponent<TapGesture>();
    }

    private void OnEnable()
    {
        tap.Tapped += Touch;
    }

    private void OnDisable()
    {
        tap.Tapped -= Touch;
    }

    private void Touch(object sender, System.EventArgs e)
    {
        RaycastHit hit;
        if (Physics.Raycast(tap.ScreenPosition, transform.forward , out hit, Mathf.Infinity))
        {

            Debug.DrawRay(tap.ScreenPosition, transform.forward);


            if (hit.transform.GetComponent<Selecionavel>() != null)
            {
                Debug.Log("Clicked");
                GetComponent<MeshRenderer>().material = White;
            }
        }

    }

    void tapTouch()
    {



        /*var ray : Ray = Camera.main.ScreenPointToRay(touch.position);
        var hit : RaycastHit;*/
       

        /*if (Input.touchCount > 0)
        {
            RaycastHit hit;
            var vektor = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f);
            Ray ray = Camera.main.ScreenPointToRay(vektor);
            if (Physics.Raycast(ray.origin, hit, Mathf.Infinity))
            {
                anotherScript.whattomove = hit.rigidbody.gameObject.name;
            }
        }*/

        //USAR RAYCAST PARA DETECTAR OS TOQUES NOS GAMEOBJECTS NAS CENAS
    }
}
