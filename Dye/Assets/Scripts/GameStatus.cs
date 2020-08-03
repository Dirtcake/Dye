using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStatus : MonoBehaviour {

    private int hp, dinheiro, horda;
    public StringIntEvent OnValuesChange = new StringIntEvent();

    public int inicialhp, inicialdinheiro, inicialhorda;

    void Start () {
        SetHp (inicialhp);
        SetDinheiro (inicialdinheiro);
        SetHorda (inicialhorda);

        // Listener do evento de morte do inimigo
        Inimigo.OnEnemyDeath.AddListener(SetDinheiro);
        Inimigo.OnEnemyPlayerDamage.AddListener(SetHp);

        Spawner.OnCallHorda.AddListener(SetHorda);

    }

    public void SetHp (int value) {
        hp += value;
        OnValuesChange?.Invoke ("hp", hp);
    }
    public void SetDinheiro (int value) {
        dinheiro += value;
        OnValuesChange?.Invoke ("dinheiro", dinheiro);
    }
    public void SetHorda (int value) {
        horda += value;
        OnValuesChange?.Invoke ("horda", horda);
    }

}