using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private float offset = -10;
    [SerializeField] Transform target;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float z = transform.position.z + speed * Time.deltaTime; 
        Vector3 position = transform.position;
        position.z = Mathf.Min(target.position.z + offset, z);
        transform.position = position;
    }
}
