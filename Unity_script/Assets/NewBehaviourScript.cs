using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string str = " ";
    static int ASCII_SIZE = 256;
    void Start()
    {
        printNums();
        Debug.Log(getMaxOccuringChar(str));
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
    public static char getMaxOccuringChar(string str)
    {
        int[] count = new int[ASCII_SIZE];
        
        int len = str.Length;
        for (int i = 0; i < len; i++)
        {
            count[str[i]]++;
        }

        int max = -1;
        char result = ' ';

        for (int i = 0; i < len; i++)
        {
            if (max < count[str[i]])
            {
                max = count[str[i]];
                result = str[i];
            }
        }
        return result;
    }
    
}
