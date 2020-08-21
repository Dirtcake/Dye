using System;
using UnityEngine.Events;

public interface IAtingivel {
    void Dano ();
}

public interface ISelecionavel
{
    void selecao(); 
}


[System.Serializable]
public class OneIntEvent : UnityEvent<int>
{
    internal void AddListener()
    {
        throw new NotImplementedException();
    }
}
[System.Serializable]
public class StringIntEvent : UnityEvent<string, int> { }



