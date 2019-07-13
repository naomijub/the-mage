using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveLlama : MonoBehaviour
{
    public GameObject llama;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision) => llama.SetActive(true);
}
