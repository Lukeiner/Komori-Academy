using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Image image;
    [SerializeField] private Image imageDay;
    public bool EstaActivo => dialoguePanel.activeSelf;
    public void ShowDialogue (string text, Sprite boceto = null, Sprite rutina = null)
    {
        dialogueText.text = text;

        // 1. Control del Boceto (Persona)
        if (boceto != null)
        {
            image.sprite = boceto;
            image.gameObject.SetActive(true);
        }
        else
        {
            image.sprite = null;
            image.gameObject.SetActive(false);
        }

        // 2. Control de la Imagen del Día (Rutina) -> ¡AQUÍ ESTABA EL ELSE QUE FALTABA!
        if (rutina != null)
        {
            imageDay.sprite = rutina;
            imageDay.gameObject.SetActive(true);
        }
        else
        {
            imageDay.sprite = null;
            imageDay.gameObject.SetActive(false);
        }

        // 3. Activamos el Panel Principal
        dialoguePanel.SetActive(true);
    }
    public void CerrarDialogo()
    {
        dialogueText.text = string.Empty;

        // 1. Limpiamos y ocultamos la ilustración
        image.sprite = null;
        image.gameObject.SetActive(false);

        // 2. Limpiamos y ocultamos la imagen del día (¡ESTO FALTABA!)
        if (imageDay != null)
        {
            imageDay.sprite = null;
            imageDay.gameObject.SetActive(false);
        }

        // 3. Ocultamos el Panel Principal
        dialoguePanel.SetActive(false);
    }
}
