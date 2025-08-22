using UnityEngine;

public class BackGround : MonoBehaviour
{
    // 플레이어의 inputVec을 가져오기 위한 변수
    [SerializeField]
    private PlayerMove player;

    private void OnTriggerExit2D(Collider2D collision)
    {
        // 충돌에서 빠져나가는 오브젝트의 태그가 Area가 아니면 실행 취소
        if (!collision.CompareTag("Area"))
        {
            return;
        }

        // 플레이어와 배경의 위치 정보를 가져온다.
        Vector3 playerPos = player.transform.position;
        Vector3 myPos = transform.position;

        // 플레이어와 배경의 거리 차리를 구한다.
        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        // 플레이어가 입력한 이동 방향 (Vector2 → Vector3 캐스팅)
        Vector3 playerDir = player.inputVec;

        // 입력 방향에 따라 이동할 축의 부호 결정 (왼쪽/아래: -1, 오른쪽/위: +1)
        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;

        // 가로 차이가 더 크면 X축 방향으로 배경 이동
        if (diffX > diffY)
        {
            // 배경을 X축 방향으로 40만큼 이동
            // (20 * (3-1) = 40 → 3x3 타일 중 한 줄 넘어가기)
            transform.Translate(Vector3.right * dirX * 40);
        }
        // 세로 차이가 더 크면 Y축 방향으로 배경 이동
        else if (diffX < diffY)
        {
            transform.Translate(Vector3.up * dirY * 40);
        }

        // diffX == diffY일 땐 아무 것도 안 함
    }
}
