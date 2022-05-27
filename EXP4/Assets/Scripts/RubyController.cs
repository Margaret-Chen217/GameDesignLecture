using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public int speed = 5;
    public float timeInvincible = 2.0f;
    private bool isInvincible = false;
    private float invincibleTimer;
    Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);//为什么要存储观察方向？因为与机器人相比，Ruby 可以站立不动。她站立不动时，Move X 和 Y 均为 0，因此状态机不知道要使用哪个方向（除非我们指定方向）
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public int Health//属性首字母大写
    {
        get
        {
            return currentHealth;
        }
        // set
        // {
        //     currentHealth = value;
        // }
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;//改变帧率
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        Debug.Log("start");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get input from player
        horizontal = Input.GetAxis("Horizontal");//why return float type 
        vertical = Input.GetAxis("Vertical");//tabnine 太好用了//静态方法， 没有实例 全局可调用

        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {//使用 Mathf.Approximately 而不是 ==，这是因为计算机存储浮点数的方式意味着精度会有很小的损失。
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }

        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);

        // //Moving Ruby
        // Vector2 position = transform.position;
        // position.x += horizontal * speed * Time.deltaTime;//3m/s
        // position.y += vertical * speed * Time.deltaTime;//修复抖动后速度慢了十倍， 弹幕说物理移动使用的是物理帧
        // //transform.position = position;
        // rigidbody2d.MovePosition(position);//普通方法（成员变量方法）， 有实例才能调用

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer <= 0)
            {
                isInvincible = false;
            }
        }
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
            {
                return;//无敌状态直接返回
            }
            animator.SetTrigger("Hit");
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);//限制血量的边界值
        Debug.Log("当前血量：" + currentHealth);
    }
}
