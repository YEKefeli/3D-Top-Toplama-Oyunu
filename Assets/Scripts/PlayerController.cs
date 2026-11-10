using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody rb;
    private Vector3 movement;
    private int score = 0;
    [SerializeField] private TMP_Text scoreText;
    private bool isGrounded = false;
    private bool jumpRequested = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ? 1f : 0f)
                 - (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ? 1f : 0f);

        float vertical = (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ? 1f : 0f)
                       - (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) ? 1f : 0f);

        movement = new Vector3(horizontal, 0f, vertical).normalized;

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W TUŞU ALGILANDI");
            Debug.Log("W SONRASI HAREKET: " + movement);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumpRequested = true;
        }
    }

    private void FixedUpdate()
    {
        Vector3 velocity = rb.linearVelocity;
        velocity.x = movement.x * speed;
        velocity.z = movement.z * speed;
        rb.linearVelocity = velocity;

        Debug.Log("TOPUN HIZI: " + rb.linearVelocity);
        Debug.Log("Hareket: " + movement);

        if (jumpRequested)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpRequested = false;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Puan: " + score);
        scoreText.text = "Puan: " + score;
    }

    public int GetScore()
    {
        return score;
    }
}
