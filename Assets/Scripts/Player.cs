using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f; //velocidad del jugador
    private Rigidbody2D rb2d;
    private float movimiento;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource musiquita;
    private Vector2 movementInput;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //float moverX = Input.GetAxis("Horizontal");
        //float moverY = Input.GetAxis("Vertical");

        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        //rb2d.linearVelocity = new Vector2(moverX * velocidad, moverY * velocidad);

        animator.SetFloat("Horizontal", movementInput.x);
        animator.SetFloat("Speed", movementInput.magnitude);
    }
    private void FixedUpdate()
    {
        rb2d.linearVelocity = movementInput * velocidad;
    }
}
