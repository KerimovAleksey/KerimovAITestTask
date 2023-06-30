using System.Collections.Generic;
using UnityEngine;

public class DaysController : MonoBehaviour
{
    private List<string> _chosenDays = new List<string>(); // ��� ����������� �������������, ������ ��� ����� � � ����� �������, ��������, ������

    public void AddNewItemToList(string day)
    {
        _chosenDays.Add(day);
    }

	public void RemoveItemFromList(string day)
	{
        _chosenDays.Remove(day);
	}
}
