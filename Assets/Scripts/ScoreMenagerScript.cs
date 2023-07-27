using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenagerScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score;
    

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")  != null)
        {
            score += 10  * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}
