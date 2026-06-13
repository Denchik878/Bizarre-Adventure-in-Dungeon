using UnityEngine;
public class Player : MonoBehaviour
{
    public PlayerInput input;
    public static Player Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        input = new PlayerInput();
        input.Enable();
    }
}
