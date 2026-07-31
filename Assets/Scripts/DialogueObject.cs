using UnityEngine;
using UnityEngine.U2D;

public class DialogueObject : Interactuable
{
    [Header("Contenido del Diálogo")]
    [TextArea(3, 5)]
    [SerializeField] private string japaneseText;
    [SerializeField] private Sprite ilustration;

    protected override void Interactuar()
    {
        if (dialogueUI == null) return;

        if (dialogueUI.EstaActivo)
        {
            // Si ya estaba abierto y volviste a apretar 'E', se cierra
            dialogueUI.CerrarDialogo();
            
        }
        else
        {
            // Si estaba cerrado, le mandamos el texto y el dibujo a la UI para que los muestre
            dialogueUI.ShowDialogue(japaneseText, ilustration);
        }

    }
}
