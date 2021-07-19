using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spelarens begränsningar läggs här. Controllern kan se nedräknarvariabler och sådant men den kan kalla alla metoder så mycket den vill också
//om inte spelarens dash cooldown är nedräknad så händer inget.
[RequireComponent(typeof(PlayerScript))]
public class PlayerMovementScript : WalkerMovementScript
{

    public int speedLevel { get; protected set; } = 0;

    [HideInInspector] public PlayerScript playerScript;
    SpriteRenderer sRenderer;//antagligen temporär typ, används nu för att ändra färg beroende på movementState

    public float runSpeed = 1;
    // Start is called before the first frame update
    override protected void Start()
    {
        base.Start();
        playerScript = GetComponent<PlayerScript>();
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    override protected void Update()
    {              
        base.Update();
    }   
    
    public void Movement()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        velocity.x = move.x;
        velocity.y = move.y;
        SetHorizontalVelocity(velocity.x * runSpeed);
        SetVerticalVelocity(velocity.y * runSpeed);
    }  
}
