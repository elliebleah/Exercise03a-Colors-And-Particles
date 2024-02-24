using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ColorFader : MonoBehaviour
{
    private Color originalColor;
    public Color newColor;
    public string targetTag;
    public GameObject circle;
    private int colorID;

    void Start()
    {
        colorID = 0;
        originalColor = circle.GetComponent<SpriteRenderer>().color;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag(targetTag))
        {
            colorID++;
            StartCoroutine(ColorSwitch());
        }
    }

    IEnumerator ColorSwitch()
    {
        Color red = new Color(1f, 0f, 0f); // Changed "random.range" to "Random.Range", and adjusted the range of random values
        circle.GetComponent<SpriteRenderer>().color = red;
        yield return new WaitForSeconds(0.1f);
        circle.GetComponent<SpriteRenderer>().color = originalColor;
    }
}
