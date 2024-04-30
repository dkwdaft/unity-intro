using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StarPlayer : MonoBehaviour
{
    public int stars = 0;
    [SerializeField] TMP_Text starText;
    [SerializeField] TMP_Text timeText;

    // Update is called once per frame
    void Update()
    {
        starText.SetText("Stars: " + stars);
         if (stars < 5){
             timeText.SetText("Time:" + Mathf.Round(Time.time));
      }   
       }


}