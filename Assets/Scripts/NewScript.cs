using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewScript : MonoBehaviour
{
    public TextMeshProUGUI GUI;
    private int counter = 0;
    private Data2 data;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data2").GetComponent<Data2>();
        counter = data.GetCounter();
        GUI.text = "Score" + counter;
    }

   public void Click()
    {
        counter++;
        data.SetCounter(counter);
        GUI.text = "Score" + counter;
    }
}
