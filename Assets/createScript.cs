using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createScript : MonoBehaviour
{
    public GameObject green1;
    public GameObject green2;
    
    public GameObject  enemy1;
    public GameObject  enemy2;
    public GameObject  enemy3;
    public GameObject  enemy4;

    int border = 1000;
    int enemyBorder = 80;

    // Start is called before the first frame update
    void Start()
    {
        CreateMap();
    }
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > border){
            CreateMap();
        }
        if(transform.position.z > enemyBorder){
            CreatEnemy();
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
    void CreatEnemy(){
        if(enemy1 = null){
            if(Random.Range(0, 3) == 0){
                Instantiate(enemy1, new Vector3(-5f, 0f, enemyBorder + 250f), enemy1.transform.rotation);
            }  
        }
        
        if(enemy2 = null){
            if(Random.Range(0, 3) == 0){
                Instantiate(enemy2, new Vector3(-1.8f, 0f, enemyBorder + 250f), enemy2.transform.rotation);
                
            }
        }

    if(enemy3 = null){
        if(Random.Range(0, 3) == 0){
            Instantiate(enemy3, new Vector3(1.8f, 0f, enemyBorder + 250f), enemy2.transform.rotation);
             
        }
    }
        if(enemy4 = null){
            if(Random.Range(0, 3) == 0){
                Instantiate(enemy4, new Vector3(5f, 0f, enemyBorder + 250f), enemy2.transform.rotation);
            }
            enemyBorder += 80;
        }
    }
}
