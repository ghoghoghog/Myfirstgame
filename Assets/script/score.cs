using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("arrow"))
        {
            Destroy(obj: gameObject);
            score2.Instance.myScore += 10;
            Debug.Log("myScore : " + score2.Instance.myScore);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(obj:gameObject);
        }
        
    }
}