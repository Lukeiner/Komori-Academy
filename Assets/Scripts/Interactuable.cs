using UnityEngine;

public class Interactuable : MonoBehaviour
{
    private bool jugadorCerca = false;
    void Update()
    {
        if (jugadorCerca && Input.GetKeyDown(KeyCode.E))
        {
            Interactuar();
        }
    }
    void Interactuar ()
    {
        Debug.Log("Holi");
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = true;
            Debug.Log("Presiona E para interactuar");
        }
    }
    private void OnTriggerExit2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = false;
            Debug.Log("Jugador se alejó");
        }
    }
}
