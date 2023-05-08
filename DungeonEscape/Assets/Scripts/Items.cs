using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] public GameObject pickUpText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

            pickUpText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        pickUpText.SetActive(false);
    }
}
