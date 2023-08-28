using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] float _speed = 5.0f;
    bool isStop = false;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStop == false)
        {
            _rigidBody.velocity = new Vector3(-Input.GetAxis("Horizontal") * _speed, 0, -10);
        }
        else
        {
            _rigidBody.velocity = new Vector3(0, 0, 0);
        }

        if (transform.position.x < -5) transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        if (transform.position.x > 5) transform.position = new Vector3(5, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            isStop = true;
        }
    }
}
