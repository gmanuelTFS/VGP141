using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChangeController : MonoBehaviour
{
    [SerializeField] private Image _image;
    private Stack<ICommand> _commands;

    private void Awake()
    {
        _commands = new Stack<ICommand>();
    }

    public void ChangeColourToRed()
    {
        ChangeImageColourCommand changeToRed = new ChangeImageColourCommand(_image, Color.red);
        _commands.Push(changeToRed);
        changeToRed.Execute();
    }

    public void ChangeColourToGreen()
    {
        ChangeImageColourCommand changeToGreen = new ChangeImageColourCommand(_image, Color.green);
        _commands.Push(changeToGreen);
        changeToGreen.Execute();
    }

    public void ChangeColourToBlue()
    {
        ChangeImageColourCommand changeToBlue = new ChangeImageColourCommand(_image, Color.blue);
        _commands.Push(changeToBlue);
        changeToBlue.Execute();
    }

    public void MultiplyScale(float multiplier)
    {
        MultiplyScaleCommand multiplyScaleCommand = new(_image, multiplier);
        _commands.Push(multiplyScaleCommand);
        multiplyScaleCommand.Execute();
    }

    public void UndoLastCommand()
    {
        if (_commands.Count == 0)
        {
            return;
        }

        _commands.Peek().Undo();
        _commands.Pop();
    }
}
