using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text start;
    public Text counter;
    public Text restart;
    // Start is called before the first frame update
    void Start()
    {
        if (!instance) instance = this;   
    }
}
