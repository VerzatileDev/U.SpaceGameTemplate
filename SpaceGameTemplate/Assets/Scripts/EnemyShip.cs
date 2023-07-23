using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private float bottomEdge;


    private void Start()
    {
        bottomEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y -1;
    }
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }

    private void Update()
    {
        transform.position += Vector3.down * Time.deltaTime;
        if (transform.position.y < bottomEdge)
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }
    }
}
