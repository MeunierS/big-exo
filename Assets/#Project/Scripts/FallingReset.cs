using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -3){
            Vector3 resetPosition;
            resetPosition.x= 0;
            resetPosition.y= 0.5f;
            resetPosition.z= -3;
            transform.position = resetPosition;
        }
    }
}
