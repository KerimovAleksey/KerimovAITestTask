using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class UpDownTimeArrows : MonoBehaviour
{
	[SerializeField] private WakeUpTimeController _controller;
	[SerializeField] private bool _hoursUnit;
	[SerializeField] private int _valueSign;

	private void OnMouseDown()
	{
		if (_hoursUnit)
			_controller.ChangeHoursCount(_valueSign);
		else 
			_controller.ChangeMinutesCount(_valueSign);
	}
}
