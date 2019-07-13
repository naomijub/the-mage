using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageWalkController : MonoBehaviour
{
    Rigidbody2D _rb;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        _rb.MovePosition(_rb.position + 
            new Vector2(x * speed * Time.deltaTime, y * speed * Time.deltaTime));
    }
}
