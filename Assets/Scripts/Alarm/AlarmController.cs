using UnityEngine;

public sealed class AlarmController : MonoBehaviour
{
    [SerializeField] private PanelController _startOpenedPanel;

	private PanelController _currentOpenedPanel;

	private void Start()
	{
		_startOpenedPanel.OpenPanel();
		_currentOpenedPanel = _startOpenedPanel;
	}

	public void ChangeCurrentPanel(PanelController newPanel)
	{
		_currentOpenedPanel.ClosePanel();
		_currentOpenedPanel = newPanel;
	}
}
