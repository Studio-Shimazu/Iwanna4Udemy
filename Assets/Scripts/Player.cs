using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 目標：向きを入力に合わせる
    // => Scaleの変更 右 x:1 , 左 x:-1
    [SerializeField] float speed;
    float movementX;
    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // キーボードの左右の入力を取得する
        movementX = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        SetDirection();
        // 取得した左右の入力を反映させてPlayerを移動させる:rigidbodyを使う
        rb2D.velocity = new Vector2(movementX * speed, rb2D.velocity.y);
    }

    void SetDirection()
    {
        if (movementX > 0)
        {
            // 右
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (movementX < 0)
        {
            // 左
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
