using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archer : MonoBehaviour
{

    public GameObject arrowobject;
    public Transform shootpds;
    public KeyCode shootingkey;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject arrowCloneobj = Instantiate(arrowobject );
     
            arrowCloneobj.transform.position = shootpds.position;



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
