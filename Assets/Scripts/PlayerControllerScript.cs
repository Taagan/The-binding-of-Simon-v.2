using UnityEngine;

[RequireComponent(typeof(PlayerMovementScript))]
[RequireComponent(typeof(PlayerScript))]
[RequireComponent(typeof(PlayerAttackScript))]
public class PlayerControllerScript : MonoBehaviour
{
    protected PlayerMovementScript playerMover;
    protected PlayerScript playerScript;
    float solidDropBuffer;
    public float solidDropBufferTime = 1;
    bool solidDropCheck;
    bool solidDropWindow;
    float lastMoveY;
    PlayerAttackScript attack;

    Vector2 currentInput;

    // Start is called before the first frame update
    void Start()
    {
        playerMover = GetComponent<PlayerMovementScript>();
        playerScript = GetComponent<PlayerScript>();
        attack = GetComponent<PlayerAttackScript>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMover.Movement();
    }
}
