using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
	int myInt = 5;

    void Start()
    {
        myInt = MultiplyByTwo(myInt);
		int myInt2 = MultiplyByTwo(3);
        Debug.Log(myInt);
		Debug.Log(myInt2);
    }

    int MultiplyByTwo (int number)
    {
        return number * 2;
    }
}