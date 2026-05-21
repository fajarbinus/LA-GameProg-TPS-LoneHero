using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    private GameBehavior _gameManager;

    private int _enemyLives = 3;
    public int EnemyLives
    {
        get { return _enemyLives; }
        set
        {
            _enemyLives = value;
            if (_enemyLives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("EnemyDown!");
            }
        }
    }

    void Start()
    {
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player Detected - Attack!!!");
            if (_gameManager != null)
            {
                _gameManager.HP -= 2;
                Debug.Log("PlayerHP: "+_gameManager.HP);
            }
        }
            
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            EnemyLives -= 1;
            Debug.Log("Critical hit! EnemyLives : " + _enemyLives);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player out of Range - Resume Patrol!");
        } 
    }
}
