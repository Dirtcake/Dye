using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prisma : Tower {

    public GameObject enemy;
    private void Start()
    {
        projectile = GameAssets.i.TowerPiramidProjectile;

    }
    void Update () {

        if (enemy != null) {

            Shoot(projectile, 3);
        }

        enemy = GameObject.FindWithTag ("Inimigo");

    }
}