using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch, you crashed!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Pizza")
        {
            Debug.Log("You picked up a pizza.");
        }

        if (other.tag == "Customer")
        {
            Debug.Log("The pizza was delivered to a customer.");
        }
    }
}
