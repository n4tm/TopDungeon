using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D _boxCollider;
    private Vector3 _moveDelta;
    private RaycastHit2D _hit;
    
    private void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();  // Initialize BoxCollider2D
    }

    private void FixedUpdate()
    {
        // Get Keys from input
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        // Update moveDelta
        _moveDelta = new Vector3(x, y,0);

        // Swap sprite direction (right or left)
        if (_moveDelta.x > 0) transform.localScale = Vector3.one;
        else if (_moveDelta.x < 0) transform.localScale = Vector3.one + 2*Vector3.left;

        // Move if it does not collide with another layer horizontally
        _hit = Physics2D.BoxCast(transform.position, _boxCollider.size, 0,
            new Vector2(_moveDelta.x,0), Mathf.Abs(_moveDelta.x * Time.deltaTime),
            LayerMask.GetMask("Actor", "Blocking")
        );
        if (_hit.collider == null)
        {
            transform.Translate(_moveDelta.x * Time.deltaTime,0,0);
        }
        
        // Move if it does not collide with another layer vertically
        _hit = Physics2D.BoxCast(transform.position, _boxCollider.size, 0,
            new Vector2(0, _moveDelta.y), Mathf.Abs(_moveDelta.y * Time.deltaTime),
            LayerMask.GetMask("Actor", "Blocking")
        );
        if (_hit.collider == null)
        {
            transform.Translate(0,_moveDelta.y * Time.deltaTime,0);
        }
    }
}
