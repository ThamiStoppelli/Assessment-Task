using Application.Interfaces;

namespace WorkerService.HangfireJobs
{
    public class TextUpsertJob
    {
        private readonly ITextService _textService;

        public TextUpsertJob(ITextService textService)
        {
            _textService = textService;
        }

        public async Task Execute()
        {
            await _textService.UpsertDataFromSource();
        }
    }
}
