using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class Enemy : MonoBehaviour
{
    private Quaternion _startRotation;
    
    public event Action<Enemy> Death;
    
    public void SetRunDirection(Quaternion direction)
    {
        
    }

    public void Run()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Wall>(out _))
        {
            Death?.Invoke(this);
        }
    }
}
