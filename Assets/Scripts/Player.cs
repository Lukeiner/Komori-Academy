using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f; //velocidad del jugador
    private Rigidbody2D rb2d;
    private float movimiento;
    [SerializeField] private AudioSource musiquita;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moverX = Input.GetAxis("Horizontal");
        float moverY = Input.GetAxis("Vertical");

        rb2d.linearVelocity = new Vector2(moverX * velocidad, moverY * velocidad);
    }
}
