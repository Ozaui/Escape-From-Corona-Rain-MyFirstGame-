using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;
    void Awake()
    {
        if(backgroundMusic == null)
        {
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}