using System;
using static System.Console;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TP1.Tasks
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            //List<Thread> threads = new()
            //{
            //    new Thread(LavarLouca),
            //    new Thread(LavarRoupa),
            //    new Thread(FazerJantar)
            //};

            //foreach (Thread thread in threads)
            //{
            //    thread.Start();
            //}

            //foreach (Thread thread in threads)
            //{
            //    thread.Join();
            //}

            //LavarLouca();
            //LavarRoupa();
            //FazerJantar();

            var tarefa1 = LavarLouca();
            var tarefa2 = LavarRoupa();
            var tarefa3 = FazerJantar();

            await tarefa1;
            await tarefa2;
            await tarefa3;

            stopwatch.Stop();

            WriteLine($"Todo o processo durou: {stopwatch.ElapsedMilliseconds} ms");

        }

        static async Task LavarLouca()
        {            
            WriteLine($"Inicio: Lavar louça - Thread: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(2000);//ida ao BD fazer um acerto de base
            WriteLine("Fim: Lavar louça");
        }

        static async Task LavarRoupa()
        {
            WriteLine($"Inicio: Lavar roupa - Thread: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(3000);
            WriteLine("Fim: Lavar roupa");
        }

        static async Task FazerJantar()
        {
            WriteLine($"Inicio: Fazer o jantar - Thread: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(5000);
            WriteLine("Fim: Fazer o jantar");
        }
    }
}
