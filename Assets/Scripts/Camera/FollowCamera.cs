using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    /// <summary>
    /// ī�޶� ���� �÷��̾� ������Ʈ
    /// </summary>
    [SerializeField]
    private GameObject player;

    private void LateUpdate()
    {
        Move();
    }

    private void Move()
    {
        // ī�޶��� ��ġ�� �÷��̾��� x, y��ǥ�� ����, z���� -10���� �����Ѵ�.
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
