//Helps in travelling from one portal to another
using UnityEngine;
public class Teleportation : MonoBehaviour
{
    [SerializeField] Transform otherPortal;
    [SerializeField] Transform player;

   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.position = otherPortal.position;
            Debug.Log("Entered portal");
        }
    }

    void Update()
    {
        
    }
}
