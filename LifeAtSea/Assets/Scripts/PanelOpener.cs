using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject inventory;

    public void OpenInventory()
    {
        if (inventory != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);

        }
    }

    

}
