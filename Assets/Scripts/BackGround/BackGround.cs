using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField]
    private PlayerMove player;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
        {
            return;
        }

        Vector3 playerPos = player.transform.position;
        Vector3 myPos = transform.position;

        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        Vector3 playerDir = player.inputVec;

        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;

        if(diffX > diffY)
        {
            transform.Translate(Vector3.right * dirX * 40);
        }
        else if(diffX < diffY)
        {
            transform.Translate(Vector3.up * dirY * 40);
        }

    }
}
