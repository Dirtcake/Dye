using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Essencials : MonoBehaviour {
    private float tempo;
    public bool Timer (float Intervalo) {

        if (tempo < Time.time) {
            tempo = Time.time + Intervalo;
            return true;
        } else return false;

    }
}