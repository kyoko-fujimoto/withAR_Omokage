using UnityEngine;
using UnityEngine.UI;
using PretiaArCloud;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{

    [SerializeField]
    private ARSharedAnchorManager _relocManager;

    [SerializeField]
    private TextMeshProUGUI _scoreLabel;

    void Start() {
        OnScoreUpdated(0);
    }

    void OnEnable() {
        _relocManager.OnScoreUpdated += OnScoreUpdated;
    }

    void OnDisable() {
        _relocManager.OnScoreUpdated -= OnScoreUpdated;
    }

    void OnScoreUpdated(float score)
    {
        _scoreLabel.text = Mathf.Floor(score * 100) + "%";
    }
}