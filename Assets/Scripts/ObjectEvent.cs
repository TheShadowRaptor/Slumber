using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEvent : MonoBehaviour
{
    public PlayerInteractable playerInteractable;
    public interactionObject interactionObject;
    public DialogueManager dialogueManager;

    // Update is called once per frame
    void Update()
    {
        interactionObject = playerInteractable.currentInterObjScript;

        if (!interactionObject)
        {
            interactionObject = null;
        }

        else if (dialogueManager.dialogueEnded == true && interactionObject.changeDialogue == true)
        {
            interactionObject.ToggleObjectsActive();
            dialogueManager.dialogueEnded = false;
            
        }  
    }
}
