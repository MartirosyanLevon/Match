using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public int width;
    public int height;
    public GameObject tile_1;
    public GameObject tile_2;
    private BackgroundTile[,] allTiles;

    public int getwidth()
    {
        return width;
    }
    public int getheight()
    {
        return height;
    }
    private void Awake()
    {
        width = Random.Range(7, 11);
        height = Random.Range(7, 11);

    }
    void Start()
    {
        allTiles = new BackgroundTile[width, height];
        SetUp();
    }
    private void SetUp()
    {


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
                Vector2 tempPosition = new Vector2(i, j);
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
                if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0))
                    Instantiate(tile_2, tempPosition, Quaternion.identity);
                else if ((j % 2 == 0 && i % 2 != 0) || (j % 2 != 0 && i % 2 == 0))
                    Instantiate(tile_1, tempPosition, Quaternion.identity);
            }

        }

    }
}


