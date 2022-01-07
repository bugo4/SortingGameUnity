using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositions : MonoBehaviour
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
    public GameObject Test;
    float zPos = 0f;
    int turn = 1;
    float xPos = 0f;
    float yPos = 0f;
    public bool start = true;
    // Start is called before the first frame update
    void Start()
    {
        float xPos = Random.Range(-10f, 10f);
        float yPos = Random.Range(-3f, 3f);
        RandomPositioner(turn, xPos, yPos, zPos);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void RandomPositioner(int turn, float xPos, float yPos, float zPos)
    {
        while (turn != 0)
        {
            switch (turn)
            {
                case 1:
                    One.transform.position = new Vector3(xPos, yPos, zPos);
                    turn++;
                    break;
                case 2:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position);
                    Two.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 3:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position);
                    Three.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 4:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position || Three.transform.position == Test.transform.position);
                    Four.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 5:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position || Three.transform.position == Test.transform.position || Four.transform.position == Test.transform.position);
                    Five.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 6:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position || Three.transform.position == Test.transform.position || Four.transform.position == Test.transform.position || Five.transform.position == Test.transform.position);
                    Six.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 7:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position || Three.transform.position == Test.transform.position || Four.transform.position == Test.transform.position || Five.transform.position == Test.transform.position || Six.transform.position == Test.transform.position);
                    Seven.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 8:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position || Three.transform.position == Test.transform.position || Four.transform.position == Test.transform.position || Five.transform.position == Test.transform.position || Six.transform.position == Test.transform.position || Seven.transform.position == Test.transform.position);
                    Eight.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 9:
                    do
                    {
                        xPos = Random.Range(-10f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position || Three.transform.position == Test.transform.position || Four.transform.position == Test.transform.position || Five.transform.position == Test.transform.position || Six.transform.position == Test.transform.position || Seven.transform.position == Test.transform.position || Eight.transform.position == Test.transform.position);
                    Nine.transform.position = Test.transform.position;
                    turn++;
                    break;
                case 10:
                    do
                    {
                        xPos = Random.Range(-3f, 10f);
                        yPos = Random.Range(-3f, 3f);
                        Test.transform.position = new Vector3(xPos, yPos, zPos);
                    } while (One.transform.position == Test.transform.position || Two.transform.position == Test.transform.position || Three.transform.position == Test.transform.position || Four.transform.position == Test.transform.position || Five.transform.position == Test.transform.position || Six.transform.position == Test.transform.position || Seven.transform.position == Test.transform.position || Eight.transform.position == Test.transform.position || Nine.transform.position == Test.transform.position);
                    Ten.transform.position = Test.transform.position;
                    turn++;
                    break;
                default:
                    turn = 0;
                    Debug.LogError("Start is false ");
                    Invoke("denyCollision", 0.5f);
                    break;
            }
        }

    }
    void denyCollision()
    {
        start = false;
    }
}
