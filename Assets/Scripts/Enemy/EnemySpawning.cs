using UnityEngine;

public class EnemySpawning : MonoBehaviour {
    [SerializeField] private Transform Player;
    [SerializeField] private GameObject EnemyPrefab;
    
    public float SpawningTime = 0.5f;
    public float Distance = 3f;
    
    private float _timer;
    private readonly int _max = 10;

    private void Start() {
        _timer = SpawningTime;
    }

    private void FixedUpdate() {
        _timer -= Time.deltaTime;

        if(_timer > 0)
            return;
        
        _timer = SpawningTime;

        if(transform.childCount < _max)
            Instantiate(EnemyPrefab, Player.position * Distance, Quaternion.identity, transform);
    }
}