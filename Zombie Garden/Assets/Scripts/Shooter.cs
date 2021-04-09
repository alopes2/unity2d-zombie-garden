using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private Projectile _projectile;

    [SerializeField]
    private GameObject _gun;

    public void Fire()
    {
        Instantiate(_projectile, _gun.transform.position, _gun.transform.rotation);
    }
}
