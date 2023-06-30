using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TaskItem : CheckBoxItem
{
	protected override void OnMouseDown()
	{
		// ���� ����� ������� ��������� ������ ������, ��� ��� �� ��������
	}

	public void CompleteThisTask()
	{
		Checked = true;
		CheckMark.SetActive(Checked);
	}
}
