using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactScript : MonoBehaviour
{
    public Button biscoito, bolacha;
    public Collider2D doorCol;
    public Text text;
    public GameObject alien, question;


    // Start is called before the first frame update
    void Start()
    {
        biscoito.onClick.AddListener(Bixcoito);
        bolacha.onClick.AddListener(Bolacha);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bixcoito() => text.text = "Bixcoito NADA!";

    public void Bolacha()
    {
        doorCol.enabled = false;
        alien.SetActive(false);
        question.SetActive(false);
    }
}
