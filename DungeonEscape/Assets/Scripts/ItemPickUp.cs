using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] LayerMask itemsLayerMask;
    [SerializeField] Transform playerCam;
    public List<string> inventory;

    private float pickUpDistance = 2f;


    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(playerCam.position, playerCam.forward, out RaycastHit raycastHit, pickUpDistance, itemsLayerMask))
            {
                Debug.Log(raycastHit.collider.gameObject.name);
                AddItem(raycastHit.collider.gameObject.name);
                Destroy(raycastHit.collider.gameObject);
            }
        }
    }
    private void AddItem(string itemName)
    {
        inventory.Add(itemName);
        Debug.Log("Podniesiono przedmiot " + itemName);
    }

    private void RemoveItem(string itemName)
    {
        inventory.Remove(itemName);
        Debug.Log("Wyrzucono przedmiot " + itemName);
    }

}


