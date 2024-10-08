using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    public GameObject m_playerPrefab;

    private static GameManager m_instance;
    private static GameObject m_player;

    public static GameManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<GameManager>();
            }

            if (m_instance == null)
            {
                GameObject gameManager = new GameObject("GameManager");
                m_instance = gameManager.AddComponent<GameManager>();
            }

            return m_instance;
        }
    }

    public GameObject Player
    {
        get
        {
            return m_player;
        }
    }

    public void SpawnPlayer()
    {
        m_player = Instantiate(m_playerPrefab, Camera.main.transform.position + Camera.main.transform.forward * 0.25f, Quaternion.identity);
    }
}
