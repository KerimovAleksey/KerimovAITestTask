using UnityEngine;

public class DayItem : CheckBoxItem
{
	[SerializeField] private DaysController _controller;

	protected override void OnMouseDown()
	{
		Checked = !Checked;
		CheckMark.SetActive(!CheckMark.activeSelf);
		if (Checked)
			_controller.AddNewItemToList(gameObject.name);
		else
			_controller.RemoveItemFromList(gameObject.name);
	}
}
