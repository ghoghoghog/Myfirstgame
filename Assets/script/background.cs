using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Transform target;
    public float scrollAmount;
    public float moveSpeed;
    public Vector3 moveDirection;


    private void Update()
    {
        transform.position += moveDirection * moveSpeed *0.3f* Time.deltaTime;
        if (transform.position.x<=-scrollAmount)
        {
            transform.position = target.position - moveDirection * scrollAmount;
        }
    }
}
