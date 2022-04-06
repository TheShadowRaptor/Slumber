using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactionObject : MonoBehaviour
{
    public enum InteractableType
    {
        nothing,
        info,
        pickup,
        dialogue
    }

    [Header("Type of interactable")]
    public InteractableType interType;

    [Header("Simple info Message")]
    public string infoMessage;
    private Text infoText;

    [Header("Dialogue Text")]
    public DialogueManager dialogueManager;
    [TextArea]
    public string[] sentences;

    [Header("ToggleGameObjects")]
    public GameObject[] _gameObject;

    [Header("Remove gameObjects depending if the dialogue ended or not")]
    public bool changeDialogue;
    [HideInInspector] public bool pickedUp;

    public void Start()
    {
        infoText = GameObject.Find("InfoText").GetComponent<Text>();
    }

    public void Nothing()
    {
        Debug.LogWarning("Object " + this.gameObject.name + " had no type set.");
    }

    public void InfoMessage()
    {
        infoText.text = infoMessage;
        StartCoroutine(ShowInfo(infoMessage, 2.5f));
    }

    public void PickUp()
    {
        this.gameObject.SetActive(false);
    }

    public void Dialogue()
    {
        dialogueManager.StartDialogue(sentences);       
    }

    IEnumerator ShowInfo(string message, float delay)
    {
        infoText.text = message;
        yield return new WaitForSeconds(delay);
        infoText.text = null;
    }

    public void ToggleObjectsActive()
    {     
        for (int i = 0; i < _gameObject.Length; i++)
        {
            bool currentState = true;
            if (this._gameObject[i].activeSelf)
            {
                this._gameObject[i].SetActive(!currentState);
            }

            else if (!this._gameObject[i].activeSelf)
            {
                this._gameObject[i].SetActive(currentState);
            }
        }   
    }
}
