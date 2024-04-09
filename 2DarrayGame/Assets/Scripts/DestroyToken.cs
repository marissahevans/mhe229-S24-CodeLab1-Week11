using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyToken : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onMouseOver()
    {
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        Grid.instance.grid[x, y] = null;
        Destroy(gameObject);
    }
}
