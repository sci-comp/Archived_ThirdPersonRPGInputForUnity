using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    public LeftJoystick LeftJoy;
    public RightJoystick RightJoy;

    #region Action

    public bool Action1IsPressed { get; set;} = false;
    public bool Action1WasPressedThisFrame { get; set; } = false;
    public bool Action2IsPressed { get; set; } = false;
    public bool Action2WasPressedThisFrame { get; set; } = false;
    public bool Action3IsPressed { get; set; } = false;
    public bool Action3WasPressedThisFrame { get; set; } = false;
    public bool ButtonLeftStickIsPressed { get; set; } = false;
    public bool ButtonLeftStickWasPressedThisFrame { get; set; } = false;
    public bool ButtonRightStickIsPressed { get; set; } = false;
    public bool ButtonRightStickWasPressedThisFrame { get; set; } = false;
    public bool JumpIsPressed { get; set; } = false;
    public bool JumpWasPressedThisFrame { get; set; } = false;
    public bool LeftBumperIsPressed { get; set; } = false;
    public bool LeftBumperWasPressedThisFrame { get; set; } = false;

    #endregion

    #region Directional pad

    public bool DPadDownIsPressed { get; set; } = false;
    public bool DPadDownWasPressedThisFrame { get; set; } = false;
    public bool DPadLeftIsPressed { get; set; } = false;
    public bool DPadLeftWasPressedThisFrame { get; set; } = false;
    public bool DPadRightIsPressed { get; set; } = false;
    public bool DPadRightWasPressedThisFrame { get; set; } = false;
    public bool DPadUpIsPressed { get; set; } = false;
    public bool DPadUpWasPressedThisFrame { get; set; } = false;

    #endregion

    #region Menu

    public bool InventoryButtonIsPressed { get; set; } = false;
    public bool InventoryButtonWasPressedThisFrame { get; set; } = false;
    public bool MenuButtonIsPressed { get; set; } = false;
    public bool MenuButtonWasPressedThisFrame { get; set; } = false;

    #endregion

    #region Mouse

    public bool LeftClickIsPressed { get; set; } = false;
    public bool LeftClickWasPressedThisFrame { get; set; } = false;
    public bool RightClickIsPressed { get; set; } = false;
    public bool RightClickWasPressedThisFrame { get; set; } = false;

    #endregion

    #region Trigger

    public float LeftTriggerValue { get; set; } = 0.0f;
    public bool LeftTriggerIsPressed { get; set; } = false;
    public bool RightTriggerIsPressed { get; set; } = false;
    public float RightTriggerValue { get; set; } = 0.0f;

    #endregion

    #region Turn

    public bool TurnLeftIsPressed { get; set; } = false;
    public bool TurnLeftWasPressedThisFrame { get; set; } = false;
    public bool TurnRightIsPressed { get; set; } = false;
    public bool TurnRightWasPressedThisFrame { get; set; } = false;

    #endregion

    // ---- Monobehavior ----------------------------------------------------------------------

    private void Start()
    {
        LeftJoy = new LeftJoystick();
        RightJoy = new RightJoystick();
    }

    public void SetWasPressedThisFrameToFalse()
    {
        // Action
        Action1WasPressedThisFrame = false;
        Action2WasPressedThisFrame = false;
        Action3WasPressedThisFrame = false;
        ButtonLeftStickWasPressedThisFrame = false;
        ButtonRightStickWasPressedThisFrame = false;
        JumpWasPressedThisFrame = false;
        LeftBumperWasPressedThisFrame = false;

        // Directional pad
        DPadLeftWasPressedThisFrame = false;
        DPadRightWasPressedThisFrame = false;
        DPadUpWasPressedThisFrame = false;
        DPadDownWasPressedThisFrame = false;

        // Menu
        InventoryButtonWasPressedThisFrame = false;
        MenuButtonWasPressedThisFrame = false;

        // Mouse
        LeftClickWasPressedThisFrame = false;
        RightClickWasPressedThisFrame = false;

        // Left joystick 
        TurnLeftWasPressedThisFrame = false;
        TurnRightWasPressedThisFrame = false;
    }

    #region Action

    public void OnAction1(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                Action1IsPressed = true;
                Action1WasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                Action1IsPressed = false;
                break;
        }
    }

    public void OnAction2(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                Action2IsPressed = true;
                Action2WasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                Action2IsPressed = false;
                break;
        }
    }

    public void OnAction3(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                Action3IsPressed = true;
                Action3WasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                Action3IsPressed = false;
                break;
        }
    }

    public void OnButtonLeftStick(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                ButtonLeftStickIsPressed = true;
                ButtonLeftStickWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                ButtonLeftStickIsPressed = false;
                break;
        }
    }

    public void OnButtonRightStick(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                ButtonRightStickIsPressed = true;
                ButtonRightStickWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                ButtonRightStickIsPressed = false;
                break;
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                JumpIsPressed = true;
                JumpWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                JumpIsPressed = false;
                break;
        }
    }

    public void OnLeftBumper(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                LeftBumperIsPressed = true;
                LeftBumperWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                LeftBumperIsPressed = false;
                break;
        }
    }

    #endregion

    #region Directional pad

    public void OnDPadLeft(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                DPadLeftIsPressed = true;
                DPadLeftWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                DPadLeftIsPressed = false;
                break;
        }
    }

    public void OnDPadRight(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                DPadRightIsPressed = true;
                DPadRightWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                DPadRightIsPressed = false;
                break;
        }
    }

    public void OnDPadUp(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                DPadUpIsPressed = true;
                DPadUpWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                DPadUpIsPressed = false;
                break;
        }
    }

    public void OnDPadDown(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                DPadDownIsPressed = true;
                DPadDownWasPressedThisFrame = true;
                break;
            case InputActionPhase.Canceled:
                DPadDownIsPressed = false;
                break;
        }
    }

    #endregion

    #region Menu

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

    #endregion

    #region Mouse

    private void BothMouseClicksArePressed()
    {
        if (!LeftJoy.DoubleClickIsPressed)
        {
            LeftJoy.DoubleClickIsPressed = true;
            UpdateLeftJoy();
        }
    }

    private void MouseClickWasReleased()
    {
        if (LeftJoy.DoubleClickIsPressed)
        {
            LeftJoy.DoubleClickIsPressed = false;
            UpdateLeftJoy();
        }
    }

    public void OnLeftClick(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    LeftClickIsPressed = true;

                    if (RightClickIsPressed)
                    {
                        BothMouseClicksArePressed();
                    }

                    LeftClickWasPressedThisFrame = true;
                }
                
                break;

            case InputActionPhase.Canceled:
                {
                    LeftClickIsPressed = false;
                    MouseClickWasReleased();
                }

                break;
        }
    }

    public void OnRightClick(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    RightClickIsPressed = true;

                    if (LeftClickIsPressed)
                    {
                        BothMouseClicksArePressed();
                    }

                    RightClickWasPressedThisFrame = true;
                }
        
                break;

            case InputActionPhase.Canceled:
                {
                    RightClickIsPressed = false;
                    MouseClickWasReleased();
                }
                
                break;
        }
    }

    #endregion

    #region Trigger

    public void OnLeftTrigger(InputAction.CallbackContext context)
    {
        LeftTriggerValue = context.ReadValue<float>();

        if (LeftTriggerValue > 0.1f)
        {
            LeftTriggerIsPressed = true;
        }
        else
        {
            LeftTriggerIsPressed = false;
        }
    }

    public void OnRightTrigger(InputAction.CallbackContext context)
    {
        RightTriggerValue = context.ReadValue<float>();

        if (RightTriggerValue > 0.1f)
        {
            RightTriggerIsPressed = true;
        }
        else
        {
            RightTriggerIsPressed = false;
        }
    }

    #endregion

    #region Turn

    public void OnTurnLeft(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                TurnLeftIsPressed = true;
                TurnLeftWasPressedThisFrame = true;
                UpdateLeftJoy();
                break;
            case InputActionPhase.Canceled:
                TurnLeftIsPressed = false;
                UpdateLeftJoy();
                break;
        }
    }

    public void OnTurnRight(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                TurnRightIsPressed = true;
                TurnRightWasPressedThisFrame = true;
                UpdateLeftJoy();
                break;
            case InputActionPhase.Canceled:
                TurnRightIsPressed = false;
                UpdateLeftJoy();
                break;
        }
    }

    #endregion

    public void OnRightStick(InputAction.CallbackContext context)
    {
        Vector2 _direction = context.ReadValue<Vector2>();

        RightJoy.InputX = _direction[0];
        RightJoy.InputZ = -1f * _direction[1];
    }

    private void UpdateLeftJoy()
    {
        if ((Mathf.Approximately(LeftJoy.InputX, 0.0f) && Mathf.Approximately(LeftJoy.InputZ, 0.0f))
            && !LeftJoy.DoubleClickIsPressed && !TurnLeftIsPressed && !TurnRightIsPressed)
        {
            LeftJoy.IsTilted = false;
            LeftJoy.Direction = new Vector3(0, 0, 0);
            LeftJoy.Throttle = 0.0f;
        }
        else
        {
            LeftJoy.IsTilted = true;

            if (InputHub.Instance.CurrentControlScheme == ControlSchemes.Keyboard)
            {
                if (LeftJoy.DoubleClickIsPressed)
                {
                    Vector3 _direction = Vector3.zero;
                    _direction.y = 0;

                    if (InputHub.Instance.Player.LeftJoy.IsTilted && (InputHub.Instance.Player.LeftJoy.InputZ < 0))
                    {
                        // Backpedal override
                        _direction.z = -1;
                    }
                    else
                    {
                        _direction.z = 1;
                    }

                    _direction.x = CheckForSideInput();
                    LeftJoy.Direction = _direction.normalized;
                }
                else if (RightClickIsPressed)
                {
                    Vector3 _direction = Vector3.zero;
                    _direction.x = CheckForSideInput();
                    _direction.y = 0;
                    _direction.z = LeftJoy.InputZ;

                    LeftJoy.Direction = _direction.normalized;
                }
                else
                {
                    Vector3 _direction = Vector3.zero;
                    _direction.x = LeftJoy.InputX;
                    _direction.y = 0;
                    _direction.z = LeftJoy.InputZ;
                    LeftJoy.Direction = _direction.normalized;
                }

                LeftJoy.Throttle = Mathf.Sqrt(Mathf.Pow(LeftJoy.Direction.x, 2) + Mathf.Pow(LeftJoy.Direction.z, 2));
            }
            else
            {
                // We do not update InputX or InputZ here for gamepad use.
            }
        }
    }

    private float CheckForSideInput()
    {
        if (InputHub.Instance.Player.TurnLeftIsPressed
            || InputHub.Instance.Player.LeftJoy.InputX < 0)
        {
            return -1.0f;
        }
        else if (InputHub.Instance.Player.TurnRightIsPressed
            || InputHub.Instance.Player.LeftJoy.InputX > 0)
        {
            return 1.0f;
        }
        else
        {
            return 0.0f;
        }
    }


    public void OnLeftStick(InputAction.CallbackContext context)
    {
        Vector2 _direction = context.ReadValue<Vector2>();

        LeftJoy.InputX = _direction[0];
        LeftJoy.InputZ = _direction[1];

        UpdateLeftJoy();
    }


    // ----
}


// ----

