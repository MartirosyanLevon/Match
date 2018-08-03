using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figur : MonoBehaviour
{

    public int width;
    public int height;
    public GameObject blue;
    public GameObject green;
    public GameObject orange;
    public GameObject red;
    public GameObject violet;
    private BackgroundTile[,] allFigures;


    void Start()
    {
        allFigures = new BackgroundTile[width, height];
        SetUp();

    }

    private void SetUp()
    {
        width = GetComponent<Board>().getwidth();
        height = GetComponent<Board>().getheight();

        List<GameObject> figures = new List<GameObject>()
          {
          red,green,orange,violet,blue
         };

        for (int i = 0; i < width; i++)
        {


            for (int j = 0; j < height; j++)
            {
                if (i == 1 && j == 5)
                    continue;
                if (i == 5 && j == 3)
                    continue;
                if (i == 4 && j == 3)
                    continue;
                Vector3 tempPosition = new Vector3(i, j,-2);
                if (width == 9)
                {
                    tempPosition.x += 0.6f;
                }
                if (width == 8)
                {
                    tempPosition.x += 1.1f;
                }
                if (width == 7)
                {
                    tempPosition.x += 1.6f;
                }
                    Instantiate(figures[Random.Range(0, figures.Count)], tempPosition, Quaternion.identity);
            }
        }
    }
}

