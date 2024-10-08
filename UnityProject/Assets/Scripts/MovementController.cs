using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private CharacterController m_characterController;
    private Animator m_characterAnimator;
    private float m_speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_characterController = GameManager.Instance.Player?.GetComponent<CharacterController>();
        m_characterAnimator = GameManager.Instance.Player?.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        m_characterController.SimpleMove(m_characterController.transform.forward * m_speed);
    }

    public void StartRunning()
    {
        m_speed = 0.75f;
        m_characterAnimator.SetBool("isMoving", true);
    }

    public void StopRunning()
    {
        m_speed = 0.0f;
        m_characterAnimator.SetBool("isMoving", false);
    }

}
