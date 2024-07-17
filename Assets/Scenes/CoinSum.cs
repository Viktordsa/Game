using UnityEngine;
using UnityEngine.UI;

public class DisplayValue : MonoBehaviour
{
    // Публичная переменная для хранения значения
    public string valueToDisplay;

    // Компонент Text
    public Text textComponent;

    void Start()
    {
        // Присваиваем значение переменной Text
        textComponent.text = valueToDisplay;
    }
}
