using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.25f;


    public GameObject enemy;
    public GameObject enemyBullet; 
    public GameObject enemyBulletClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            timer += Time.deltaTime;
            if (timer > timeToMove && numOfMovements < 3)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;
                numOfMovements++;

            }
            if (numOfMovements == 3)
            {
                transform.Translate(new Vector3(0, -0.16f, 0));
                numOfMovements = -1;
                speed = -speed;
                timer = 0;
            }

            fireEnemyBullet();
        }
    }

    void fireEnemyBullet()
    {
        if (Random.Range(0f, 1500f) < 1)
        {
            enemyBulletClone = Instantiate(enemyBullet, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.5f, 0), transform.rotation) as GameObject;
        }
    }
}
