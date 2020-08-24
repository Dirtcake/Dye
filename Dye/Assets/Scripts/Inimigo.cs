using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;


public class Inimigo : MonoBehaviour, IAtingivel {
    public int reward = 20;
    public int damage = 1;
    public int vida = 3;

    public Transform destination;
    private NavMeshAgent agent;

    public static OneIntEvent OnEnemyDeath = new OneIntEvent();
    public static OneIntEvent OnEnemyPlayerDamage = new OneIntEvent();


    void Start () {

        agent = GetComponent<NavMeshAgent> ();
        destination = GameObject.FindGameObjectWithTag("Objetivo").GetComponent<Transform>();
        agent.SetDestination (destination.position);
    }

    void Update () {
        if(Vector3.Distance(transform.position, destination.position) < 0.5f)
        {
            OnEnemyPlayerDamage?.Invoke(-damage);
            Destroy(gameObject);
        }
    }

    public void Dano () {
        vida--;
        if (vida <= 0)
        {
            OnEnemyDeath?.Invoke(reward);
            Destroy(gameObject);
        }
    }

}