using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private GameManager gameManager;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);

        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
