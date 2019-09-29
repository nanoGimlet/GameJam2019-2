using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool key;
    public Material[] color;
    private int material_index;
    public bool gameflag;
    public bool muteki;
    void Start()
    {
        key = true;
        material_index = 0;
        gameflag = true;
        muteki = false;
    }

    void Update()
    {
        
        if(key) {
            if (Input.GetKey ("up")) {
		    	transform.position += transform.forward * speed * Time.deltaTime;
		    }
		    if (Input.GetKey ("down")) {
			    transform.position -= transform.forward * speed * Time.deltaTime;
		    }
		    if (Input.GetKey("right")) {
			    transform.Rotate(0, 1, 0);
		    }
		    if (Input.GetKey ("left")) {
			    transform.Rotate(0, -1, 0);
		    }
        }

        if(Input.GetKeyDown("z")) {
            if(muteki) {
                muteki = false;
                material_index = 0;
            }else {
                muteki = true;
                material_index = 1;
            }
        }

        if(!gameflag) {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(sceneIndex);
        }

        this.GetComponent<Renderer>().material = color[material_index];
    }

    void OnCollisionEnter(Collision col) {
        if(muteki) {
            if(col.gameObject.name[0] == 'W') {
                Destroy(col.gameObject);
            }
        }else {
            if(col.gameObject.name[0] == 'W') {
                gameflag = false;
            }
        }
    }
}
