using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            m_Animator.SetTrigger("Light");
        }

        if (Input.GetKey(KeyCode.Z))
        {
            m_Animator.SetTrigger("Unlight");
        }

        if (Input.GetKey(KeyCode.C))
        {
            m_Animator.SetTrigger("Power");
        }
    }
}
