using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
  
    [SerializeField] Button open3dWorld;
    [SerializeField] Button openNPC;
    [SerializeField] Button openStarCollector;

    
    // Open scene when appropriate button is pressed
    public void Start()
    {
       open3dWorld.onClick.AddListener(() => SceneManager.LoadScene(1));
       openNPC.onClick.AddListener(() => SceneManager.LoadScene(2));
       openStarCollector.onClick.AddListener(() => SceneManager.LoadScene(3));
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Check if we aren't already on the menu to save resources
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
