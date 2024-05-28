using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    [SerializeField] private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(MoveHorizontal, 0f, MoveVertical);

        if (Movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(Movement);
        }
    }

    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(MoveHorizontal, 0f, MoveVertical);
        _rigidbody.velocity = Movement * MoveSpeed;
    }
}
