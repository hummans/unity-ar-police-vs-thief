// GENERATED AUTOMATICALLY FROM 'Assets/Data/ARControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ARControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ARControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ARControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1d48fff2-ed7c-4577-a50a-e0fad731462e"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""a25d265d-13a6-4baa-8896-a34054b30527"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""200817f4-3eb2-4e80-a419-a9cb5d29ac17"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Windows"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef8150e4-ed7d-48c4-bb79-aa4231c2ef79"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Smartphone"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Windows"",
            ""bindingGroup"": ""Windows"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Smartphone"",
            ""bindingGroup"": ""Smartphone"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Click = m_Player.FindAction("Click", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Click;
    public struct PlayerActions
    {
        private @ARControls m_Wrapper;
        public PlayerActions(@ARControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Player_Click;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_WindowsSchemeIndex = -1;
    public InputControlScheme WindowsScheme
    {
        get
        {
            if (m_WindowsSchemeIndex == -1) m_WindowsSchemeIndex = asset.FindControlSchemeIndex("Windows");
            return asset.controlSchemes[m_WindowsSchemeIndex];
        }
    }
    private int m_SmartphoneSchemeIndex = -1;
    public InputControlScheme SmartphoneScheme
    {
        get
        {
            if (m_SmartphoneSchemeIndex == -1) m_SmartphoneSchemeIndex = asset.FindControlSchemeIndex("Smartphone");
            return asset.controlSchemes[m_SmartphoneSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
