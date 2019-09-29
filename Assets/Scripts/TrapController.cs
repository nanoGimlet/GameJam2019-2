using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    GameObject player;
    PlayerController script;
    GameObject key;
    KeyController keyscript;
    private bool quizflag;
    private int answer;
    public GameObject first, second, third, forth, fifth;
    private GameObject pre1, pre2, pre3, pre4, pre5;
    private int no;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<PlayerController>();
        key = GameObject.Find("Key");
        keyscript = key.GetComponent<KeyController>();
        no = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(no == 1) {
            if(Input.GetKeyDown("a")) {
                script.key = true;
                keyscript.point++;
                Destroy(pre1);
                Destroy(this.gameObject);
            }else if(Input.GetKeyDown("b") || Input.GetKeyDown("c") || Input.GetKeyDown("d")) {
                script.gameflag = false;
            }
        }else if(no == 2) {
            if(Input.GetKeyDown("b")) {
                script.key = true;
                keyscript.point++;
                Destroy(pre2);
                Destroy(this.gameObject);
            }else if(Input.GetKeyDown("a") || Input.GetKeyDown("c") || Input.GetKeyDown("d")) {
                script.gameflag = false;
            }
        }else if(no == 3) {
            if(Input.GetKeyDown("a")) {
                script.key = true;
                keyscript.point++;
                Destroy(pre3);
                Destroy(this.gameObject);
            }else if(Input.GetKeyDown("b") || Input.GetKeyDown("c") || Input.GetKeyDown("d")) {
                script.gameflag = false;
            }
        }else if(no == 4) {
            if(Input.GetKeyDown("c")) {
                script.key = true;
                keyscript.point++;
                Destroy(pre4);
                Destroy(this.gameObject);
            }else if(Input.GetKeyDown("b") || Input.GetKeyDown("a") || Input.GetKeyDown("d")) {
                script.gameflag = false;
            }
        }else if(no == 5) {
            if(Input.GetKeyDown("d")) {
                script.key = true;
                keyscript.point++;
                Destroy(pre5);
                Destroy(this.gameObject);
            }else if(Input.GetKeyDown("b") || Input.GetKeyDown("c") || Input.GetKeyDown("a")) {
                script.gameflag = false;
            }
        }
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.name == "Player") {
            // Debug.Log("Quiz");
            script.key = false;
            if(this.name == "1") {
                no = 1;
                pre1 = Instantiate(first) as GameObject;
                Debug.Log(pre1);
            }else if(this.name == "2") {
                no = 2;
                pre2 = Instantiate(second) as GameObject;
                Debug.Log(pre2);
            }else if(this.name == "3") {
                no = 3;
                pre3 = Instantiate(third) as GameObject;
                Debug.Log(pre3);
            }else if(this.name == "4") {
                no = 4;
                pre4 = Instantiate(forth) as GameObject;
                Debug.Log(pre4);
            }else if(this.name == "5") {
                no = 5;
                pre5 = Instantiate(fifth) as GameObject;
                Debug.Log(pre5);
            }
        }
    }
}
