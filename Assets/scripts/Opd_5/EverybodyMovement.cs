using UnityEngine;

public class EverybodyMovement : MonoBehaviour
{
    protected float BaseSpeed = 10;
    void Start()
    {
        
    }

    void Update()
    {
        movement();
    }
    protected void movement()
    {
        transform.position += Vector3.right * (BaseSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ball"))
        {
            Destroy(gameObject);
        }
        
    }
}
