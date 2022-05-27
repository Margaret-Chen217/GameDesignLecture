using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rigidbody2d;
    public bool vertical;
    public float changeTime = 3;
    private float timer;
    private int direction = 1;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0){
            direction = -direction;
            timer = changeTime;
        }

        Vector2 position = GetComponent<Rigidbody2D>().position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y",direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("Move Y", 0);
            animator.SetFloat("Move X",direction);
        }

        rigidbody2d.MovePosition(position);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        RubyController rubyController = collision.gameObject.GetComponent<RubyController>();
        if(rubyController != null){
            rubyController.ChangeHealth(-1);
        }
    }
}
