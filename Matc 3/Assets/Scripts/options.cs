using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    public GameObject plevel;
    public GameObject Options;

    private void Start()
    {

    }



    private void OnMouseUpAsButton()
    {

        switch (gameObject.name)
        {
            case "Options":
                plevel.SetActive(true);
                break;

        }


    }
}










