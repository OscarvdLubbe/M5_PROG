using UnityEngine;

public class opdLes1 : MonoBehaviour
{
    private string Name;
    private int Score = 21;
    private bool Alive = true;
    void Start()
    {
        Debug.Log("Name = " + Name);
        Debug.Log("Am i alive" + Alive);
        Debug.Log("Score = " + Score);
        Begroeten(Name);
    }

    void Update()
    {
        
    }
    void Begroeten(string naam)
    {
        Debug.Log(naam);
    }
}
