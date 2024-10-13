using UnityEngine;
using Data;

class Enemy : MonoBehaviour {
    [SerializeField] private GameObject Player;
    [SerializeField] private int Damage;

    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject obj = collision.gameObject;

        if(obj.CompareTag(Tags.Player)) {
            obj.GetComponent<IDamageable>().TakeDamage(Damage);
        }
    }

    private void Awake() {
        if(!Player)
            Player = GameObject.FindGameObjectWithTag(nameof(Player));
    }
}