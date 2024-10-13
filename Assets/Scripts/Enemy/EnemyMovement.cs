using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] private Transform Player;
    [SerializeField] private float Speed = 1.5f;

    private void Awake() {
        if(!Player)
            Player = GameObject.FindGameObjectWithTag(nameof(Player)).transform;
    }

    private void Update() {
        Vector3 direction = Player.position - transform.position;

        direction.Normalize();

        transform.Translate(direction * Time.deltaTime * Speed);
    }
}