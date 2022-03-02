using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: " + GameSession.currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
