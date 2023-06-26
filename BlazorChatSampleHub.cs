using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorChat
{
    public class BlazorChatSampleHub : Hub
    {
        public const string HubUrl = "/chat";

        public async Task Broadcast(string username, string message)
        {
            await Clients.All.SendAsync("Broadcast", username, message);
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"{Context.ConnectionId} connected");
            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception e)
        {
            Console.WriteLine($"Disconnected {e?.Message} {Context.ConnectionId}");
            await base.OnDisconnectedAsync(e);
        }
    }
}

public class StockMarket : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void RegisterObserver(IObserver observer) =>
        observers.Add(observer);

    public void RemoveObserver(IObserver observer) => 
        observers.Remove(observer);

    public void NotifyObservers(string status)
    {
        foreach (var observer in observers)
            observer.Update(status);
    }
}
public interface IObserver
{
    void Update(string status);
}
public class Investor : IObserver
{
    public void Update(string status) =>
        Console.WriteLine("New stock price: " + status);
}