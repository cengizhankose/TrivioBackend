namespace TriviaBackend.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] IncorrectAnswers { get; set; }
    }
}
