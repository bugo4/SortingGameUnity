using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float StartingTime = 10f;
    float CurrentTime = 0;
    public Text Timer;
    bool flag = false;
    public CubesMovement cubes;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = StartingTime;
        Invoke("Update", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(cubes.flag == false)
        {
            CurrentTime -= Time.deltaTime;
            Timer.text = CurrentTime.ToString("0.0");
            if (CurrentTime > 3)
            {
                Timer.color = Color.green;
            }
            if (CurrentTime > 2 && CurrentTime < 3)
            {
                Timer.color = Color.yellow;
            }
            if (CurrentTime > 1 && CurrentTime < 2)
            {
                Timer.color = Color.red;
            }
            if (CurrentTime < 0)
            {
                CurrentTime = 0;
                if (flag == false)
                {
                    Debug.LogError("You lost!");
                    Invoke("Restart", 3f);
                    flag = true;
                }

            }
        }        
        else if(cubes.flag == true && SceneManager.GetActiveScene().buildIndex == 10)
        {
            Invoke("Restart", 2f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
