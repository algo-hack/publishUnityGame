using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createScrip : MonoBehaviour
{
    public GameObject green1;
    public GameObject green2;

    int border = 1000;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > border){
            CreateMap();
        }
    }
    void CreateMap(){
        if(green1.transform.position.z < border){
            border += 2000;
            Vector3 temp = new Vector3(0, 0.05f, border);
            green1.transform.position = temp;
        }else if(green2.transform.position.z<border){
            border += 2000;
            Vector3 temp = new Vector3(0, 0.05f, border);
            green2.transform.position = temp;

        }
    }
}