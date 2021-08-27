using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;


    int border = 1000;
    float speed = 0f;
    float movePower = 0.2f;
    bool jmpingFlug = true;
    Rigidbody rb;

    public int level = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void  FixedUpdate()
    {
        if(Input.GetKey("up")){
            Accel();
        }
        if(Input.GetKey("right")){
            Right();
        }
        if(Input.GetKey("left")){
            Left();
        }
        if(Input.GetKey("down")){
            Down();
        }

        if(Input.GetKeyDown("space")){
            if(jmpingFlug == true){
                jump();
            }
        }

        if(level == 1 && 50 > speed){
            speed =50;
        }

        if(level == 2 && 75> speed){
            speed = 75;
        }

        if(level == 3 && 100 > speed){
            speed = 100;
        }

        if(level == 4 && 125 > speed){
            speed = 125;
        }

        speed -= 2f;
        if(speed < 0){
            speed = 0f;
        }
    }

    void Accel(){
        speed += 3f;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
    }
    void Down(){
        speed -= 3f;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
    }
    void Right(){
        if(transform.position.x <= 5f){
            Vector3 temp = new Vector3 (transform.position.x + movePower, transform.position.y, transform.position.z);
            transform.position = temp;
        }
    }
    void Left(){
        if (transform.position.x >= -5f) {
			Vector3 temp = new Vector3 (transform.position.x - movePower, transform.position.y, transform.position.z);
			transform.position = temp;
		}
    }
    void jump(){
        jmpingFlug = false;
        rb.AddForce(Vector3.up * 500);

    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("hit");
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("stop!");
            speed = 0;
        }
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
