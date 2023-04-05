using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    float currtime;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        




        currtime += Time.deltaTime;
        if (currtime > 2)
        {
            float newX = Random.Range(-4.5f, 4.5f);
            Instantiate(gameObject);
            gameObject.transform.position = new Vector3(newX, 8, 0);

            currtime = 0;






        }











    }
   




}
