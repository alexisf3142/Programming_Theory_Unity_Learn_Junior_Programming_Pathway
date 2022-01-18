using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SampleManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string playerName;
    public TextMeshProUGUI greetingsText;
    void Start()
    {
        playerName = MainManager.Instance.playerName;
        greetingsText.SetText("Greetings " + playerName + "! Click all the shapes and see what they do!");
    }

    
}
