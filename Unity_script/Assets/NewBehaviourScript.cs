using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        printNums();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void printNums()
    {
        for(int i = 0; i <= 1000; i++)
        {
            var n = i.ToString();
            if(n.Contains("3") && n.Contains("7"))
            {
                Debug.Log(n);
            }
        }
    }
}
