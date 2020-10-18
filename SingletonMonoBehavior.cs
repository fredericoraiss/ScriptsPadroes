using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehavior<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Get;
    protected virtual void Awake()
    {
        if (Get == null)
        {
            Get = this as T;
        }
        else if (Get != this)
        {
            Destroy(gameObject);
        }
    }

}
