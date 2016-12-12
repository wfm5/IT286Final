using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour {
    int radius;
    float x;
    int type;
    float speed;
    float origin_X;
    float origin_Y;

    // Use this for initialization
	void Start () {
        origin_X = transform.position.x;
        origin_Y = transform.position.y;
        if (gameObject.name == "EnemyAi(Clone)")
            type = 1;
        if (gameObject.name == "EnemyAi2(Clone)")
            type = 2;
        speed = 2;
    }
	
	// Update is called once per frame
	void Update () 
    {
        radius = 3;
        float x = Time.time* speed;
        if (type == 1)
            transform.position = new Vector3(Mathf.Cos(x) * radius + origin_X, Mathf.Sin(x) * radius + origin_Y, 0);
        if (type == 2)
            transform.position = new Vector3(Mathf.Cos(x) * radius + origin_X, origin_Y, 0);
    }
    
}
