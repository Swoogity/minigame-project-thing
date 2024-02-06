using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTimer : MonoBehaviour
{
    public GameObject score_label;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        score_label.GetComponent<Text>().text = Mathf.Round(timer).ToString();
    }
}
