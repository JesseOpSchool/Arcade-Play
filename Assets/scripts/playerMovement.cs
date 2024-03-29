using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float dirX;
    float dirY;


    //bullet
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        }

    }

    private void FixedUpdate()
    {
        transform.Translate(transform.right * dirX * speed * Time.deltaTime);
        transform.Translate(transform.up * dirY * speed * Time.deltaTime);
    }
}
