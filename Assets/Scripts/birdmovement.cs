using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdmovement : MonoBehaviour
{
    //public variable
    public float j = 4.5f;


    //private variable

    private bool isdead = false;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnPause();
        UIManager.instance.restart.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isdead)
        {
            UIManager.instance.start.gameObject.SetActive(false);
            GameManager.instance.OnResume();
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, j);
        }
        if (Input.GetKeyDown(KeyCode.R) && isdead)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isdead = true;
        GameManager.instance.OnPause();
        UIManager.instance.restart.gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        counter++;
        UIManager.instance.counter.text =counter+"";
    }
}
