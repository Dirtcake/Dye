using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private enum STATE { Idle, spawning }
    private STATE State;

    private Essencials es;

    public Transform place;

    public GameObject enemy;
    public GameObject hordaButton;

    public int enemyLimit { get; private set; }
    public static int enemyCount { get; private set; }

    public float distanceBetween { get; private set; }

    public static OneIntEvent OnCallHorda = new OneIntEvent();

    void Start () {
        es = new Essencials ();
        State = STATE.Idle;

        enemyLimit = 1;
        distanceBetween = 2;

    }

    void Update () {

        switch (State) {
            case STATE.Idle:
                break;
            case STATE.spawning:
                if (enemyCount < enemyLimit)
                    CreateEnemy (es.Timer (distanceBetween));
                else {
                    State = STATE.Idle;
                    hordaButton.SetActive (true);
                }
                break;
        }
    }

    void CreateEnemy (bool distanceBetween) {
        if (distanceBetween) {
            Instantiate (enemy, place.position, Quaternion.identity);
            enemyCount++;
        }
    }

    public void OnHordaClick () {
        State = STATE.spawning;
        hordaButton.SetActive (false);

        OnCallHorda?.Invoke(1);

        //if (enemyCount != enemyLimit) return;
        enemyCount = 0;
    }
}

/*
QUANTIDADE -- ok
TIPO DE INIMIGOS -- 
DISTANCIA ENTRE ELES -- ok
*/