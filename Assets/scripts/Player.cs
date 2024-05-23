using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float wayPointX = 0;
	[SerializeField] private float wayPointZ = 0;
    [SerializeField] private GameObject gameOverScreen;
    void Start()
    {
        wayPointX = transform.position.x;
	    wayPointZ = transform.position.z;
    }

    void Update()
    {
            float _x = Mathf.Lerp(transform.position.x, wayPointX, 0.2f);
		    float _z = Mathf.Lerp(transform.position.z, wayPointZ, 0.2f);
            transform.position = new Vector3(_x, transform.position.y, _z);

            // input
            if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -0.5f) // left
            {
                wayPointX = wayPointX - 1.5f;
            
            }
            else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 0.5f) // right
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

}
