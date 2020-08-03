using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected GameObject projectile;
    protected Essencials es = new Essencials();


    public virtual void Shoot(GameObject projectile,float fireRate) {
        if (es.Timer(fireRate))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
