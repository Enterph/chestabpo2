using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinaple : MonoBehaviour
{
    float timer = 0;
     private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            transform.Rotate(new Vector3(0, 90, 0));
            timer = 0;
        }
        direction = new Vector3(0, 0, 5);
        direction = transform.TransformDirection(direction);
    }
}
