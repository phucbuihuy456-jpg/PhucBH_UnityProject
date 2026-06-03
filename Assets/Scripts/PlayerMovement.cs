using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;       // Rigidbody2D của nhân vật
    public Animator animator;    // Animator cho chạy/idle
    public SpriteRenderer spriteRenderer; // SpriteRenderer để lật hướng
    public float moveSpeed = 3.5f;
    public float jumpForce = 8f;

    private bool isGrounded = true; // Giả lập đơn giản để nhảy

    void Update()
    {
        // --- Di chuyển ngang ---
        if (Input.GetKey(KeyCode.D))
        {
            // Di chuyển sang phải
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
            animator.SetBool("isMoving", true);
            spriteRenderer.flipX = false; // Hướng mặt về phải
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // Di chuyển sang trái
            rb.linearVelocity = new Vector2(-moveSpeed, rb.linearVelocity.y);
            animator.SetBool("isMoving", true);
            spriteRenderer.flipX = true; // Hướng mặt về trái
        }
        else
        {
            // Không nhấn gì → đứng yên
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            animator.SetBool("isMoving", false);
        }

        // --- Nhảy ---
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    // Khi chạm bất kỳ collider nào → bật isGrounded
    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}