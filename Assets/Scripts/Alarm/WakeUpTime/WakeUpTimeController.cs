using TMPro;
using UnityEngine;

public class WakeUpTimeController : MonoBehaviour
{
	[SerializeField] private TextMeshPro _hoursLabel;
	[SerializeField] private TextMeshPro _minutesLabel;
	[SerializeField] private TextMeshPro _currentTimeInfo;

	private int _hours = 0;
	private int _minutes = 0;

	public void ChangeHoursCount(int value)
	{
		_hours += value;
		if (_hours > 23)
			_hours = 0;
		if (_hours < 0)
			_hours = 23;
		_hoursLabel.text = _hours.ToString();
	}

	public void ChangeMinutesCount(int value)
	{
		_minutes += value;
		if (_minutes > 59)
			_minutes = 0;
		if (_minutes < 0)
			_minutes = 59;
		_minutesLabel.text = _minutes.ToString();
	}

	private void OnDisable()
	{
		_currentTimeInfo.text = _hours.ToString() + ":" + _minutes.ToString();
	}
}
