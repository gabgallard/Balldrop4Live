// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GeneralControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GeneralControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GeneralControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GeneralControls"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""1dd5f074-0c58-40d1-97fa-7454f54c9ca3"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""d288a5cd-5f54-461b-94ca-1966f98cf99a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dcf825ea-879f-4404-beea-e0a0fdaed576"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Erase"",
                    ""type"": ""Button"",
                    ""id"": ""abdd13bd-331f-4701-a294-5bf45be998e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3dfdb38-fd47-49d6-97f1-a15685b4a65e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e59f9258-3a85-4cf2-b768-886b381eee2f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1808d024-ee1d-43bf-a391-6bd8c1e0605c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e610114-cff7-4444-82f4-8c684282972c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Erase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53a0e5c5-2774-49fa-9d2a-b4ff860d86d2"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""503250d8-542b-40ec-b132-bc82182ef076"",
            ""actions"": [
                {
                    ""name"": ""DestroyBalls"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e2b664a3-31db-43fd-8319-0554b5454473"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Settings"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aa98ef95-b9a0-423a-90bb-b08082f8c26c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""39383a88-ceaf-463a-b410-097594b9feeb"",
                    ""path"": ""<Keyboard>/#(X)"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DestroyBalls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""035dfbc1-a4be-4813-adc4-70fd24c1064b"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Settings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Click = m_Mouse.FindAction("Click", throwIfNotFound: true);
        m_Mouse_Position = m_Mouse.FindAction("Position", throwIfNotFound: true);
        m_Mouse_Erase = m_Mouse.FindAction("Erase", throwIfNotFound: true);
        m_Mouse_Zoom = m_Mouse.FindAction("Zoom", throwIfNotFound: true);
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_DestroyBalls = m_Keyboard.FindAction("DestroyBalls", throwIfNotFound: true);
        m_Keyboard_Settings = m_Keyboard.FindAction("Settings", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Click;
    private readonly InputAction m_Mouse_Position;
    private readonly InputAction m_Mouse_Erase;
    private readonly InputAction m_Mouse_Zoom;
    public struct MouseActions
    {
        private @GeneralControls m_Wrapper;
        public MouseActions(@GeneralControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Mouse_Click;
        public InputAction @Position => m_Wrapper.m_Mouse_Position;
        public InputAction @Erase => m_Wrapper.m_Mouse_Erase;
        public InputAction @Zoom => m_Wrapper.m_Mouse_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Position.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnPosition;
                @Erase.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnErase;
                @Erase.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnErase;
                @Erase.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnErase;
                @Zoom.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Erase.started += instance.OnErase;
                @Erase.performed += instance.OnErase;
                @Erase.canceled += instance.OnErase;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_DestroyBalls;
    private readonly InputAction m_Keyboard_Settings;
    public struct KeyboardActions
    {
        private @GeneralControls m_Wrapper;
        public KeyboardActions(@GeneralControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @DestroyBalls => m_Wrapper.m_Keyboard_DestroyBalls;
        public InputAction @Settings => m_Wrapper.m_Keyboard_Settings;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @DestroyBalls.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDestroyBalls;
                @DestroyBalls.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDestroyBalls;
                @DestroyBalls.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDestroyBalls;
                @Settings.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSettings;
                @Settings.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSettings;
                @Settings.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSettings;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DestroyBalls.started += instance.OnDestroyBalls;
                @DestroyBalls.performed += instance.OnDestroyBalls;
                @DestroyBalls.canceled += instance.OnDestroyBalls;
                @Settings.started += instance.OnSettings;
                @Settings.performed += instance.OnSettings;
                @Settings.canceled += instance.OnSettings;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IMouseActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
        void OnErase(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnDestroyBalls(InputAction.CallbackContext context);
        void OnSettings(InputAction.CallbackContext context);
    }
}
