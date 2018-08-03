using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levle : MonoBehaviour
{
    public GameObject missionEasy;
    public GameObject missionMedium;
    public GameObject missionHard;
    public GameObject Easy;
    public GameObject Medium;
    public GameObject Hard;

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Medium":
                missionMedium.SetActive(true);
                break;

            case "Easy":
                missionEasy.SetActive(true);
                break;

            case "Hard":
                missionHard.SetActive(true);
                break;

        }
    }
    void Start()
    {

    }

    void Update()
    {

    }
}
