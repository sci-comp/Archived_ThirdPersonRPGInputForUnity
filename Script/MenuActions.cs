using UnityEngine;
using UnityEngine.InputSystem;


public class MenuActions : MonoBehaviour
{
    //
    public bool BackIsPressed { get; set; }
    public bool BackWasPressedThisFrame { get; set; }

    //
    public bool InventoryButtonIsPressed { get; set; }
    public bool InventoryButtonWasPressedThisFrame { get; set; }
    public bool InventoryDropIsPressed { get; set; }
    public bool InventoryDropWasPressedThisFrame { get; set; }
    public bool InventoryMoveIsPressed { get; set; }
    public bool InventoryMoveWasPressedThisFrame { get; set; }
    public bool InventoryUnequipIsPressed { get; set; }
    public bool InventoryUnequipWasPressedThisFrame { get; set; }

    //
    public bool LeftClickIsPressed { get; set; }
    public bool LeftClickWasPressedThisFrame { get; set; }

    //
    public bool MenuButtonIsPressed { get; set; }
    public bool MenuButtonWasPressedThisFrame { get; set; }
    public bool MenuSubmitIsPressed { get; set; }
    public bool MenuSubmitWasPressedThisFrame { get; set; }

    //
    public bool NavigateDownIsPressed { get; set; }
    public bool NavigateDownWasPressedThisFrame { get; set; }
    public bool NavigateLeftIsPressed { get; set; }
    public bool NavigateLeftWasPressedThisFrame { get; set; }
    public bool NavigateRightIsPressed { get; set; }
    public bool NavigateRightWasPressedThisFrame { get; set; }
    public bool NavigateUpIsPressed { get; set; }
    public bool NavigateUpWasPressedThisFrame { get; set; }

    //
    public bool NextMenuIsPressed { get; set; }
    public bool NextMenuWasPressedThisFrame { get; set; }
    public bool PreviousMenuIsPressed { get; set; }
    public bool PreviousMenuWasPressedThisFrame { get; set; }

    //
    public bool RightClickIsPressed { get; set; }
    public bool RightClickWasPressedThisFrame { get; set; }


    public void OnLeftClick(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                LeftClickIsPressed = true;
                LeftClickWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                LeftClickIsPressed = false;
                break;
        }
    }

    public void OnRightClick(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                RightClickIsPressed = true;
                RightClickWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                RightClickIsPressed = false;
                break;
        }
    }

    public void OnMenuButton(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                MenuButtonIsPressed = true;
                MenuButtonWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                MenuButtonIsPressed = false;
                break;
        }
    }

    public void OnMenuSubmit(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                MenuSubmitIsPressed = true;
                MenuSubmitWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                MenuSubmitIsPressed = false;
                break;
        }
    }

    public void OnBack(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                BackIsPressed = true;
                BackWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                BackIsPressed = false;
                break;
        }
    }

    public void OnInventoryButton(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                InventoryButtonIsPressed = true;
                InventoryButtonWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                InventoryButtonIsPressed = false;
                break;
        }
    }

    public void OnNavigateLeft(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                NavigateLeftIsPressed = true;
                NavigateLeftWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                NavigateLeftIsPressed = false;
                break;
        }
    }

    public void OnNavigateRight(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                NavigateRightIsPressed = true;
                NavigateRightWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                NavigateRightIsPressed = false;
                break;
        }
    }

    public void OnNavigateUp(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                NavigateUpIsPressed = true;
                NavigateUpWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                NavigateUpIsPressed = false;
                break;
        }
    }

    public void OnNavigateDown(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                NavigateDownIsPressed = true;
                NavigateDownWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                NavigateDownIsPressed = false;
                break;
        }
    }


    public void OnInventoryDrop(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                InventoryDropIsPressed = true;
                InventoryDropWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                InventoryDropIsPressed = false;
                break;
        }
    }

    public void OnInventoryMove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                InventoryMoveIsPressed = true;
                InventoryMoveWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                InventoryMoveIsPressed = false;
                break;
        }
    }

    public void OnInventoryUnequip(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                InventoryUnequipIsPressed = true;
                InventoryUnequipWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                InventoryUnequipIsPressed = false;
                break;
        }
    }

    public void OnNextMenu(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                NextMenuIsPressed = true;
                NextMenuWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                NextMenuIsPressed = false;
                break;
        }
    }

    public void OnPreviousMenu(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                PreviousMenuIsPressed = true;
                PreviousMenuWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                PreviousMenuIsPressed = false;
                break;
        }
    }


    //

    public void SetWasPressedThisFrameToFalse()
    {
        BackWasPressedThisFrame = false;

        InventoryButtonWasPressedThisFrame = false;
        InventoryDropWasPressedThisFrame = false;
        InventoryMoveWasPressedThisFrame = false;
        InventoryUnequipWasPressedThisFrame = false;

        MenuButtonWasPressedThisFrame = false;
        MenuSubmitWasPressedThisFrame = false;

        NextMenuWasPressedThisFrame = false;
        PreviousMenuWasPressedThisFrame = false;

        LeftClickWasPressedThisFrame = false;
        RightClickWasPressedThisFrame = false;
    }

    // ----
}


// ----

