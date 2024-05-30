using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 7f;
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private GameManager _GameManager;
    public bool PlayerDestroyEmos;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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

        if (PlayerDestroyEmos && Input.GetKeyDown(KeyCode.K))
        {
            DestroyEmos();
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
        if (other.CompareTag("Emos"))
        {
            PlayerDestroyEmos = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerDestroyEmos = false;
    }

    private void DestroyEmos()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 1f); // Change 1f to the appropriate radius
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Emos"))
            {
                Destroy(collider.gameObject);
                break; // Exit loop after destroying the first Emos object
            }
        }
    }
}
