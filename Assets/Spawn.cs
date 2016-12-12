using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject enemy;
    public GameObject enemy2;
	// Use this for initialization
    void Start()
    {
        if(gameObject.name == "Spawner")
            Instantiate(enemy, transform.position, Quaternion.identity);
        if(gameObject.name == "Spawner2")
            Instantiate(enemy2, transform.position, Quaternion.identity);


    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
