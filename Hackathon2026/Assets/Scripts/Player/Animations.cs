using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += new Vector2(0, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += new Vector2(0, -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += new Vector2(-1, 0);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += new Vector2(1, 0);
            
        }

        if(direction.y > 0)
        {
            animator.SetBool("IsForward", true);
        }
        if(direction.y < 0)
        {
            animator.SetBool("IsForward", false);
        }
        if(direction.y == 0 && direction.x != 0)
        {
            animator.SetBool("IsForward", false);
        }
        

        if(direction == Vector2.zero)
        {
            animator.SetBool("IsMoving", false);

        }
        else
        {
            animator.SetBool("IsMoving", true);
        }
    }
}
