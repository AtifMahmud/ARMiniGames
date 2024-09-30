using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        // Debug.Log(player.GetComponent<CharacterController>().isGrounded);    
    }

    public void SpawnPlayer()
    {
        Debug.Log("Click");
        Instantiate(player, Camera.main.transform.position + 0.2f * Camera.main.transform.forward, Quaternion.identity);
    }
}
