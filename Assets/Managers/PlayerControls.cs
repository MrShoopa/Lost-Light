// GENERATED AUTOMATICALLY FROM 'Assets/Managers/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Side"",
            ""id"": ""f56f228f-928c-4bec-a3ff-af3e8904f6f9"",
            ""actions"": [
                {
                    ""name"": ""Toggle"",
                    ""type"": ""Button"",
                    ""id"": ""3ea76444-0b1a-4d3c-b381-ed27961350dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7ce9cbbb-5832-4a4e-817e-ab7aa70d2a1c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""02a4e3e6-e044-4423-a552-8e0b648a903d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c32efdaf-4829-4912-b4f5-70858354bc8c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a3c33f0-89d8-4ffe-8cbb-58f161e516a4"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a84685d3-c59a-48c3-9157-ecaf0debfa5c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""3fa3a000-2fc8-444d-903b-8ffe98b731c0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fc49b2a5-9bcb-4938-bbf0-8c70aa58683c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""04f7ee35-f812-40a6-8304-b0c836df3151"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a0b33e92-296f-41da-9893-cb8a5c883a25"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""704eafb6-44e3-4ff7-8510-fd50a2a7c0ff"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""41bd77c4-68cb-4578-8c0a-59f10f5de7ea"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c13d62de-f5e7-4a40-96da-bb363933cefc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Side
        m_Side = asset.FindActionMap("Side", throwIfNotFound: true);
        m_Side_Toggle = m_Side.FindAction("Toggle", throwIfNotFound: true);
        m_Side_Move = m_Side.FindAction("Move", throwIfNotFound: true);
        m_Side_Jump = m_Side.FindAction("Jump", throwIfNotFound: true);
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

    // Side
    private readonly InputActionMap m_Side;
    private ISideActions m_SideActionsCallbackInterface;
    private readonly InputAction m_Side_Toggle;
    private readonly InputAction m_Side_Move;
    private readonly InputAction m_Side_Jump;
    public struct SideActions
    {
        private @PlayerControls m_Wrapper;
        public SideActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Toggle => m_Wrapper.m_Side_Toggle;
        public InputAction @Move => m_Wrapper.m_Side_Move;
        public InputAction @Jump => m_Wrapper.m_Side_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Side; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SideActions set) { return set.Get(); }
        public void SetCallbacks(ISideActions instance)
        {
            if (m_Wrapper.m_SideActionsCallbackInterface != null)
            {
                @Toggle.started -= m_Wrapper.m_SideActionsCallbackInterface.OnToggle;
                @Toggle.performed -= m_Wrapper.m_SideActionsCallbackInterface.OnToggle;
                @Toggle.canceled -= m_Wrapper.m_SideActionsCallbackInterface.OnToggle;
                @Move.started -= m_Wrapper.m_SideActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_SideActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_SideActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_SideActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_SideActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_SideActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_SideActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Toggle.started += instance.OnToggle;
                @Toggle.performed += instance.OnToggle;
                @Toggle.canceled += instance.OnToggle;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public SideActions @Side => new SideActions(this);
    public interface ISideActions
    {
        void OnToggle(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
