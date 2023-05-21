using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_cntrl : MonoBehaviour
{
    [SerializeField]
    AudioSource ses;
    [SerializeField]
    AudioClip kapanses;
   

    public bool kapansesi = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (kapansesi)
        {
            if (collision.gameObject.tag == "Player")
            {

                ses.PlayOneShot(kapanses);

                kapansesi = false;

            }
        }
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        ses = GetComponent<AudioSource>();
        kapansesi = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
