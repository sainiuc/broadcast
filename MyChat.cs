using SignalR.Hubs;

public class MyChat : Hub
{
    public void Send(string message)
    {
        // Call the addMessage method on all clients
        Clients.addMessage(message);
    }
}