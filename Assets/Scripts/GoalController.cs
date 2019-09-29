using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameObject goal;
    GameObject player;
    PlayerController script;
    private bool goalevent;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<PlayerController>();
        goalevent = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(goalevent) {
            if(Input.GetKeyDown("q")) {
                script.gameflag = false;
            }
        }
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.name == "Player") {
            Instantiate(goal);
            script.key = false;
            goalevent = true;
        }
    }
}
