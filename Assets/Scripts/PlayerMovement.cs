using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // player movement speed
    [SerializeField] private float speed;

    // player rigid body
    private Rigidbody2D body;

    // player animator
    private Animator animator;

    // check if player is on the ground
    private bool grounded;

    // track jump counts
    public int availJumpCounts = 2;

    private void Awake () {
        // get the player rigidbody instance
        body = GetComponent<Rigidbody2D>();

        // get the player animator instance
        animator = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        bool spaceInput = Input.GetKey(KeyCode.Space);

        /* 
            
            set player rigidbody's velocity to move player x movement

            control left & right

        */
        body.velocity = new Vector2(
            horizontalInput * speed, // move player x direction
            body.velocity.y // player y unchanged
        );


        /*
        
            flip facing left / right
        
        */
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(6, 6, 6);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-6, 6, 6);


        /* 
            
            set player rigidbody's velocity to move player y movement 
            
            control jump
        
        */
        if(spaceInput && grounded){
            Jump();
        }


        /*
        
            Set animator parameters

        */
        animator.SetBool("running", horizontalInput != 0);
        animator.SetBool("grounded", grounded);
    }

    private void Jump () {

        body.velocity = new Vector2(
            body.velocity.x, // player x unchanged
            speed * 3 // move player y direction
        );
        
        animator.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        if(collision.gameObject.tag == "Ground"){ 
            grounded = true;
        }
    }
}
