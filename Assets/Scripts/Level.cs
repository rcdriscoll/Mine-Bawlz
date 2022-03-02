using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour
{
    [SerializeField]int breakableBlocks; //serialized for debuggin purposes

    //cache reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;

        //we won so load next scene
        if (breakableBlocks <= 0)
        {
            //TODO update how scenes are loaded
            sceneLoader.LoadNextScene();
        }
    }

}
