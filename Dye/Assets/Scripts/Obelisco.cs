using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obelisco : MonoBehaviour,ISelecionavel
{
    private Material selectedMaterial;
    private Material deselectedMaterial;

    void Start()
    {
        selectedMaterial = GameAssets.i.selectedMaterial;
        deselectedMaterial = GameAssets.i.deselectedMaterial;
    }

    public void selecao()
    {
        GetComponent<MeshRenderer>().material = selectedMaterial;
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void createTower()
    {
        GetComponent<MeshRenderer>().material = deselectedMaterial;
    }
}
