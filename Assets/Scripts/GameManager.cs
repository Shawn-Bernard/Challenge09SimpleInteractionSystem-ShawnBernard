using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    // Adding my other scripts so I can use game manager to use the methods
    public UIManager UImanager;
    public LevelManager LevelManger;
    public GameStateManager gameStateManager;

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //Doesn't destroy when new scene is loaded
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}
