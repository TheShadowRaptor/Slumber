using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject[] toggleObject;
    public void ButtonHit()
    {
        for (int i = 0; i < toggleObject.Length; i++)
        {
            bool currentState = true;
            if (this.toggleObject[i].activeSelf)
            {
                this.toggleObject[i].SetActive(!currentState);
            }

            else if (!this.toggleObject[i].activeSelf)
            {
                this.toggleObject[i].SetActive(currentState);
            }
        }
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
