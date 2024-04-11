using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Strawb_Collect : MonoBehaviour
{
    private int strawbs = 0;
    [SerializeField] private int total = 0;

    [SerializeField] private TextMeshProUGUI strawbText;
    public Text infoText;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawb"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            strawbs++;
            strawbText.text = "Strawbs Collected: " + strawbs;
        }
    }
}
