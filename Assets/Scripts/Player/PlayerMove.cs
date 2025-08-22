using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �÷��̾� ����
    private PlayerStats stats;
    // �÷��̾� ������ٵ�2D
    private Rigidbody2D rigid;
    // �÷��̾��� ��������Ʈ ������
    private SpriteRenderer sprite;
    // �÷��̾��� �ִϸ��̼�
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
    /// �÷��̾ �����̴� �Լ�
    /// </summary>
    private void Move()
    {
        // InputManager�� �Է°��� �������ش�.
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        // �������� �����̸� 
        if(inputX < 0)
        {
            // flipX�� ���ְ�
            sprite.flipX = true;
        }
        // ���������� �����̸�
        else if(inputX > 0)
        {
            // flipX�� ���ش�.
            sprite.flipX = false;
        }

        // ������ ������ �Է°��� Vector2 Ÿ���� inputVec�� �־��ְ�
        inputVec = new Vector2(inputX, inputY).normalized;

        // Rigidbody2D�� �̿��ؼ� �������ش�.
        rigid.linearVelocity = inputVec * stats.MoveSpeed;

        // �̵��ϰ� ������ �̵� �ִϸ��̼��� ���ش�.
        anim.SetFloat("StandRun", inputVec.magnitude);
    }
}
