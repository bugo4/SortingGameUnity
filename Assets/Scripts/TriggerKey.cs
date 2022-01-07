using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerKey : MonoBehaviour
{
    public MenuAnimation menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.anyKey)
            {
                SceneManager.LoadScene(1);
            }
        }
        else if(SceneManager.GetActiveScene().buildIndex == 9)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
            
    }
}
