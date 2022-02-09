using UnityEngine;
using UnityEngine.UI;
using PretiaArCloud;

public class MapBasedRelocSceneController : MonoBehaviour
{

    [SerializeField]
    private ARSharedAnchorManager _relocManager;

    // Start is called before the first frame update
    void Start()
    {
        //isRunning = false;
        _relocManager.StartCloudMapRelocalization();
    }

    void OnEnable()
    {
        //_startButton.onClick.AddListener(OnStartClicked);
        _relocManager.OnSharedAnchorStateChanged += OnSharedAnchorStateChanged;
        _relocManager.OnRelocalized += OnRelocalized;
    }

    void OnDisable()
    {
        //_startButton.onClick.RemoveListener(OnStartClicked);
        _relocManager.OnSharedAnchorStateChanged -= OnSharedAnchorStateChanged;
        _relocManager.OnRelocalized -= OnRelocalized;
    }

    private void OnStartClicked()
    {
    }

    private void OnSharedAnchorStateChanged(SharedAnchorState state)
    {
    }

    private void OnRelocalized()
    {
        //_startButton.gameObject.SetActive(false);
    }
}
