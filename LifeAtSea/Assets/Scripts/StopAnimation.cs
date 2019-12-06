using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
   

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Debug.Log("StopAnim");
            GetComponent<Animator>().enabled = false;
        }
    }
}
