using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 100f;
    [SerializeField] private GameObject _deathVFX;

    public void DealDamage(float damage)
    {
        _health -= damage;

        var isDead = _health <= 0;
        if (isDead)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!_deathVFX) { return; }
        var deathVFXObject = Instantiate(_deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
    }
}
