using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody2D;
    private float _movePositionX;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _movePositionX = Input.GetAxisRaw("Horizontal");
        _rigidbody2D.velocity = new Vector2(_movePositionX * _speed, _rigidbody2D.velocity.y);
    }
}
