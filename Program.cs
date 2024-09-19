using System.Diagnostics;

try
{
    Process process = new Process();
    for (int i = 0; i < 2; i++) { 
    process.StartInfo.FileName = "notepad.exe";
    Process.Start(process.StartInfo);
}
}
catch (Exception ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message);
}
