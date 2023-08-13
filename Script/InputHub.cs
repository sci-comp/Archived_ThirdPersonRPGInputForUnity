using UnityEngine;
using UnityEngine.InputSystem.UI;
using Toolbox;
using UnityEngine.InputSystem;

public enum ControlSchemes
{
    Keyboard,
    Gamepad
}

public class LeftJoystick
{
    public bool DoubleClickIsPressed { get; set; } = false;
    public bool IsTilted { get; set; } = false;
    public float InputX { get; set; } = 0.0f;
    public float InputZ { get; set; } = 0.0f;
    public float Throttle { get; set; } = 0.0f;
    public Vector3 Direction { get; set; } = Vector3.zero;
}

public class RightJoystick
{
    public bool IsTilted { get; set; } = false;
    public float InputX { get; set; } = 0.0f;
    public float InputZ { get; set; } = 0.0f;
    public float Throttle { get; set; } = 0.0f;
}

public class InputHub : Singleton<InputHub>
{
    public InputActions_ThirdPersonRPG inputActions;

    [SerializeField] InputSystemUIInputModule uiInputModule;
    [SerializeField] MenuActions menuActions;
    [SerializeField] PlayerActions playerActions;
    [SerializeField] PlayerInput playerInput;

    private ControlSchemes currentControlScheme = ControlSchemes.Keyboard;

    // ---- Monobehaviors ---------------------------------------------------------------------

    private void Start()
    {
        inputActions = new InputActions_ThirdPersonRPG();
        inputActions.Enable();
        PixelCrushers.InputDeviceManager.RegisterInputAction("Interact", inputActions.Player.Action2);
    }

    private void LateUpdate()
    {
        menuActions.SetWasPressedThisFrameToFalse();
        playerActions.SetWasPressedThisFrameToFalse();
    }

    // ---- Getters ---------------------------------------------------------------------------

    public MenuActions Menu { get { return menuActions; } }

    public PlayerActions Player { get {  return playerActions; } }

    public InputSystemUIInputModule UIInputModule { get {  return uiInputModule; } }

    public ControlSchemes CurrentControlScheme { get { return currentControlScheme; } }

    public void OnControlSchemeChanged()
    {
        if (playerInput.currentControlScheme == "KeyboardMouse")
        {
            currentControlScheme = ControlSchemes.Keyboard;
        }
        else
        {
            currentControlScheme = ControlSchemes.Gamepad;
        }
    }

    // ----
}


// ----

