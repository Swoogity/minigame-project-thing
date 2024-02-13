using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.UI;
using TMPro;
using Unity.VisualScripting;
public class MusicBox : MonoBehaviour
{
    public TMP_Text Text;
    int secondsLeft = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CountUp", 1, 1f);
    }
    void Countdown()

    {
        secondsLeft++;
        Text.text = secondsLeft.ToString();
        //timer goes up as the time goes yeah
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CountUp()

    {
        //if ( secondsLeft > -1 && secondsLeft < 5000)

        if (secondsLeft > -1 && secondsLeft < 5000 && (GameObject.Find("Player") != null)) 
        {
            secondsLeft++;
            Text.text = secondsLeft.ToString();
            //Count up
            
        }
    }
}
