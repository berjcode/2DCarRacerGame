using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{

    public GameObject way;
    bool wayCreate = false;

    private void OnTriggerEnter2D(Collider2D contact)
    {
        if(contact.gameObject.tag=="MainCar" && wayCreate ==false)
        {

            Vector3 spawLocation = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawLocation, Quaternion.identity);
            wayCreate = true;
            ScoreManager.score += 10;
            Destroy(this.gameObject,25f);
        }


    }

}
