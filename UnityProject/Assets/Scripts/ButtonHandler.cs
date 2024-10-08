using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void SpawnPlayerButtonClick()
    {
        GameManager.Instance.SpawnPlayer();
    }

    public void RunButtonDown()
    {
        GameManager.Instance.Player.GetComponent<MovementController>().StartRunning();
    }

    public void RunButtonUp()
    {
        GameManager.Instance.Player.GetComponent<MovementController>().StopRunning();
    }
}
