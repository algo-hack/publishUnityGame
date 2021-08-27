using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-0.1f, 0, 0));
        if(transform.position.z < Camera.main.transform.position.z){
            Destroy(gameObject);
        }
    }
}
