using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public GameObject shieldVisual;
    private bool isShieldActive = false;
    private float shieldTimer = 5f;

    void Start()
    {
        shieldVisual.SetActive(false);
    }
    void Update()
    {
        if (isShieldActive)
        {
            shieldTimer -= Time.deltaTime;
            if (shieldTimer <= 0f)
            {
                DeactivateShield();
            }
        }
    }

    public void ActivateShield(float duration)
    {
        isShieldActive = true;
        shieldTimer = duration;
        shieldVisual.SetActive(true);
    }

    public void DeactivateShield()
    {
        isShieldActive = false;
        shieldVisual.SetActive(false);
    }

    public bool IsShieldActive()
    {
        return isShieldActive;
    }
}
