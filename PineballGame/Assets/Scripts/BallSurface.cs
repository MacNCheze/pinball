using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallSurface : MonoBehaviour
{
    public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0.1f, 0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position.Set(0,floor.transform.position.y + 0.17501f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.score += collision.gameObject.GetComponent<BounceBackBumper>().value;

        GameManager.Instance.displyTxt.text = "Score: " + GameManager.Instance.score;
    }
}
