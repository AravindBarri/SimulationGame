using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    ScoreManager scobj;
    // Start is called before the first frame update
    void Start()
    {
        scobj = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, .5f, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
      
            scobj.decreaseScore();
        }
    }
}
