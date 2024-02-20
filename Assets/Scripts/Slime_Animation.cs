using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Animation : MonoBehaviour

{
    [SerializeField] public float speed;
    [SerializeField] public float distance;
    private bool movingright;
    public Transform IsGrounded;

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D contact = Physics2D.Raycast(IsGrounded.position, Vector2.down, distance);


        if (contact.collider == false ) 
        {
        if (movingright == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingright = false;
            }
        else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingright = true;
            }
        }
    }
}
