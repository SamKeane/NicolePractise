using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Object
{
    static T _instance;

    void Awake()
    {
        _instance = (T)Instance;
    }

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));

                return _instance;
            }
            else
            {
                return _instance;
            }
        }
    }
}
