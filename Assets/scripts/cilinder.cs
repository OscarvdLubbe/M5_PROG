using UnityEngine;

public class cilinder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float minScale = 0.25f;
    [SerializeField] private float maxScale = 2f;
    void Start()
    {
        float randomSize = Random.Range(minScale, maxScale);
        transform.localScale = Vector3.one * randomSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
