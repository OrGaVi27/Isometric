using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    private void Start()
    {
        GameEvents.current.onSwitchTrigger += OnPlatformRotate;
    }

    public void OnPlatformRotate()
    {
        // Rotate the platform
        transform.Rotate(0, 90, 0);
    }
}
