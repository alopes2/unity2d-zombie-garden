using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField]
    private float _minSpawnDelay = 1f;

    [SerializeField]
    private float _maxSpawnDelay = 5f;

    [SerializeField]
    private Attacker _attacker;

    private bool _spawn = true;
    

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(_spawn)
        {
            yield return new WaitForSeconds(Random.Range(_minSpawnDelay, _maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(_attacker, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
