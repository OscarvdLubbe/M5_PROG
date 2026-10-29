using UnityEngine;

public class JustSlowEnemy : EverybodyMovement
{
    [SerializeField] private float SlowSpeed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BaseSpeed = SlowSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ball"))
        {
            Destroy(gameObject);
        }
    }
}
