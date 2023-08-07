using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject bird;
    public GameObject pipes;
    // Start is called before the first frame update
    void Start()
    {
        if (!instance) instance = this; 
    }

    public void OnPause() 
    {
        bird.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        pipes.GetComponent<pipemovement>().enabled = false;
    }
    public void OnResume()
    {
        bird.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        pipes.GetComponent<pipemovement>().enabled = true;
    }
}
