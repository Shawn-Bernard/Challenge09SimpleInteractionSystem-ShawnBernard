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

    public List<string> Text = new List<string>();

    public void Interact()
    {
        switch (InteractionType)
        {
            case Interaction.Nothing:
                Nothing();
                break;
            case Interaction.Pickup:
                PickUp();
                break;
            case Interaction.Info:
                StartCoroutine(InfoTimer());// Starting a timer for info text
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
        gameObject.SetActive(false);
    }

    public IEnumerator InfoTimer()
    {
        // foreach text in my string list, will change the gameplay ui to the text and wait 3 second and go to empty 
        foreach (string text in Text)
        {
            //Displaying my first text
            GameManager.Instance.UImanager.ChangeGameplayText(text);

            //Wait 3 seconds
            yield return new WaitForSeconds(3f);

            //Then making it empty and getting ready for new text in list
            GameManager.Instance.UImanager.ChangeGameplayText("");
        }
    }

    public void Dialogue()
    {
        Debug.Log("Dialogue");
    }
}
