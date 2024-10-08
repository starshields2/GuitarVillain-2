//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""a6f7b792-cb29-4595-94ed-3dfb9b84951c"",
            ""actions"": [
                {
                    ""name"": ""Green"",
                    ""type"": ""Button"",
                    ""id"": ""cb1dbdbd-5f21-4df3-83bc-4a7d5c22161b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Red"",
                    ""type"": ""Button"",
                    ""id"": ""b1ff4e42-4054-4b4f-9c68-1bb894ce170c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""85c6c6e5-ebd1-4942-bfc7-a4556fdeead7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Blue"",
                    ""type"": ""Button"",
                    ""id"": ""23bbff31-b7cc-4596-a5eb-8e86abc1ce45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Orange"",
                    ""type"": ""Button"",
                    ""id"": ""904d9a17-4881-4282-886a-5374c8692061"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StrumUp"",
                    ""type"": ""Button"",
                    ""id"": ""5b562682-b764-48f0-be89-0c71736eaf4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StrumDown"",
                    ""type"": ""Button"",
                    ""id"": ""faf74824-1a9a-4d97-924f-f619790d6216"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""9b08c8db-82b0-4cf0-91a6-a39a17ea7ab6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Whammy"",
                    ""type"": ""Button"",
                    ""id"": ""c8d92366-7210-4c98-a3c1-f95cfe706dcc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""44a0fbd2-34bb-4bfd-9785-15c342c499d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Settings"",
                    ""type"": ""Value"",
                    ""id"": ""d159f44c-a559-43d1-8784-bdfb92c666d9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Settings2"",
                    ""type"": ""Button"",
                    ""id"": ""a753a51b-3f1e-4f51-bfba-0fc452fd2906"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""21c0e854-d0ae-4948-8543-e9356326f4c9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""995cf478-a6fc-4d3e-ab02-b58023d71727"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76869364-cb02-415f-9bc0-9e0e0e9ea698"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f73282d4-3f9c-4034-99f2-843bc55415ed"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""313a6561-1475-4852-8c81-8c9de2f0eb02"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85eb46cf-11f6-4384-b13b-88b0e67a22a7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrumUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97df1020-d7b1-4dad-9751-ab592eb9dadf"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrumDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edf24bea-91d3-41fc-92fa-8a5b506e9470"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f933df0-c9fa-4d04-ad4c-0a30fb8a91f8"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Whammy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b6c2231-4a47-4da0-8356-d65904e64182"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Whammy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f9a40c9-f3de-42f5-9ce8-cb8e4328554d"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""137e8bdc-ce70-48ef-b41c-4dc040e5440d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Settings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaeb2af2-8432-4162-bc54-5444b97522c7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Settings2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Green = m_GamePlay.FindAction("Green", throwIfNotFound: true);
        m_GamePlay_Red = m_GamePlay.FindAction("Red", throwIfNotFound: true);
        m_GamePlay_Yellow = m_GamePlay.FindAction("Yellow", throwIfNotFound: true);
        m_GamePlay_Blue = m_GamePlay.FindAction("Blue", throwIfNotFound: true);
        m_GamePlay_Orange = m_GamePlay.FindAction("Orange", throwIfNotFound: true);
        m_GamePlay_StrumUp = m_GamePlay.FindAction("StrumUp", throwIfNotFound: true);
        m_GamePlay_StrumDown = m_GamePlay.FindAction("StrumDown", throwIfNotFound: true);
        m_GamePlay_Start = m_GamePlay.FindAction("Start", throwIfNotFound: true);
        m_GamePlay_Whammy = m_GamePlay.FindAction("Whammy", throwIfNotFound: true);
        m_GamePlay_Select = m_GamePlay.FindAction("Select", throwIfNotFound: true);
        m_GamePlay_Settings = m_GamePlay.FindAction("Settings", throwIfNotFound: true);
        m_GamePlay_Settings2 = m_GamePlay.FindAction("Settings2", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private List<IGamePlayActions> m_GamePlayActionsCallbackInterfaces = new List<IGamePlayActions>();
    private readonly InputAction m_GamePlay_Green;
    private readonly InputAction m_GamePlay_Red;
    private readonly InputAction m_GamePlay_Yellow;
    private readonly InputAction m_GamePlay_Blue;
    private readonly InputAction m_GamePlay_Orange;
    private readonly InputAction m_GamePlay_StrumUp;
    private readonly InputAction m_GamePlay_StrumDown;
    private readonly InputAction m_GamePlay_Start;
    private readonly InputAction m_GamePlay_Whammy;
    private readonly InputAction m_GamePlay_Select;
    private readonly InputAction m_GamePlay_Settings;
    private readonly InputAction m_GamePlay_Settings2;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Green => m_Wrapper.m_GamePlay_Green;
        public InputAction @Red => m_Wrapper.m_GamePlay_Red;
        public InputAction @Yellow => m_Wrapper.m_GamePlay_Yellow;
        public InputAction @Blue => m_Wrapper.m_GamePlay_Blue;
        public InputAction @Orange => m_Wrapper.m_GamePlay_Orange;
        public InputAction @StrumUp => m_Wrapper.m_GamePlay_StrumUp;
        public InputAction @StrumDown => m_Wrapper.m_GamePlay_StrumDown;
        public InputAction @Start => m_Wrapper.m_GamePlay_Start;
        public InputAction @Whammy => m_Wrapper.m_GamePlay_Whammy;
        public InputAction @Select => m_Wrapper.m_GamePlay_Select;
        public InputAction @Settings => m_Wrapper.m_GamePlay_Settings;
        public InputAction @Settings2 => m_Wrapper.m_GamePlay_Settings2;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Add(instance);
            @Green.started += instance.OnGreen;
            @Green.performed += instance.OnGreen;
            @Green.canceled += instance.OnGreen;
            @Red.started += instance.OnRed;
            @Red.performed += instance.OnRed;
            @Red.canceled += instance.OnRed;
            @Yellow.started += instance.OnYellow;
            @Yellow.performed += instance.OnYellow;
            @Yellow.canceled += instance.OnYellow;
            @Blue.started += instance.OnBlue;
            @Blue.performed += instance.OnBlue;
            @Blue.canceled += instance.OnBlue;
            @Orange.started += instance.OnOrange;
            @Orange.performed += instance.OnOrange;
            @Orange.canceled += instance.OnOrange;
            @StrumUp.started += instance.OnStrumUp;
            @StrumUp.performed += instance.OnStrumUp;
            @StrumUp.canceled += instance.OnStrumUp;
            @StrumDown.started += instance.OnStrumDown;
            @StrumDown.performed += instance.OnStrumDown;
            @StrumDown.canceled += instance.OnStrumDown;
            @Start.started += instance.OnStart;
            @Start.performed += instance.OnStart;
            @Start.canceled += instance.OnStart;
            @Whammy.started += instance.OnWhammy;
            @Whammy.performed += instance.OnWhammy;
            @Whammy.canceled += instance.OnWhammy;
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @Settings.started += instance.OnSettings;
            @Settings.performed += instance.OnSettings;
            @Settings.canceled += instance.OnSettings;
            @Settings2.started += instance.OnSettings2;
            @Settings2.performed += instance.OnSettings2;
            @Settings2.canceled += instance.OnSettings2;
        }

        private void UnregisterCallbacks(IGamePlayActions instance)
        {
            @Green.started -= instance.OnGreen;
            @Green.performed -= instance.OnGreen;
            @Green.canceled -= instance.OnGreen;
            @Red.started -= instance.OnRed;
            @Red.performed -= instance.OnRed;
            @Red.canceled -= instance.OnRed;
            @Yellow.started -= instance.OnYellow;
            @Yellow.performed -= instance.OnYellow;
            @Yellow.canceled -= instance.OnYellow;
            @Blue.started -= instance.OnBlue;
            @Blue.performed -= instance.OnBlue;
            @Blue.canceled -= instance.OnBlue;
            @Orange.started -= instance.OnOrange;
            @Orange.performed -= instance.OnOrange;
            @Orange.canceled -= instance.OnOrange;
            @StrumUp.started -= instance.OnStrumUp;
            @StrumUp.performed -= instance.OnStrumUp;
            @StrumUp.canceled -= instance.OnStrumUp;
            @StrumDown.started -= instance.OnStrumDown;
            @StrumDown.performed -= instance.OnStrumDown;
            @StrumDown.canceled -= instance.OnStrumDown;
            @Start.started -= instance.OnStart;
            @Start.performed -= instance.OnStart;
            @Start.canceled -= instance.OnStart;
            @Whammy.started -= instance.OnWhammy;
            @Whammy.performed -= instance.OnWhammy;
            @Whammy.canceled -= instance.OnWhammy;
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @Settings.started -= instance.OnSettings;
            @Settings.performed -= instance.OnSettings;
            @Settings.canceled -= instance.OnSettings;
            @Settings2.started -= instance.OnSettings2;
            @Settings2.performed -= instance.OnSettings2;
            @Settings2.canceled -= instance.OnSettings2;
        }

        public void RemoveCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnGreen(InputAction.CallbackContext context);
        void OnRed(InputAction.CallbackContext context);
        void OnYellow(InputAction.CallbackContext context);
        void OnBlue(InputAction.CallbackContext context);
        void OnOrange(InputAction.CallbackContext context);
        void OnStrumUp(InputAction.CallbackContext context);
        void OnStrumDown(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnWhammy(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnSettings(InputAction.CallbackContext context);
        void OnSettings2(InputAction.CallbackContext context);
    }
}
