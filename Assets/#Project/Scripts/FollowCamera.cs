using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement;
        movement.x = 0;
        movement.y = target.position.y + 4.5f;
        movement.z = target.position.z - 8;
        transform.position = movement;
    }
}
