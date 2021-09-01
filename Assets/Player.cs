using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        var item = other.GetComponent<giveItem>();
        if (item)
        {
            inventory.AddItem(item.give, 1);
            Debug.Log(item);
        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
