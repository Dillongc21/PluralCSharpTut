using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Plugin.TextToSpeech.Abstractions;
namespace Grades
{
    public class SpeechSynthesizer : ITextToSpeech
    {
        public SpeechSynthesizer()
        {
        }

        public int MaxSpeechInputLength => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CrossLocale>> GetInstalledLanguages()
        {
            throw new NotImplementedException();
        }

        public Task Speak(string text, CrossLocale? crossLocale = null, float? pitch = null, float? speakRate = null, float? volume = null, CancellationToken? cancelToken = null)
        {
            throw new NotImplementedException();
        }
    }
}
