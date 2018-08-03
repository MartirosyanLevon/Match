using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Button : MonoBehaviour
{
    public GameObject plevel;
    private bool Options;


    private void OnMouseUpAsButton()
    {

        switch (gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("main");
                break;

            case "How To":
                SceneManager.LoadScene("how to");
                break;

            case "Back":
                SceneManager.LoadScene("start");
                break;
        }



    }
}
