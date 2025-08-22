using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    /// <summary>
    /// 플레이어 이동속도
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    /// <summary>
    /// 플레이어 이동속도
    /// </summary>
    public float MoveSpeed
    {
        get => moveSpeed;
        set => moveSpeed = value;
    }
}
