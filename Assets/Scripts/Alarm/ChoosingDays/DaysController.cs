using System.Collections.Generic;
using UnityEngine;

public class DaysController : MonoBehaviour
{
    private List<string> _chosenDays = new List<string>(); // Для дальнейшего использования, смотря что нужно и в каком формате, допустим, список

    public void AddNewItemToList(string day)
    {
        _chosenDays.Add(day);
    }

	public void RemoveItemFromList(string day)
	{
        _chosenDays.Remove(day);
	}
}
