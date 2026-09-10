using Unity.VisualScripting;
using UnityEngine;

public class randomtowersspawn : MonoBehaviour
{
    [SerializeField] private GameObject cilinder;
    
    void Update()
    {
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(0f, 0f);
        float z = Random.Range(-5f, 5f);
        

        ;
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(cilinder,new Vector3(x, y, z),Quaternion.identity);
        }
    }
}
