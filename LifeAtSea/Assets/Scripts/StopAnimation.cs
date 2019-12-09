using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    private GameObject hook;

    private void Start()
    {
        hook = GameObject.Find("hook");
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player" && hook.GetComponent<HookScript>().hookFish == false)
        {
            Debug.Log("StopAnim");
            GetComponent<Animator>().enabled = false;
        }
    }
}
