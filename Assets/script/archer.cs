using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archer : MonoBehaviour
{
    Animator animator;
    private float time;
    public GameObject arrowobject;
    public Transform shootpds;
    public KeyCode shootingkey;
    private AudioSource Play;
    Rigidbody2D rb;

    public AudioClip shoot;
    
    void Start()
    {
        Play= GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    
    void Update()
    {
        time += Time.deltaTime;
        
        if (time > 0.5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject arrowCloneobj = Instantiate(arrowobject);
                time = 0;
                arrowCloneobj.transform.position = shootpds.position;
                animator.SetTrigger("space");
                
            }

        }
    
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right*0.03f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 0.03f);
        }




    }


}
