using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int gridWidth = 2; 
    public int gridHeight = 2;

    public GameObject[,] grid;

    public GameObject prefab;

    public static Grid instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[gridWidth,gridHeight];
        
        for (int i = 0; i < gridWidth; i++) 
        {
            for (int j = 0; j < gridHeight; j++)
            {
                grid[i, j] = Instantiate<GameObject>(prefab);
                grid[i, j].transform.position = new Vector2(i, j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
