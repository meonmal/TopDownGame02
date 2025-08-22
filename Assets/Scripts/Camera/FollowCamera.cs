using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    /// <summary>
    /// 카메라가 따라갈 플레이어 오브젝트
    /// </summary>
    [SerializeField]
    private GameObject player;

    private void LateUpdate()
    {
        Move();
    }

    private void Move()
    {
        // 카메라의 위치를 플레이어의 x, y좌표로 고정, z축은 -10으로 설정한다.
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
