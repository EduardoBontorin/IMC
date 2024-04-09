using IMC2.Models;

namespace IMC2
{
    public static class AppState
    {
        public static List<ImcModel> History { get; set; } = new();

        public static event EventHandler<EventArgs> OnChanged;

        public static void NotifyChanges(object? sender, EventArgs args)
        {
            OnChanged.Invoke(sender, args);
        }
    }

}
