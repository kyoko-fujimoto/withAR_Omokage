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
        _relocManager.StartCloudMapRelocalization();
    }

    void OnEnable()
    {
        _relocManager.OnSharedAnchorStateChanged += OnSharedAnchorStateChanged;
        _relocManager.OnRelocalized += OnRelocalized;
    }

    void OnDisable()
    {
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
        //MainSceneButtonManager.instance.StartTutorial();
    }
}