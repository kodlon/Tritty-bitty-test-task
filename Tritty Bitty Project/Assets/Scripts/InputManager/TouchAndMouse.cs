// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputManager/TouchAndMouse.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputManager
{
    public class @TouchAndMouse : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TouchAndMouse()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchAndMouse"",
    ""maps"": [
        {
            ""name"": ""Player Input"",
            ""id"": ""c15cee47-6d84-4f25-b35b-fdf3d2f15008"",
            ""actions"": [
                {
                    ""name"": ""InputTouchedOrClicked"",
                    ""type"": ""Button"",
                    ""id"": ""2840a57f-0f09-44ac-8aea-9beed7a5ac50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PostionTouchOrClicked"",
                    ""type"": ""Value"",
                    ""id"": ""a0be7a24-d1f0-4160-83c6-6a11654e13fc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fcb03d3e-8867-4675-b4c0-7d55b135e0f3"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputTouchedOrClicked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1473a3b-968b-422e-88b7-1acdc1d25b7d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputTouchedOrClicked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fc76506-e837-4ebc-8f61-0215849ec0da"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PostionTouchOrClicked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2765c7a8-c2e3-4a62-bce7-6e044bfe0f44"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PostionTouchOrClicked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player Input
            m_PlayerInput = asset.FindActionMap("Player Input", throwIfNotFound: true);
            m_PlayerInput_InputTouchedOrClicked = m_PlayerInput.FindAction("InputTouchedOrClicked", throwIfNotFound: true);
            m_PlayerInput_PostionTouchOrClicked = m_PlayerInput.FindAction("PostionTouchOrClicked", throwIfNotFound: true);
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

        // Player Input
        private readonly InputActionMap m_PlayerInput;
        private IPlayerInputActions m_PlayerInputActionsCallbackInterface;
        private readonly InputAction m_PlayerInput_InputTouchedOrClicked;
        private readonly InputAction m_PlayerInput_PostionTouchOrClicked;
        public struct PlayerInputActions
        {
            private @TouchAndMouse m_Wrapper;
            public PlayerInputActions(@TouchAndMouse wrapper) { m_Wrapper = wrapper; }
            public InputAction @InputTouchedOrClicked => m_Wrapper.m_PlayerInput_InputTouchedOrClicked;
            public InputAction @PostionTouchOrClicked => m_Wrapper.m_PlayerInput_PostionTouchOrClicked;
            public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerInputActions instance)
            {
                if (m_Wrapper.m_PlayerInputActionsCallbackInterface != null)
                {
                    @InputTouchedOrClicked.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnInputTouchedOrClicked;
                    @InputTouchedOrClicked.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnInputTouchedOrClicked;
                    @InputTouchedOrClicked.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnInputTouchedOrClicked;
                    @PostionTouchOrClicked.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPostionTouchOrClicked;
                    @PostionTouchOrClicked.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPostionTouchOrClicked;
                    @PostionTouchOrClicked.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPostionTouchOrClicked;
                }
                m_Wrapper.m_PlayerInputActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @InputTouchedOrClicked.started += instance.OnInputTouchedOrClicked;
                    @InputTouchedOrClicked.performed += instance.OnInputTouchedOrClicked;
                    @InputTouchedOrClicked.canceled += instance.OnInputTouchedOrClicked;
                    @PostionTouchOrClicked.started += instance.OnPostionTouchOrClicked;
                    @PostionTouchOrClicked.performed += instance.OnPostionTouchOrClicked;
                    @PostionTouchOrClicked.canceled += instance.OnPostionTouchOrClicked;
                }
            }
        }
        public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
        public interface IPlayerInputActions
        {
            void OnInputTouchedOrClicked(InputAction.CallbackContext context);
            void OnPostionTouchOrClicked(InputAction.CallbackContext context);
        }
    }
}
