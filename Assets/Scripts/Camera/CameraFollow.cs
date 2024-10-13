using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private Transform Player;
    
    [SerializeField] private float SmoothSpeed;

    private Vector3 _offset;
    
    private void Start() {
        _offset = transform.position - Player.position;
    }

    private void FixedUpdate() {
        Vector3 position = Player.position + _offset;
        transform.position = Vector3.Lerp(transform.position, position, SmoothSpeed);
    }
}