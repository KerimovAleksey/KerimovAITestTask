using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TaskItem : CheckBoxItem
{
	protected override void OnMouseDown()
	{
		// Если нужно сделать изменение текста задачи, или что то подобное
	}

	public void CompleteThisTask()
	{
		Checked = true;
		CheckMark.SetActive(Checked);
	}
}
