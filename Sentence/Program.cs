using Microsoft.Extensions.DependencyInjection;
using System;

namespace Sentence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
           .AddSingleton<ICommandContext, CommandContext>()
           .AddSingleton<ISentenceProcess, SentenceProcess>()
           .BuildServiceProvider();

            var sentence = serviceProvider.GetService<ISentenceProcess>();
            sentence.Process();
        }
    }
}
