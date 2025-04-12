using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 3f;
    public int points = 10;

    private Vector3 startPosition;
    private GameManager gameManager;

    void Start()
    {
        startPosition = transform.position;
        gameManager = FindObjectOfType<GameManager>();
        Destroy(this.gameObject, 5f);
    }

    void Update()
    {
        MoveCoin();
    }

    private void MoveCoin()
    {
        float movement = speed * Time.deltaTime;
        transform.Translate(0, -movement, 0);
    }

    void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            gameManager.AddScore(points);
            gameManager.PlaySound(3);
            Destroy(gameObject);
        }
    }
}