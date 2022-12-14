using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int hp = 2;


    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void trunOffAnimation()
    {
        GetComponent<Animator>().enabled = false;
    }
    public void takeDamage()
    {
        Debug.Log("hit the enemy");
        hp--;
        if (hp <= 0)
        {
            die();
        }
    }

    void die()
    {
        anim.SetBool("IsAlive", false);
        //GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, 1.5f);
    }
}
