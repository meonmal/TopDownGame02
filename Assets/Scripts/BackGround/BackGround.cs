using UnityEngine;

public class BackGround : MonoBehaviour
{
    // �÷��̾��� inputVec�� �������� ���� ����
    [SerializeField]
    private PlayerMove player;

    private void OnTriggerExit2D(Collider2D collision)
    {
        // �浹���� ���������� ������Ʈ�� �±װ� Area�� �ƴϸ� ���� ���
        if (!collision.CompareTag("Area"))
        {
            return;
        }

        // �÷��̾�� ����� ��ġ ������ �����´�.
        Vector3 playerPos = player.transform.position;
        Vector3 myPos = transform.position;

        // �÷��̾�� ����� �Ÿ� ������ ���Ѵ�.
        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        // �÷��̾ �Է��� �̵� ���� (Vector2 �� Vector3 ĳ����)
        Vector3 playerDir = player.inputVec;

        // �Է� ���⿡ ���� �̵��� ���� ��ȣ ���� (����/�Ʒ�: -1, ������/��: +1)
        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;

        // ���� ���̰� �� ũ�� X�� �������� ��� �̵�
        if (diffX > diffY)
        {
            // ����� X�� �������� 40��ŭ �̵�
            // (20 * (3-1) = 40 �� 3x3 Ÿ�� �� �� �� �Ѿ��)
            transform.Translate(Vector3.right * dirX * 40);
        }
        // ���� ���̰� �� ũ�� Y�� �������� ��� �̵�
        else if (diffX < diffY)
        {
            transform.Translate(Vector3.up * dirY * 40);
        }

        // diffX == diffY�� �� �ƹ� �͵� �� ��
    }
}
