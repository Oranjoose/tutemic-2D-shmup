using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float _speed = 2f;
    
    [SerializeField] GameObject _gameState;
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * _speed, 0);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        Destroy(gameObject);

        if (collider.gameObject.name == "Player")
            GameState.Instance.InititateGameOver();

        Destroy(collider.gameObject);
        GameState.Instance.IncreaseScore(10);
    }
}
