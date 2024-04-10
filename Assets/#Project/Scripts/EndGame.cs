using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
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
        other.GetComponent<PlayerControl>().speed = 0;
        other.GetComponent<PlayerControl>().jumpHeight = 0;
    }
}
