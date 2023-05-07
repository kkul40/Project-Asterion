using System;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public int column, row;
    public float space;
    
    public GameObject gridPrefab;

    private GameObject[,] playerGrids;

    public PlayerManager playerManager;

    private void Awake()
    {
        playerManager = GameObject.FindObjectOfType<PlayerManager>();
    }


    private void Start()
    {
        playerGrids = new GameObject[column, row];
        CreateGrid();
    }


    private void CreateGrid()
    {
        float spaceX = 0;
        float spacey = 0;
        
        for (int x = 0; x < column; x++)
        {
            spacey = 0;
            for (int y = 0; y < row; y++)
            {
                var grid = Instantiate(gridPrefab, new Vector3(spaceX, spacey), Quaternion.identity);
                var gridScr = grid.GetComponent<Grid>();
                gridScr.pos = new Vector2(x, y);

                switch (x)
                {
                    case 0:
                        gridScr.fighterType = FighterTypes.Healer;
                        break;
                    case 1:
                        gridScr.fighterType = FighterTypes.Wizard;
                        break;
                    case 2:
                        gridScr.fighterType = FighterTypes.Fighter;
                        break;
                }
                
                playerGrids[x, y] = grid;

                spacey += space;
            }

            spaceX += space;
        }
    }

    
}