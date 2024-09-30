using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject bouncyBall;

    public void SpawnBall()
    {
        Debug.Log("Click");
        Instantiate(bouncyBall, Camera.main.transform.position + 0.2f * Camera.main.transform.forward, Quaternion.identity);
    }
}
