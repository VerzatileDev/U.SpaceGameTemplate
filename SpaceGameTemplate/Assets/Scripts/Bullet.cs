using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float lifeTime = 1.5f; // Time Amount Bullet will stay Active

    internal void DestroySelf() // Disable Game Object, And then Destroy it.
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    private void Awake()
    {
        Invoke("DestroySelf", lifeTime); // Destroy bullet when Time Reached.
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);

    }
}