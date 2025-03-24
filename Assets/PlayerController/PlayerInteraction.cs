using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    List<GameObject> Inventory = new List<GameObject>();
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject Current = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        Debug.Log("Here");
        if (other.gameObject.CompareTag("Interactable"))
        {
            Current = other.gameObject;
            PlayerInputActions.InteractEvent += Current.GetComponent<InteractableObject>().Interact;
            Inventory.Add(Current);
        }
        else
        {
            PlayerInputActions.InteractEvent -= Current.GetComponent<InteractableObject>().Interact;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Interactable"))
        {
            PlayerInputActions.InteractEvent -= other.gameObject.GetComponent<InteractableObject>().Interact;
            Current = null;
        }
    }


}
