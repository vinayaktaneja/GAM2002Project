using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookScript : MonoBehaviour
{
    [SerializeField]
    private Transform itemHolder;
    private bool itemAttached;
    private HookMovement hookMovement;

    private void Awake()
    {
        hookMovement = GetComponentInParent<HookMovement>();
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "LargeFish" || target.tag == "MediumFish" || target.tag == "SmallFish")
        {
            itemAttached = true;

            target.transform.parent = itemHolder;
            target.transform.position = itemHolder.position;

            hookMovement.HookAttachedItem();

            hookMovement.move_Speed = target.GetComponent<ItemScript>().hook_Speed;

            
        }
    }
}
