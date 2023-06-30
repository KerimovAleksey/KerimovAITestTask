using UnityEngine;

public class MelodyChooseController : MonoBehaviour
{
    [SerializeField] private MelodyChooseButton _startMelody;
    private MelodyChooseButton _selectedSong;

	private void Start()
	{
        _startMelody.EnableMelody();
	}

	public void ChangeSelectedSong(MelodyChooseButton newSong)
    {
        if (_selectedSong)
        {
            _selectedSong.DisableMelody();
        }
        _selectedSong = newSong;
    }
}
