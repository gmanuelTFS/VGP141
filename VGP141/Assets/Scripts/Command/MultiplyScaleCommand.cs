using UnityEngine;
using UnityEngine.UI;

public class MultiplyScaleCommand : ICommand
{
    private Image _image;
    private Vector3 _originalScale;
    private float _scaleMultiplier;

    public MultiplyScaleCommand(Image pImage, float pScaleMultiplier)
    {
        _image = pImage;
        _scaleMultiplier = pScaleMultiplier;
    }

    public void Execute()
    {
        _originalScale = _image.transform.localScale;
        _image.transform.localScale *= _scaleMultiplier;
    }

    public void Undo()
    {
        _image.transform.localScale = _originalScale;
    }
}
