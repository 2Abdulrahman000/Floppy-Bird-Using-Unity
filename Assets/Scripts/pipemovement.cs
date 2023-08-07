using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovement : MonoBehaviour
{
    public GameObject[] pipes;
    public float step = 0.1987655f;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnPause();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < pipes.Length; i++)
        {
            if (pipes[i].transform.position.x <= -22.1f)
            {
                pipes[i].transform.position = new Vector2(12.04f, Random.Range(-1.0f,-7.50f));
            }
            else
            {
                pipes[i].transform.position -= new Vector3(step, 0);  
            }
        }
    }
}
