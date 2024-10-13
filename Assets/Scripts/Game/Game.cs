using UnityEngine;

public class Game : MonoBehaviour {
    [SerializeField] private GameObject Player;
    
    private void Awake() {
        if(!Player)
            Player = GameObject.FindGameObjectWithTag(nameof(Player));
    }
    
    public void GameOver() {
        Debug.Log("Game over");
    }
};