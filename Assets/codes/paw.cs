using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paw : MonoBehaviour
{

    public static GameObject pawc;
        
    
    // Start is called before the first frame update
    void Start()
    {
        pawc = GameObject.Find("paw");
        
        
    }

    // Update is called once per frame
    void Update()
    {

           gameObject.transform.position += new Vector3(0, -5 * Time.deltaTime, 0);
        

        

    }
}
