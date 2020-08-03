using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _internal;

    public static GameAssets i{
        get
        {
            if (_internal == null) _internal = (Instantiate(Resources.Load("GameAssets") as GameObject).GetComponent<GameAssets>());
            return _internal;
        }
    }


    public string teste;


    // PROJÉTEIS 
    public GameObject TowerCuboProjectile;
    public GameObject TowerPiramidProjectile;
}
