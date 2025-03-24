using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class InteractableObject : MonoBehaviour
{
    List<GameObject> inventory = new List<GameObject>();
    public enum Interaction
    {
        Nothing,
        Pickup,
        Info,
        Dialogue
    }

    public Interaction InteractionType;

    public List<string> Talk = new List<string>();



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Interact()
    {
        //Debug.Log($"Yipppeee {gameObject.name}");
        switch ( InteractionType )
        {
            case Interaction.Nothing:
                Nothing();
                break;

            case Interaction.Pickup:
                PickUp();
                break;

            case Interaction.Info:
                Info();
                break;

            case Interaction.Dialogue:
                Dialogue();
                break;
        }
    }
    public void Nothing()
    {
        Debug.Log("Nothing is here");
    }

    public void PickUp()
    {
        Debug.Log("Pickup");
    }

    public void Info()
    {
        Debug.Log("Info");
    }

    public void Dialogue()
    {
        Debug.Log("Dialogue");
    }
}
