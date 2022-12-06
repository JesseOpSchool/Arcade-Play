using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float dirX;
    float dirY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");


    }

    private void FixedUpdate()
    {
        transform.Translate(transform.right * dirX * speed * Time.deltaTime);
        transform.Translate(transform.up * dirY * speed * Time.deltaTime);
    }
}
