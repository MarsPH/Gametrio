using static Son_of_Duo.Quickgame;
using static Son_of_Duo.Quickgame.SoundManager;

namespace Son_of_Duo;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        SoundManager.LoadSounds();

        Application.Run(new FillBlanks());

    }    
}