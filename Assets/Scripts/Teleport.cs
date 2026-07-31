using UnityEngine;

public class Teleport : Interactuable
{
    private float translation = 30f;

    [Header("Interactions")]
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject player;


    protected override void Interactuar ()
    {
            Vector3 camPos = cam.transform.position;
            camPos.x += translation;
            cam.transform.position = camPos;

            Vector3 playerPos = player.transform.position;
            playerPos.x += translation;
            player.transform.position = playerPos;
        
    }

}
