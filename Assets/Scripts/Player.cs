using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 目標：キーボードでPlayerを左右に動かす
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
        // 取得した左右の入力を反映させてPlayerを移動させる:rigidbodyを使う
        rb2D.velocity = new Vector2(movementX * speed, rb2D.velocity.y);
    }
}
