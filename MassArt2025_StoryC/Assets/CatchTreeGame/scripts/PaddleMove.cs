using System.Collections;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float xLimit = 8f;   // horizontal bounds

    private Vector2 movement;
    private bool moveLeftOn = false;
    private bool moveRightOn = false;

    [Header("Game References")]
    public GameHandler_tree gameHandlerObj;
    public GameObject hitVFX;
    public GameObject instruct;

    private bool hasTouched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (GameObject.FindWithTag("GameHandler_tree") != null)
        {
            gameHandlerObj = GameObject.FindWithTag("GameHandler_tree").GetComponent<GameHandler_tree>();
        }

        instruct.SetActive(true);
    }

    void FixedUpdate()
    {
        // 1️⃣ Get input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = 0; // remove vertical input

        // 2️⃣ Button input
        if (moveLeftOn) movement.x = -1;
        if (moveRightOn) movement.x = 1;

        // 3️⃣ Calculate next position
        Vector2 newPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;

        // 4️⃣ Clamp within horizontal bounds only
        newPosition.x = Mathf.Clamp(newPosition.x, -xLimit, xLimit);

        // 5️⃣ Move paddle
        rb.MovePosition(newPosition);

        // 6️⃣ Turn off instructions on first movement
        if (!hasTouched && movement.x != 0)
        {
            instruct.SetActive(false);
            hasTouched = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("tree") || other.gameObject.CompareTag("eviltree"))
        {
            gameObject.GetComponent<AudioSource>().Play();

            GameObject boomFX = Instantiate(hitVFX, other.transform.position, Quaternion.identity);
            StartCoroutine(DestroyVFX(boomFX));

            Destroy(other.gameObject);

            if (other.gameObject.CompareTag("tree"))
                gameHandlerObj.AddScore(1);
            else
                gameHandlerObj.AddScore(-5);
        }
    }

    IEnumerator DestroyVFX(GameObject theEffect)
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(theEffect);
        gameObject.GetComponent<AudioSource>().Stop();
    }

    // 🔹 Button input functions
    public void MoveLeft() => moveLeftOn = true;
    public void MoveLeftOff() => moveLeftOn = false;
    public void MoveRight() => moveRightOn = true;
    public void MoveRightOff() => moveRightOn = false;
}

