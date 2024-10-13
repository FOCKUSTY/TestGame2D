using UnityEngine;
using Data;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private float Speed = 5f;
    private float _movementX;
    private float _movementY;
    private Vector3 _tempScale;

    private void FixedUpdate() {
        MovementHandler();
        DirectionHandler();
    }

    private void MovementHandler() {
        _movementX = Input.GetAxisRaw(Directions.Horisontal);
        _movementY = Input.GetAxisRaw(Directions.Vertical);

        transform.position += new Vector3(_movementX, _movementY, 0f) * Speed * Time.deltaTime;
    }

    private void DirectionHandler() {
        if(_movementX != 0)
            _tempScale.x = Mathf.Abs(transform.localScale.x) * _movementX;

        if(_movementY != 0)
            _tempScale.x = Mathf.Abs(transform.localScale.x) * _movementY;
    }
}