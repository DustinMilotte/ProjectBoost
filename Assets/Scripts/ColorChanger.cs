using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Renderer rend;
    public Color newColor;

    public void ChangeColor()
    {
        rend.material.color = newColor;
    }
}
