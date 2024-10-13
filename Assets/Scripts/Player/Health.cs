using System;
using UnityEngine;
using UnityEngine.UI;
using static Data.Texts;

class PlayerHealth : MonoBehaviour {
    [SerializeField] private Player player;
    [SerializeField] private Text text;

    private void Start() {
        Player.OnHealthChanged += ChangeText;
    }

    private void ChangeText(int health) {
        int hearts = (int)Math.Floor((float)health/10);

        text.text = "";

        for(int i = 0; i < hearts; i++) {
            if(i == 5)
                text.text += '\n';
                
            text.text += Heart; 
        };
    }
}