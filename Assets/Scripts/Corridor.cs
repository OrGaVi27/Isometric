using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class Corridor : MonoBehaviour
{
    public GameObject originRoom;
    public GameObject adjacentRoom;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(LoadScene());
        }
    }


    IEnumerator LoadScene()
    {
        //Evento para llamar al fade Para cambiar de habitación
        GameEvents.current.RoomFadeTrigger();

        yield return new WaitForSeconds(0.25f);
        
        //Activar la habitación adyacente y desactivar la actual
        adjacentRoom.GetComponent<MeshRenderer>().enabled = true;
        foreach (Transform child in adjacentRoom.transform) child.gameObject.SetActive(true);

        originRoom.GetComponent<MeshRenderer>().enabled = false;
        foreach (Transform child in originRoom.transform) child.gameObject.SetActive(false);
    }
}
