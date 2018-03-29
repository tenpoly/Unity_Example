using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
	public GameObject box;

    void Start()
    {
		Instantiate(box, new Vector3(3f, 0f, 2f), Quaternion.identity);
    }
}
