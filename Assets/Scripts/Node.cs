using System;
using TMPro;
using UnityEngine;

public class Node : MonoBehaviour
{
    
    [SerializeField] private TMP_Text letterText;
    public char letter;
    
    private void Update()
    {
        letterText.text = letter.ToString();
    }
    
    
}
