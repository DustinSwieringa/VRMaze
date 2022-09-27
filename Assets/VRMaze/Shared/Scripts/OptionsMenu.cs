using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class OptionsMenu : MonoBehaviour
{
    public UnityEvent<bool> EnableSnapTurn;
    public UnityEvent<bool> EnableContinuousTurn;

    [SerializeField]
    private InputActionProperty _openOptionsMenuButton;

    [SerializeField]
    private Canvas _optionsMenu;

    [SerializeField]
    private Button _quitButton, _continueButton;

    [SerializeField]
    private Toggle _snapTurnToggle;

    [SerializeField]
    private Transform _canvasSpawnLocation;

    [SerializeField]
    private float _distanceToCloseMenu;

    [SerializeField]
    private Slider _volumeSlider;

    private void Awake()
    {
        _openOptionsMenuButton.action.performed += x => ToggleOptionsMenu();
        _volumeSlider.onValueChanged.AddListener(x => AudioListener.volume = x);
        AudioListener.volume = _volumeSlider.value;
        _snapTurnToggle.onValueChanged.AddListener(SnapTurn);
        SnapTurn(_snapTurnToggle.isOn);

        _quitButton.onClick.AddListener(() => Application.Quit());
        _continueButton.onClick.AddListener(ToggleOptionsMenu);
        CloseOptionsMenu();
    }

    private void CloseOptionsMenu() => _optionsMenu.enabled = false;

    private void Update()
    {
        if (!_optionsMenu.enabled)
            return;

        transform.LookAt(_canvasSpawnLocation.parent);

        if (Vector3.Distance(_canvasSpawnLocation.parent.position, transform.position) > _distanceToCloseMenu)
            CloseOptionsMenu();
    }

    private void ToggleOptionsMenu()
    {
        bool closeMenu = _optionsMenu.enabled;
        _optionsMenu.enabled = !closeMenu;

        if (closeMenu)
            return;

        Vector3 canvasPosition = _canvasSpawnLocation.position;
        canvasPosition.y = _canvasSpawnLocation.parent.position.y;
        transform.position = canvasPosition;
    }

    private void SnapTurn(bool isEnabled)
    {
        EnableSnapTurn?.Invoke(isEnabled);
        EnableContinuousTurn?.Invoke(!isEnabled);
    }
}
