using UnityEngine;

[SelectionBase]
public class PlayerManager : MonoBehaviour
{
    private Inputs input;

    public Inventory playerInventory;
    
    private PlayerMovement _playerMovement;
    
    [Header("Test")]
    public ItemData test;
    public ItemData test2;
    public ItemData test3;
    


    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        playerInventory = GetComponent<Inventory>();
        
        
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        input = new Inputs();
        input.Enable();

        

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


    private void FixedUpdate()
    {
        _playerMovement.Move(input.Player.Movement.ReadValue<Vector2>());
    }
}
