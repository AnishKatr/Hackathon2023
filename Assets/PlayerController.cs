using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;
    Vector2 movementInput;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    private bool doorCol = false;
    private bool stoveCol = false;
    private bool bookshelfCol = false;
    private bool sinkCol = false;
    public static int orderSpot=0;
    public TextMeshProUGUI txt;


    Animator animator;

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        orderSpot=0;
    }


    private void FixedUpdate(){
        
        if(movementInput != Vector2.zero){

            bool success = TryMove(movementInput);

            if(!success){
                success = TryMove(new Vector2(movementInput.x, 0));

                if(!success){
                    success = TryMove(new Vector2(0, movementInput.y));
                }

            }

            animator.SetBool("isWalking", success);
        } else {
            animator.SetBool("isWalking", false);
        }

        if(movementInput.x < 0){
            spriteRenderer.flipX = true;
        }
        else if(movementInput.x > 0){
            spriteRenderer.flipX = false;
        }

    }
    private bool TryMove(Vector2 direction){
        int count = rb.Cast(
                direction,
                movementFilter,
                castCollisions,
                moveSpeed * Time.fixedDeltaTime + collisionOffset);


            if(count == 0){
                rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            } else{
                return false;
            }
    }

    void OnMove(InputValue movementValue){
        movementInput = movementValue.Get<Vector2>();
    }
    void Update(){
        if(Input.GetKeyDown (KeyCode.F))
        {
            if (orderSpot%4==0){
                if (stoveCol){
                    orderSpot++;
                }
            }
            else if (orderSpot%4==1){
                if (sinkCol){
                    orderSpot++;
                }
            }
            else if (orderSpot%4==2){
                if (bookshelfCol){
                    orderSpot++;
                }
            }
            else if (orderSpot%4==3){
                if (doorCol){
                    orderSpot++;
                }
            }
            
            
        }
        Debug.Log(orderSpot);
        txt.text=orderSpot.ToString();
        if (orderSpot>=12){
                SceneManager.LoadScene("introductionCHP2");
            }
    }
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "book"){
            SceneManager.LoadScene("Chapter2");
        }
        else if (col.gameObject.tag == "door"){
            doorCol=true;
            
        }
        else if (col.gameObject.tag == "stove"){
            stoveCol=true;

        }
        else if (col.gameObject.tag == "bookshelf"){
            bookshelfCol=true;
        }
        else if (col.gameObject.tag == "sink"){
            sinkCol=true;
        }

    }
    void OnTriggerExit2D(Collider2D col){

        if (col.gameObject.tag == "door"){
            doorCol=false;
            
        }
        else if (col.gameObject.tag == "stove"){
            stoveCol=false;

        }
        else if (col.gameObject.tag == "bookshelf"){
            bookshelfCol=false;
        }
        else if (col.gameObject.tag == "sink"){
            sinkCol=false;
        }

    }
}
