using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject inventory;
    public bool invOpened = false;

    public void OpenInventory()
    {
        if (inventory != null)
        {
            if (GameObject.Find("hookRope").GetComponent<HookMovement>().canRotate == true)
            {
                bool isActive = Panel.activeSelf;
                invOpened = !invOpened;
                Panel.SetActive(!isActive);
            }
        }
    }

    

}
