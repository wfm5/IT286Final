using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scroll : MonoBehaviour {

    public GameObject player;
    Vector3 camVelocity = new Vector3(3, 0, 0);
    bool isOn;
    static bool offscreen;
    Scene thisScene;
    // Use this for initialization
	void Start () {
        isOn = false;
        offscreen = false;
        thisScene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("z"))
            isOn = true;
        
        if (isOn)
        {
            transform.Translate(camVelocity * Time.deltaTime);
        }
        if (offscreen){
            Debug.Log("DEATH");
            SceneManager.LoadScene(thisScene.buildIndex);
        }

	}
	void OnTriggerStay2D(Collider2D other)
	{
        if (other.gameObject.tag == "Player")
        {
            offscreen = false;
        }        
	}
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            offscreen = true;
        }   
    }
}
