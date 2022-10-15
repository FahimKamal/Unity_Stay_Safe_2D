using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 10f;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
