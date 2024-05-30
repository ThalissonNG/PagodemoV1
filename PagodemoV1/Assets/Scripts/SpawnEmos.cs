using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEmos : MonoBehaviour
{
    [SerializeField] private GameObject[] SpawnerEmos;
    public GameObject Emos;

    public float StartTimer;
    public float CurrentTimer = 20f;

    void Start()
    {
        SpawnerEmos = GameObject.FindGameObjectsWithTag("SpawnEmos");
        StartTimer = CurrentTimer;
    }

    void Update()
    {
        CurrentTimer = CurrentTimer - Time.deltaTime;

        if (CurrentTimer <= 0 ) 
        {
            Spawner();
            CurrentTimer = 20f;
        }
    }

    private void Spawner()
    {
        int posicao = Random.Range(0, SpawnerEmos.Length);

        Instantiate(Emos, SpawnerEmos[posicao].transform.position, SpawnerEmos[posicao].transform.rotation);
    }
}
