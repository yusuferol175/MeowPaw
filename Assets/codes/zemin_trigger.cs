using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D()
    {
        player.yerdemi = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="ziplayabilir")
        {
            player.yerdemi = true;
        }
    }
    void OnTriggerExit2D()
    {
        player.yerdemi = false;
    }
}
