using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int hp = 2;
    public float speed = -5f;
    public float strarting;


    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        GoToPosition();

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void GoToPosition()
    {
       
    }

    public void turnOfAnimation()
    {
        GetComponent<Animator>().enabled = false;
        
    }

}
