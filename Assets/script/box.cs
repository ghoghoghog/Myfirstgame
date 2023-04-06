using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject Box;


    float currtime;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        




        currtime += Time.deltaTime;
        if (currtime > 1)
        {
            
            GameObject newbox = Instantiate(Box);
            float newX = Random.Range(-4.5f, 4.5f);
            newbox.transform.position = new Vector3(newX, 8, 0);
            
            
            
            

            currtime = 0;






        }











    }
   




}
