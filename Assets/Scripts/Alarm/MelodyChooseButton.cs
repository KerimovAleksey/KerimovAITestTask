using TMPro;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public sealed class MelodyChooseButton : MonoBehaviour
{
    [SerializeField] private GameObject _choosenMark;
    [SerializeField] private TextMeshPro _songName;
	[SerializeField] private MelodyChooseController _soundController;

	private bool _selected;

	private void OnMouseDown()
	{
		if (!_selected)
			EnableMelody();
	}

	public void EnableMelody()
	{
		_selected = true;
		_choosenMark.SetActive(_selected);
		_soundController.ChangeSelectedSong(this);
	}

	public void DisableMelody()
	{
		_selected = false;
		_choosenMark.SetActive(_selected);
	}
}
