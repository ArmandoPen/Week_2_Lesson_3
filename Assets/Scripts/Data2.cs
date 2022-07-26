using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Data2 _instance;

    int counter = 0;

    void Start()
    {
        if(_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(_instance);
    }

    // Update is called once per frame
    public void SetCounter(int c)
    {
        counter = c;
    }
    public int GetCounter()
    {
        return counter;
    }
}
