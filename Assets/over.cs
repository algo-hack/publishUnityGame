using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class over : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Lose(){
         this.gameObject.GetComponent<Text>().enabled = true;

    }
}
