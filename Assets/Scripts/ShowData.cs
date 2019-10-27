using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this script is attached to the camera. It executes when the camera awakes and loads the values in the text boxes on the panel so you don't have to click a button.

public class ShowData : MonoBehaviour
{
    public Text NameText;
    public Text RoundsText;
    public Text ScoreText;
    public Text BallSpeedText;
    
    

    private void Awake()
    {
        NameText.text = "Name: " + KeepData.PlayerName;
        RoundsText.text = "Lives: " + KeepData.PlayerRounds.ToString();
        BallSpeedText.text = "Speed: " + KeepData.PlayingSpeed.ToString();
        ScoreText.text = "Score: " + PlayerController.endScore;
        

    }

}