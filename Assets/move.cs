using UnityEngine;
using System.Collections;

public class move : MonoBehaviour 
{
    
    public float speed = 5.0F;
    
	// Use this for initialization
	void Start () 
    {

    }
	
	// Update is called once per frame
	void Update () 
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);
        
    }
    
}
