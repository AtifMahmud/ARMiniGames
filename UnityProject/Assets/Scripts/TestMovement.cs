using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    public CharacterController m_character;
    private Animator m_animator;
    private bool m_isMoving;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = m_character.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isMoving)
        {
            RunForward();
        }
    }

    public void RunForward()
    {
        m_character.SimpleMove(m_character.transform.forward * 0.9f);
    }

    public void StartMove()
    {
        if (!m_isMoving)
        {
            m_animator.SetBool("isMoving", true);
            m_isMoving = true;
        }
    }

    public void StopMove()
    {
        if (m_isMoving)
        {
            m_animator.SetBool("isMoving", false);
            m_isMoving = false;
        }
    }

}
