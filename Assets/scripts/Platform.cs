using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public ColorChanger colorChanger;

    [Header("Obstacles")]
    [SerializeField] private GameObject box1;
    [SerializeField] private GameObject box2;
    [SerializeField] private GameObject box3;

    private int randomNumber;
    private Vector3 currentPosition;

    void Awake()
    {
        Time.timeScale = 0;
    }

    void FixedUpdate()
    {
        currentPosition = transform.position;
        currentPosition.z -= GameController.speed * Time.deltaTime;

        if (currentPosition.z < -4)
        {
            box1.SetActive(false);
            box2.SetActive(false);
            box3.SetActive(false);
            currentPosition.z = 44;
            randomNumber = Random.Range(0, 6);

            switch(randomNumber) 
            {
                case 0:
                box1.SetActive(true);
                break;
                
                case 1:
                box2.SetActive(true);
                break;
                
                case 2:
                box3.SetActive(true);
                break;

                case 3:
                box1.SetActive(true);
                box2.SetActive(true);
                break;

                case 4:
                box2.SetActive(true);
                box3.SetActive(true);
                break;

                case 5:
                box1.SetActive(true);
                box3.SetActive(true);
                break;
            }

            GameController.stepsTaken++;
            if (GameController.stepsTaken == 20 || GameController.stepsTaken == 30 || GameController.stepsTaken == 40 || GameController.stepsTaken == 50) GameController.speed++;

            colorChanger.Recolor();


        }

        transform.position = currentPosition;
    }
}
