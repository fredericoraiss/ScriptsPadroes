using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviourPersistent<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Get;
    protected void Awake()
    {
        if (Get == null)
        {
            DontDestroyOnLoad(gameObject);
            Get = this as T;
        }
        else if (Get != this)
        {
            Destroy(gameObject);
        }
    }
}
