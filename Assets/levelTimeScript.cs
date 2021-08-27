using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class levelTimeScript : MonoBehaviour
{
    public Text levelGUI;
    public moveScript moveScript;
    public int level = 1;
    private int countBorder = 2000;
	private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        levelGUI.text = "Level:" + level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= countBorder){
            countBorder += 2000;
            count ++;
            if(count <= 8){
                Level1();
            }
        }
    }

    void Level1(){
        if(count == 1){
            level = 2;
        }

        if(count == 3){
            level = 3;
        }

        if(count == 5){
            level = 4;
        }

        if(count == 8){
            level = 5;
        }
        moveScript.level = level;
        levelGUI.text = "Level:" + level.ToString();
    }
}
