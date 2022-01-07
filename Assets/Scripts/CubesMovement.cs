using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CubesMovement : MonoBehaviour
{
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;
    public GameObject Seven;
    public GameObject Eight;
    public GameObject Nine;
    public GameObject Ten;
    public Text Time;
    public GameObject ParticleOne;
    public GameObject ParticleTwo;
    int turn = 1;
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(turn)
        {
            case 1:
                Movement(One, Two);
                break;
            case 2:
                Movement(Two, Three);
                break;
            case 3:
                Movement(Three, Four);
                break;
            case 4:
                Movement(Four, Five);
                break;
            case 5:
                Movement(Five, Six);
                break;
            case 6:
                Movement(Six, Seven);
                break;
            case 7:
                Movement(Seven, Eight);
                break;
            case 8:
                Movement(Eight, Nine);
                break;
            case 9:
                Movement(Nine, Ten);
                break;
            default:
                if(One.transform.position.x < Two.transform.position.x && Two.transform.position.x < Three.transform.position.x && Three.transform.position.x < Four.transform.position.x && Four.transform.position.x < Five.transform.position.x && Five.transform.position.x < Six.transform.position.x && Six.transform.position.x < Seven.transform.position.x && Seven.transform.position.x < Eight.transform.position.x && Eight.transform.position.x < Nine.transform.position.x && Nine.transform.position.x < Ten.transform.position.x && Time.text != "0.0")
                {
                    flag = true;
                    Debug.LogError("FINISHED THE LEVEL!");
                    Invoke("NextLevel", 3f);
                    Time.text = "Succeed!";
                }
                else
                {
                    Debug.LogWarning("Next Iteration");
                    turn = 1;
                }
                break;
        }
    }
    void Movement(GameObject NumberOne, GameObject NumberTwo)
    {
        ParticleOne.transform.position = NumberOne.transform.position;
        ParticleTwo.transform.position = NumberTwo.transform.position;
        //Player One
        if (Input.GetKey(KeyCode.A))
        {
           NumberOne.transform.position -= new Vector3(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            NumberOne.transform.position += new Vector3(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            NumberOne.transform.position += new Vector3(0f, 0.1f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            NumberOne.transform.position -= new Vector3(0f, 0.1f, 0f);
        }
        //Player Two
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            NumberTwo.transform.position -= new Vector3(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            NumberTwo.transform.position += new Vector3(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            NumberTwo.transform.position += new Vector3(0f, 0.1f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            NumberTwo.transform.position -= new Vector3(0f, 0.1f, 0f);
        }
        //Next Turn Checker:
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if(NumberOne.transform.position.x < NumberTwo.transform.position.x)
            {
                turn++;
                Debug.Log("The turn is " + turn);
            }    
        }
        //Restart Level Checker
        if(Input.GetKeyDown(KeyCode.R) && Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
