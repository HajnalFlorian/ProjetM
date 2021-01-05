using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionInput : MonoBehaviour
{
    private float speed = 10;
    private Vector2 Deplacement = Vector2.zero;
    private CharacterController Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Deplacement.x = Input.GetAxisRaw("Horizontal");
        Deplacement.y = Input.GetAxisRaw("Vertical");
        Deplacement = transform.TransformDirection(Deplacement);

        Player.Move(Deplacement * Time.deltaTime * speed);



    }
}
