using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop_Test : MonoBehaviour
{
    public GameObject box;
    public int width;
    public int height;


    void Start()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Instantiate(box, new Vector3(x * 1.5f, 0f, y * 1.5f), Quaternion.identity);
            }
        }
    }
}
