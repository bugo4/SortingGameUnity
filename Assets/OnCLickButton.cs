using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCLickButton : MonoBehaviour
{
    public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(10);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
    public void RandomLevel()
    {
        SceneManager.LoadScene(10);
    }
}
