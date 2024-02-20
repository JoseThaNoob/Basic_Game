using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Strawb_Collect : MonoBehaviour
{
    private int strawbs = 0;

    [SerializeField] private Text strawbText;
    public Text infoText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawb"))
        {
            Destroy(collision.gameObject);
            strawbs++;
            strawbText.text = "Strawbs Collected:  " + strawbs;
        }
    }
}
