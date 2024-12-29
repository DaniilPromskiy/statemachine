using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public SpriteRenderer spriteRenderer;
    public GameObject redZone;

    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void EnableHighlight()
    {
        redZone.SetActive(true);
    }

    public void DisableHighlight()
    {
        redZone.SetActive(false);
    }

    public void ToggleHighlight()
    {
        redZone.SetActive(!redZone.activeSelf);
    }

    public void SetTransparency(bool isTransparent)
    {
        Color color = spriteRenderer.color;
        color.a = isTransparent ? 0.5f : 1f;
        spriteRenderer.color = color;
    }

    public void ToggleTransparency()
    {
        Color color = spriteRenderer.color;
        color.a = color.a == 1f ? 0.5f : 1f;
        spriteRenderer.color = color;
    }
}