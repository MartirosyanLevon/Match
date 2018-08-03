using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public bool next, lose, home, win;
    public Text Score;
    public GameObject plost;
    public GameObject nextlevel;

    private int count;

    void Start()
    {
        home = false;
        count = 15;
        next = false;
        lose = false;
        win = false;
    }

    void Update()
    {

        if (lose)
            playerlose();
        if (next && !lose)
            count--;
        Score.text = count.ToString();

    }

    void playerlose()
    {
        if (count == 0)
            plost.SetActive(true);
    }
    void playerwin()
    {
        nextlevel.SetActive(true);

    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "home":
                SceneManager.LoadScene("start");
                break;

            case "replay":
                SceneManager.LoadScene("main");
                break;

        }

    }


}
