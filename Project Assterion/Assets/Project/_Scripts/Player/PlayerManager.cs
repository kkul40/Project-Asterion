using UnityEngine;

[SelectionBase]
public class PlayerManager : MonoBehaviour
{
    public Inventory playerInventory;

    [Header("Test")] public ItemData test;

    public ItemData test2;
    public ItemData test3;

    private PlayerMovement _playerMovement;
    private Input input;


    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        playerInventory = GetComponent<Inventory>();


        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        input = new Input();
        input.Enable();
    }


    private void FixedUpdate()
    {
        _playerMovement.Move(input.Player.Movement.ReadValue<Vector2>());
    }

    [ContextMenu("Addto Inventoyr")]
    public void AddToInvenotryTest()
    {
        playerInventory.AddItem(test);
        playerInventory.AddItem(test);
        playerInventory.AddItem(test);
        playerInventory.AddItem(test2);
        playerInventory.AddItem(test2);
        playerInventory.AddItem(test3);
    }

    [ContextMenu("Remove Inventoyr")]
    public void RemoveToInvenotryTest()
    {
        playerInventory.RemoveItem(test);
    }
}