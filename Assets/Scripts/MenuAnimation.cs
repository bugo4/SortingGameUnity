using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuAnimation : MonoBehaviour
{
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;
    public GameObject TriggerText;
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
    bool start = false;
    public bool flag = false;
    int count = 0;
    IEnumerator startingAnimation()
    {
        One.SetActive(true);
        yield return new WaitForSeconds(1f);
        Two.SetActive(true);
        yield return new WaitForSeconds(1f);
        Three.SetActive(true);
        Four.SetActive(true);
        yield return new WaitForSeconds(1f);
        Five.SetActive(true);
        Six.SetActive(true);
        Seven.SetActive(true);
        yield return new WaitForSeconds(1f);
        Eight.SetActive(true);
        Nine.SetActive(true);
        Ten.SetActive(true);
        yield return new WaitForEndOfFrame();
        Text1.text = "In this game you need to sort all the items from 1 to 10.";
        yield return new WaitForSeconds(5.5f);
        Text1.text = "When you finished to orginize the boxes with the next box press space and move to the next boxes.";
        yield return new WaitForSeconds(5.5f);
        Text1.text = "You have a countdown, so you have to be fast and quick!";
        yield return new WaitForSeconds(5.5f);
        Text1.text = "We will send you now to a level, good luck!";
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag == true)
        {
            TriggerText.SetActive(false);
            if (count == 0)
            {
                if (start == false)
                {
                    Text1.text = "";
                    Text2.text = "";
                    Text3.text = "";
                    Text4.text = "";
                    StartCoroutine(startingAnimation());
                    start = true;
                }
            }
            
        }
    }
}
