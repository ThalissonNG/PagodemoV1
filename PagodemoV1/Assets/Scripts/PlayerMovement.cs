using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 7f;
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private GameManager _GameManager;
    [SerializeField] private IaEmos _IaEmos;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _IaEmos = GameObject.Find("Emos").GetComponent<IaEmos>();
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Emos") && Input.GetKeyDown(KeyCode.K))
        {
            _IaEmos.DestroyEmo();
        }
    }
}
