using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public GameObject alien;
    public GameObject text;
    static int enterCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(enterCount < 1) 
        {
            alien.SetActive(true);
            text.SetActive(true);
        }
        enterCount += 1;  
    }
}
