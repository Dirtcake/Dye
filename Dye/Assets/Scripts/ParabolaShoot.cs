using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaShoot : MonoBehaviour {
    float _animation;
    public GameObject Enemy;
    public Transform posFreezy;
    public float divisor;
    void Start () { }

    void Update () {
        _animation += Time.deltaTime;
        _animation = _animation % divisor;
        transform.GetChild (0).position = MathParabola.Parabola (transform.position, posFreezy.position, 3f, _animation / divisor);

        Debug.Log (MathParabola.Parabola (transform.position, posFreezy.position, 3f, _animation / divisor));

        if (Vector3.Distance (transform.GetChild (0).position, posFreezy.position) < 1) {
            Destroy (gameObject);
        }
    }
}