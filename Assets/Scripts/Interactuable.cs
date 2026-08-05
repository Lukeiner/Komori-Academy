using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interactuable : MonoBehaviour
{
    protected bool closePlayer = false;
    [SerializeField] private AudioSource select;
    [Header("UI References")]
    [SerializeField] protected DialogueUI dialogueUI;
    void Update()
    {
        if (closePlayer && Input.GetKeyDown(KeyCode.E))
        {
            Interactuar();
            select.Play();
        }
    }
    protected virtual void Interactuar ()
    {
        Debug.Log("Holi");
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            closePlayer = true;
            Debug.Log("Presiona E para interactuar");    
        }
    }
    protected virtual void OnTriggerExit2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            closePlayer = false;
            Debug.Log("Jugador se alejó");
            if (dialogueUI != null && dialogueUI.EstaActivo)
            {
                dialogueUI.CerrarDialogo();
            }
        }
    }
}
