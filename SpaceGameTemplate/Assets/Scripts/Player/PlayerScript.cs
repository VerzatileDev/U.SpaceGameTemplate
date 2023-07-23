using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] private string Name;
    [SerializeField] private int MovementSpeed;
    [SerializeField] private Transform ShootingPoint;
    [SerializeField] private AudioClip shootingAudioClip;
    [SerializeField] private float coolDownTime = 0.3f; // Time between shots.
    [SerializeField] private Bullet bulletPrefab;
    private float shootTimer;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ShipMovement();
        shootTimer += Time.deltaTime;
        if (shootTimer > coolDownTime && Input.GetKey(KeyCode.Space))
        {
            shootTimer = 0f;
            Instantiate(bulletPrefab, ShootingPoint.position, Quaternion.identity);
            //GameManager.Instance.PlaySfx(shooting);
        }
    }

    private void ShipMovement()
    {
        float HorizontalInput = Input.GetAxis("Horizontal") * MovementSpeed;

        HorizontalInput *= Time.deltaTime;
        transform.Translate(HorizontalInput, 0, 0);
    }
}
