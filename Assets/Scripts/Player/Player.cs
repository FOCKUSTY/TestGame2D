using UnityEngine;

public class Player : MonoBehaviour, IDamageable {
    [SerializeField] private Game game;
    [SerializeField] private int Health = 100;
    public static Data.Events.OnHealthChanged OnHealthChanged;

    private void Start() {
        OnHealthChanged.Invoke(Health);
    }

    int IDamageable.Health {
        get => Health;

        set {}
    }

    private void Dead() {
        Destroy(this);
        game.GameOver();
    }

    void IDamageable.TakeDamage(int damage) {
        if(Health - damage <= 0) {
            Dead();
            return;
        };

        Health -= damage;

        OnHealthChanged.Invoke(Health);
    }
}