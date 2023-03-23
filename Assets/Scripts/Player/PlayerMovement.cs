using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
    {

        PlayerControls controls;
        private float dirX = 0f;

        public bool facingDirectionRight = true;

        public Rigidbody2D rb;
        public Animator animator;
        private BoxCollider2D collider;

        [SerializeField] private float moveSpeed = 6f;
        [SerializeField] private float jumpForce = 15f;

        private bool isGrounded;
        private bool isGrounded2;

        [SerializeField] private LayerMask jumpableGround;
        [SerializeField] private LayerMask jumpableGround2;

        [SerializeField] private AudioSource jumpSoundEffect;


        private void Start()
        {
            collider = GetComponent<BoxCollider2D>();
        }

        private void Awake()
        {
            controls = new PlayerControls();
            controls.Enable();

            controls.Terrain.Move.performed += ctx => 
            {
                dirX = ctx.ReadValue<float>(); //Obtiene la direccion a la que nos estamos moviendo
            };

            controls.Terrain.Jump.performed += ctx => Jump();
        }

        // Update is called once per frame
        private void Update()
        {
            isGrounded = Physics2D.BoxCast(collider.bounds.center, collider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);  //Comprueba que la caja que encierra al personaje entra en contacto con la capa "jumpableGround" desde abajo a una distancia  de .1f
            isGrounded2 = Physics2D.BoxCast(collider.bounds.center, collider.bounds.size, 0f, Vector2.down, .1f, jumpableGround2);
            if(isGrounded == true)
            {
                animator.SetBool("isGrounded", isGrounded);
            }
            if(isGrounded2 == true)
            {
                animator.SetBool("isGrounded", isGrounded2);
            }
            else
            {
                animator.SetBool("isGrounded", isGrounded);
            }
            
            if(!(rb.bodyType == RigidbodyType2D.Static))
            {
                rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
            }
            animator.SetFloat("speed", Mathf.Abs(dirX));

            if(facingDirectionRight && dirX < 0 || !facingDirectionRight && dirX > 0)
            {
                Flip();
            }
        }

        private void Flip() //Para girar a donde mira el personaje segun la direccion en la que se mueva
        {
            facingDirectionRight = !facingDirectionRight;
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        }

        private void Jump()
        {
            if(isGrounded || isGrounded2)
            {
                if (gameObject != null)
                {   
                    jumpSoundEffect.Play();
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                }
            }
        }

        /*
        private void UpdateAnimationState()
        {
            MovementState state;

            //Detectamos si nuestro personaje ha comenzado a correr
            if(dirX > 0f)
            {
                state = MovementState.running;
                sprite.flipX = true;   //Si corremos hacia la derecha, el personaje mira hacia la derecha (por defecto)
            }
            else if(dirX < 0f)
            {
                state = MovementState.running;
                sprite.flipX = false;    //Si corremos hacia la izquierda, invertimos la mirada del personaje
            }else
            {
                state = MovementState.idle;
            }

            //Detectamos si nuestro personaje esta saltando o cayendo
            if(rb.velocity.y > .1f)
            {
                state = MovementState.jumping;
            }
            else if(rb.velocity.y < -.1f)
            {
                state = MovementState.falling;
            } 

            animator.SetInteger("state", (int)state);
        } 


        private bool IsGrounded()
        {
            return Physics2D.BoxCast(GetComponent<Collider>().bounds.center, GetComponent<Collider>().bounds.size, 0f, Vector2.down, .1f, jumpableGround);  //Comprueba que la caja que encierra al personaje entra en contacto con la capa "jumpableGround" desde abajo a una distancia  de .1f
        }
        */

        /*
        private Rigidbody2D rb;
        private BoxCollider2D collider;
        private SpriteRenderer sprite;
        private Animator animator;

        public Joystick joystick;

        [SerializeField] private LayerMask jumpableGround;

        private float dirX = 0f;
        [SerializeField] private float moveSpeed = 6f;
        [SerializeField] private float jumpForce = 15f;

        private enum MovementState { idle, running, jumping, falling };

        [SerializeField] private AudioSource jumpSoundEffect;


        // Start is called before the first frame update
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            collider = GetComponent<BoxCollider2D>();
            sprite = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        private void Update()
        {
            if(!(rb.bodyType == RigidbodyType2D.Static))         //Si el personaje pasa a ser estatico al morir, no obtenemos la velocidad para evitar warnings
            {
                //Comprobamos si se pretende mover el personaje con el joystick tactil (fijamos la velocidad uniforme del personaje)
                if(joystick.Horizontal >= .35f) 
                {
                    dirX = 1;
                }
                else if(joystick.Horizontal <= -.35f)
                {
                    dirX = -1f;
                }
                else 
                {
                    dirX = 0f;
                }
        
                rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
            }
            
            //Cuando pulsemos el espacio, el personaje saltara
            if(joystick.Vertical >= .65f && IsGrounded())
            {
                jumpSoundEffect.Play();
                GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x,jumpForce);
            }

            UpdateAnimationState();
        }

        private void UpdateAnimationState()
        {
            MovementState state;

            //Detectamos si nuestro personaje ha comenzado a correr
            if(dirX > 0f)
            {
                state = MovementState.running;
                sprite.flipX = true;   //Si corremos hacia la derecha, el personaje mira hacia la derecha (por defecto)
            }
            else if(dirX < 0f)
            {
                state = MovementState.running;
                sprite.flipX = false;    //Si corremos hacia la izquierda, invertimos la mirada del personaje
            }else
            {
                state = MovementState.idle;
            }

            //Detectamos si nuestro personaje esta saltando o cayendo
            if(rb.velocity.y > .1f)
            {
                state = MovementState.jumping;
            }
            else if(rb.velocity.y < -.1f)
            {
                state = MovementState.falling;
            } 

            animator.SetInteger("state", (int)state);
        } 

        private bool IsGrounded()
        {
            return Physics2D.BoxCast(collider.bounds.center, collider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);  //Comprueba que la caja que encierra al personaje entra en contacto con la capa "jumpableGround" desde abajo a una distancia  de .1f
        }
        */
    }
