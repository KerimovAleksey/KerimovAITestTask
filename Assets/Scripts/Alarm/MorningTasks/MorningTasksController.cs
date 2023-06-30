using UnityEngine;

public class MorningTasksController : MonoBehaviour
{
    [SerializeField] private TaskItem[] _tasks;
    [SerializeField] private ButtonListener _buttonListener;

    private int _currentTaskIndex = 0;

	private void OnEnable()
	{
        _buttonListener.OnButtonClick += CompleteTask;
	}

	private void OnDisable()
	{
		_buttonListener.OnButtonClick -= CompleteTask;
	}

	public void CompleteTask()
    {
        if (_currentTaskIndex < _tasks.Length)
        {
            _tasks[_currentTaskIndex].CompleteThisTask();
            _currentTaskIndex++;
        }
    }
}
