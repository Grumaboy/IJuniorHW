using UnityEngine;
using TMPro;
using System.Collections;

public class Counter : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterText;
    [SerializeField] private float _period;

    private bool _isMouseDown = false;
    private int _score = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isMouseDown == false)
        {
            _isMouseDown = true;
            StartCoroutine(StartCounter(_period));
        }
        else if (Input.GetMouseButtonDown(0) && _isMouseDown == true)
        {
            _isMouseDown = false;
        }
    }

    private IEnumerator StartCounter(float period)
    {
        while (_isMouseDown == true) 
        {
            _score++;
            _counterText.text = _score.ToString();
            yield return new WaitForSeconds(period);
        }
    }
}
