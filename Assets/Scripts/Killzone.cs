using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Transform spawn;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Jugador en la killzone");
            StartCoroutine(RespawnPlayer());
        }
    }

    IEnumerator RespawnPlayer()
    {
        player.GetComponent<ThirdPersonController>().enabled = false;
        player.gameObject.transform.position = spawn.transform.position;
        yield return new WaitForSeconds(0.2f);
        player.GetComponent<ThirdPersonController>().enabled = true;
    }
}
