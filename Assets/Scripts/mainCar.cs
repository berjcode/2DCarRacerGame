using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float verticalSpeed,horizontalSpeed,defaultSpeed;
    private float verticalMovement,horizontalMovement;


    Rigidbody2D rb;

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();// Oyun baþladýðýnda obje ile deðiþkeni eþitler.

    }


    private void FixedUpdate()
    {
        #region Movement 
        verticalMovement = Input.GetAxis("Vertical"); //Diket Hareket
        horizontalMovement = Input.GetAxis("Horizontal");//YtayHareket

        rb.velocity = new Vector3
            (horizontalMovement*50*horizontalSpeed*Time.deltaTime, defaultSpeed + verticalMovement * 50 * verticalSpeed * Time.deltaTime);
        #endregion

        #region Right-Left Contact Control 
        if (transform.position.x > 1.85f)
        {
            Vector3 rightLimit = new Vector3(1.85f, transform.position.y);
            transform.position = rightLimit;
        }
        if (transform.position.x <  -1.79f)
        {
            Vector3 leftLimit = new Vector3(-1.79f, transform.position.y);
            transform.position = leftLimit;
        }

        #endregion


    }

}
