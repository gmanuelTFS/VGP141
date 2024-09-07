using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageColourCommand : ICommand
{
    private Color _newColour;
    private Color _originalColour;
    private Image _image;

    public ChangeImageColourCommand(Image image, Color newColour)
    {
        _image = image;
        _newColour = newColour;
    }

    /// <summary>
    /// Change the colour of a sprite.
    /// </summary>
    public void Execute()
    {
        _originalColour = _image.color;
        _image.color = _newColour;
    }

    /// <summary>
    /// Change the colour of a sprite to what it was originally.
    /// </summary>
    public void Undo()
    {
        _image.color = _originalColour;
    }
}
