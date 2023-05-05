using System;
using Project._Scripts.Player;
using UnityEngine;
using UnityEngine.InputSystem;

[SelectionBase]
public class PlayerManager : MonoBehaviour
{

    public Inventory playerInventory;

    private PlayerInputs _playerInput;
    private PlayerMovement _playerMovement;
    private PlayerAnimator _playerAnimator;
    
    [Header("Test")]
    public ItemData test;
    public ItemData test2;
    public ItemData test3;
    


    private void Awake()
    {
        _playerInput = GetComponent<PlayerInputs>();
        _playerMovement = GetComponent<PlayerMovement>();
        playerInventory = GetComponent<Inventory>();
        _playerAnimator = GetComponent<PlayerAnimator>();
        
        
        DontDestroyOnLoad(this.gameObject);
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


    private void Update()
    {
        _playerAnimator.PlayAnimation(_playerInput.GetMoveDirection(), _playerInput.LastDirection);
    }

    private void FixedUpdate()
    {
        _playerMovement.Move(_playerInput.GetMoveDirection());
    }
}
