using System;
using UnityEngine;

public class orb : MonoBehaviour
{
    public static event Action OnOrbCollect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnOrbCollect?.Invoke();
            Destroy(gameObject);
        }
    }
}
