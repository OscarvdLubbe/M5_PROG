using UnityEngine;
using TMPro;
using System.Diagnostics.CodeAnalysis;
public class points : MonoBehaviour
{
    public TextMeshProUGUI TMPro;
    private int score = 0;
    void OnEnable()
    {
        orb.OnOrbCollect += ballballballpointshit;
    }
    void OnDisable()
    {
        orb.OnOrbCollect -= ballballballpointshit;
    }
    void Update()
    {
        
    }

    void ballballballpointshit()
    {
        score++;
        TMPro.text = $"{score}";
    }
}
