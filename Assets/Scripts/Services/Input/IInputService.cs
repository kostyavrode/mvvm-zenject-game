using UnityEngine;

namespace Services.Input
{
    public interface IInputService
    {
        Vector2 GetMovementInput();
    }

    public class InputService : IInputService
    {
        public Vector2 GetMovementInput()
        {
#if UNITY_EDITOR || UNITY_STANDALONE
            return new Vector2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
#elif UNITY_IOS || UNITY_ANDROID
        // Реализация для экранного джойстика
        return VirtualJoystick.Instance.GetInput();
#endif
        }
    }

}