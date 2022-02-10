using UnityEngine;
using UnityEngine.UI;
using PretiaArCloud;
using TMPro;

public class StatusUpdater : MonoBehaviour
{

    [SerializeField]
    private ARSharedAnchorManager _relocManager;

    [SerializeField]
    private TextMeshProUGUI _statusLabel;

    void Start()
    {
        _statusLabel.text = "Stopped";
    }

    void OnEnable()
    {
        _relocManager.OnSharedAnchorStateChanged += OnSharedAnchorStateChanged;
    }

    void OnDisable()
    {
        _relocManager.OnSharedAnchorStateChanged -= OnSharedAnchorStateChanged;
    }

    private void OnSharedAnchorStateChanged(SharedAnchorState state)
    {
        switch (state)
        {
            case SharedAnchorState.Stopped:
                _statusLabel.text = "Stopped";
                break;

            case SharedAnchorState.Initializing:
            case SharedAnchorState.Relocalizing:
                _statusLabel.text = "SCANNING...";
                break;

            case SharedAnchorState.Relocalized:
                _statusLabel.text = "OK";
                break;
        }
    }
}