using UnityEngine;
using UnityEngine.InputSystem;

public class ShelfInteraction : MonoBehaviour
{
    private bool playerNearby;
    public GameObject programmingPanel;

    void Update()
    {
        if (playerNearby && Keyboard.current.eKey.wasPressedThisFrame)
        {
            programmingPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
                playerNearby = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }
}