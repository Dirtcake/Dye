using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementosHUD : MonoBehaviour
{
    public Text hpLabel, hordaLabel, dinheiroLabel;
    public void attUi(string elemento, int value)
    {

        switch (elemento)
        {
            case "hp":
                hpLabel.text = value.ToString("d2");
                break;
            case "dinheiro":
                dinheiroLabel.text = value.ToString("d5");
                break;
            case "horda":
                hordaLabel.text = value.ToString("d2");
                break;
        }
    }
}