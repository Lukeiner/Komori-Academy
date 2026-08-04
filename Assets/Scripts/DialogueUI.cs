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

        if (boceto != null)
        {
            image.sprite = boceto;
            image.gameObject.SetActive(true);
        }

        else
        {
            image.gameObject.SetActive(false);
        }

        if (rutina != null)
        {
            imageDay.sprite = rutina;
            imageDay.gameObject.SetActive(true);
        }

        dialoguePanel.SetActive(true);
    }

    public void CerrarDialogo()
    {
        dialogueText.text = string.Empty;

        // 2. Quitamos el sprite de la imagen y la ocultamos
        image.sprite = null;
        image.gameObject.SetActive(false);
        dialoguePanel.SetActive(false);
    }

}
