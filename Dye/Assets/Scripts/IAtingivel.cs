using System;
using UnityEngine.Events;

public interface IAtingivel {
    void Dano ();
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



