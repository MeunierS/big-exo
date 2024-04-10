using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Vector3 resetPosition;
            resetPosition.x= 0;
            resetPosition.y= 0.5f;
            resetPosition.z= -3;
            other.transform.position = resetPosition;
        }
    }
}
