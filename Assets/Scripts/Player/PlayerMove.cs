using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 플레이어 스탯
    private PlayerStats stats;
    // 플레이어 리지드바디2D
    private Rigidbody2D rigid;
    // 플레이어의 스프라이트 렌더러
    private SpriteRenderer sprite;
    // 플레이어의 애니메이션
    private Animator anim;
    public Vector2 inputVec;

    private void Awake()
    {
        stats = GetComponent<PlayerStats>();
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 플레이어를 움직이는 함수
    /// </summary>
    private void Move()
    {
        // InputManager의 입력값을 가져와준다.
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        // 왼쪽으로 움직이면 
        if(inputX < 0)
        {
            // flipX를 켜주고
            sprite.flipX = true;
        }
        // 오른쪽으로 움직이면
        else if(inputX > 0)
        {
            // flipX를 꺼준다.
            sprite.flipX = false;
        }

        // 위에서 가져온 입력값을 Vector2 타입인 inputVec에 넣어주고
        inputVec = new Vector2(inputX, inputY).normalized;

        // Rigidbody2D를 이용해서 움직여준다.
        rigid.linearVelocity = inputVec * stats.MoveSpeed;

        // 이동하고 있으면 이동 애니메이션을 켜준다.
        anim.SetFloat("StandRun", inputVec.magnitude);
    }
}
