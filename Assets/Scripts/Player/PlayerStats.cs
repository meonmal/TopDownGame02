using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    /// <summary>
    /// �÷��̾� �̵��ӵ�
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    /// <summary>
    /// �÷��̾� �̵��ӵ�
    /// </summary>
    public float MoveSpeed
    {
        get => moveSpeed;
        set => moveSpeed = value;
    }
}
