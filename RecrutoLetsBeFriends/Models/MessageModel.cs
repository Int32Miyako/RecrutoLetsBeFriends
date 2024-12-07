namespace RecrutoLetsBeFriends.Models;

public class MessageModel
{
    public readonly string MessageForPerson;

    public MessageModel(string name, string message)
    {
        MessageForPerson = $"\"Hello {name}! {message}!\"";
    }
}