using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;


public class Inimigo : MonoBehaviour, IAtingivel {
    public int reward = 20;
    public int damage = 1;
    public int vida = 3;


    private Vector3 destination;
    private NavMeshAgent agent;

    public static OneIntEvent OnEnemyDeath = new OneIntEvent();
    public static OneIntEvent OnEnemyPlayerDamage = new OneIntEvent();


    void Start () {
        agent = GetComponent<NavMeshAgent> ();
        destination = new Vector3 (15, -6f, 7);

        agent.SetDestination (destination);
    }

    void Update () {
        if(Vector3.Distance(transform.position, destination) < 0.5f)
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