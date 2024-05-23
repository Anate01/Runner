using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float wayPointX = 0;
	[SerializeField] private float wayPointZ = 0;
    [SerializeField] private GameObject gameOverScreen;

    public NewControls newControls;

    void Awake()
    {
        newControls = new NewControls();
    }   

    void Start()
    {
        wayPointX = transform.position.x;
	    wayPointZ = transform.position.z;
    }

    void FixedUpdate()
    {
            float _x = Mathf.Lerp(transform.position.x, wayPointX, 0.2f);
		    float _z = Mathf.Lerp(transform.position.z, wayPointZ, 0.2f);
            transform.position = new Vector3(_x, transform.position.y, _z);
/*
            // input
            if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -0.5f) // left
            {
                wayPointX = wayPointX - 1.5f;
            
            }
            else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 0.5f) // right
            {
                wayPointX = wayPointX + 1.5f;
            }*/
    }

    public void MoveLeft(InputAction.CallbackContext callbackContext)
    {
        if (transform.position.x > -0.5f) // left
        {
            wayPointX = wayPointX - 1.5f;
        }
    }

    public void MoveRight(InputAction.CallbackContext callbackContext)
    {
        if (transform.position.x < 0.5f) // left
        {
            wayPointX = wayPointX + 1.5f;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
    if (collision.gameObject.CompareTag("box"))
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }
    }

    private void OnEnable()
    {
        newControls.Enable();
        newControls.Player.MoveLeft.performed += MoveLeft;
        newControls.Player.MoveRight.performed += MoveRight;
    }

    private void OnDisable()
    {
        newControls.Disable();
        newControls.Player.MoveLeft.performed -= MoveLeft;
        newControls.Player.MoveRight.performed -= MoveRight;
    }

}
