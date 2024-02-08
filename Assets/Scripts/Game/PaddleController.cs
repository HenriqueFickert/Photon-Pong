using UnityEngine;
using Fusion;

[RequireComponent(typeof(Rigidbody2D))]
public class PaddleController : NetworkBehaviour
{
    private const float Speed = 10f;
    private const float BoundY = 3f;
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;


    private void Awake()
    {
        _rb ??= GetComponent<Rigidbody2D>();
        _sr ??= GetComponentInChildren<SpriteRenderer>(); 
    }

    public override void Spawned()
    {
        base.Spawned();
    }

    private float _direction = 0f;
    public override void FixedUpdateNetwork()
    {
        if (!GetInput(out NetworkInputData data)) return;

        _direction = data.Direction;

        if (Mathf.Approximately(_direction, 0f))
        {
            return;
        }

        float yMovement = _direction * Speed * Runner.DeltaTime;
        Vector2 targetPos = _rb.position + (Vector2.up * yMovement);
        targetPos.y = Mathf.Clamp(targetPos.y, -BoundY, BoundY);
        _rb.MovePosition(targetPos);
    }

    public void ChangePaddleColor(Color color)
    {
        _sr.color = color;
    }
}