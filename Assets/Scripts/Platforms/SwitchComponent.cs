using UnityEngine;

public class SwitchComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameEvents.current.SwitchTrigger();
        }
    }
}
