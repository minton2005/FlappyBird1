using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PipeCreatorScript : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _pipe;

    private float _timer;
    private void Start()

    {
        SpawnPipe();
    }

    private void Update()
{
    _timer += Time.deltaTime;

    if (_timer > _maxTime)
    {
        SpawnPipe();
        _timer = 0;
    }
}


    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }

    
}
