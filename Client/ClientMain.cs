using CitizenFX.Core;
using CitizenFX.FiveM;
using CitizenFX.FiveM.Native;

namespace Client;

public class ClientMain: BaseScript
{
    public ClientMain()
    {
        Debug.WriteLine("Hi from MonoTest.Client!");
    }

    [Tick]
    async Coroutine OnTick()
    {
        Natives.DrawRect(0.5f, 0.5f, 0.5f, 0.5f, 255, 0, 0, 150);
        DrawHealth(0, 0);
    }

    private void DrawHealth(int x, int y)
    {
        Natives.SetTextOutline();
        Natives.SetTextEntry("String");
        Natives.AddTextComponentString($"Health: {Game.PlayerPed.HealthFloat}; MaxHealth: {Game.PlayerPed.MaxHealthFloat}");
        Natives.DrawText(x, y);
    }
}
