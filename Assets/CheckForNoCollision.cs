using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForNoCollision : MonoBehaviour
{
    public RandomPositions rand;
    public OnCLickButton bttn;
    bool flag = true;
    
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(rand.start == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
