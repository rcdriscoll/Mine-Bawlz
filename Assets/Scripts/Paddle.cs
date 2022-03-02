using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration parameters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1.75f;
    [SerializeField] float maxX = 14.25f;

    //cached variables
    GameSession theGameSession;
    Ball theBall;

    // Start is called before the first frame update
    void Start()
    {
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();

    }

    void Update()
    {     
        //creates the vector 2
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        //clamps movement to edges (0-16)
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);

        //actually moves the paddle
        transform.position = paddlePos;
    }


    private float GetXPos()
    {
        if (theGameSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }



}
