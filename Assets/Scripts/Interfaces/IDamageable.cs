public interface IDamageable {
    protected int Health { get; set; }

    public void TakeDamage(int damage);
}