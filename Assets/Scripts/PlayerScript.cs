using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject bulletClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {// Directions are flipped since our object is flipped 180 degrees to have face up
        movement();
        fireBullet();
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }

    }

    void fireBullet()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            bulletClone = Instantiate(bullet, new Vector3(player.transform.position.x, player.transform.position.y + 0.6f, 0), transform.rotation) as GameObject;
        }
    }

}


