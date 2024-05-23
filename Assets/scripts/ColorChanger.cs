using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [Header("Decor")]
    [SerializeField] private MeshRenderer decor1;
    [SerializeField] private MeshRenderer decor2;
    [SerializeField] private MeshRenderer decor3;

    [Header("Type of platform")]
    [SerializeField] private bool isDarkColored;

    [Header("Materials")]
    [SerializeField] private Material orange;
    [SerializeField] private Material orange2;
    [SerializeField] private Material green;
    [SerializeField] private Material green2;
    [SerializeField] private Material pink;
    [SerializeField] private Material pink2;
    [SerializeField] private Material rose;    
    [SerializeField] private Material rose2;

    public void Recolor()
    {
        if (GameController.stepsTaken > 10 && GameController.stepsTaken < 20)
            {
                if (isDarkColored) 
                {
                    decor1.material = orange;
                    decor2.material = orange;
                    decor3.material = orange;
                }
                else 
                {
                    decor1.material = orange2;
                    decor2.material = orange2;
                    decor3.material = orange2;
                }
            }
            else if (GameController.stepsTaken >= 20 && GameController.stepsTaken < 30)
            {
                if (isDarkColored) 
                {
                    decor1.material = green;
                    decor2.material = green;
                    decor3.material = green;
                }
                else 
                {
                    decor1.material = green2;
                    decor2.material = green2;
                    decor3.material = green2;
                }
            }
            else if (GameController.stepsTaken >= 30 && GameController.stepsTaken < 40)
            {
                if (isDarkColored) 
                {
                    decor1.material = pink;
                    decor2.material = pink;
                    decor3.material = pink;
                }
                else 
                {
                    decor1.material = pink2;
                    decor2.material = pink2;
                    decor3.material = pink2;
                }
            }
            else if (GameController.stepsTaken >= 40)
            {
                if (isDarkColored) 
                {
                    decor1.material = rose;
                    decor2.material = rose;
                    decor3.material = rose;
                }
                else 
                {
                    decor1.material = rose2;
                    decor2.material = rose2;
                    decor3.material = rose2;
                }
            }
    }
}
