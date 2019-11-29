using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool inventoryEnabled;
    public GameObject inventory;
    public GameObject[] currentFishCaught;

    private int allSlots;
    private int enablesSlots;
    private GameObject[] slot;
    public GameObject slotHolder;


    void Start()
    {
        allSlots = 40;
        slot = new GameObject[allSlots];
        currentFishCaught = new GameObject[40];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().icon == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }

    //void Update()
    //{
        //if (Input.GetKeyDown(KeyCode.I))
          //  inventoryEnabled = !inventoryEnabled;

       // if (inventoryEnabled == true)
        //{
          //  inventory.SetActive(true);
        //}
        //else
       // {
           // inventory.SetActive(false);
      //  }
   // }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LargeFish" || other.tag == "MediumFish" || other.tag == "SmallFish")
        {
            GameObject itemPickedUp = other.gameObject;
            ItemInventory item = itemPickedUp.GetComponent<ItemInventory>();

            AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);
        }
    }

    void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for (int i = 0; i < allSlots; i++)
        {
            print("i is :" + 1);
            if (slot[i].GetComponent<Slot>().empty)
            {
                
                itemObject.GetComponent<ItemInventory>().pickedUp = true;

                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().icon = itemIcon;
                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().description = itemDescription;

                currentFishCaught[i] = itemObject;
                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);

                slot[i].GetComponent<Slot>().UpdateSlot();
                slot[i].GetComponent<Slot>().empty = false;

                
                print("Fish added" + i);
                return;
            }
        }
    }

}
