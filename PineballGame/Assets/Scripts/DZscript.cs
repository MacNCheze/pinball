using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZscript : MonoBehaviour
{
    public GameObject newBall;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Rigidbody>().CompareTag("Ball"))
        {
            count++;
            if (count<3)
            {
                Destroy(collision.gameObject);
                Instantiate(newBall);
            }
            else
            {
                Destroy(collision.gameObject);
            }

            if (count==1)
            {
                GameObject.FindWithTag("ball1").SetActive(false);
            }
            if (count == 2)
            {
                GameObject.FindWithTag("ball2").SetActive(false);
            }
            if (count == 3)
            {
                GameObject.FindWithTag("ball3").SetActive(false);
            }
        }
    }
}
