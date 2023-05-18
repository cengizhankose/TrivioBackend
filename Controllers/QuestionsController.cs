using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TriviaBackend.Models;

namespace TriviaBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Question>> GetAllQuestions()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            // For now, return some static questions
            return new List<Question>
            {
                new Question { Id = 1, QuestionText = "Who is the author of the 'Harry Potter' series?", CorrectAnswer = "J.K. Rowling", IncorrectAnswers = new []{"J.K. Rowling","Stephen King", "J.R.R. Tolkien", "George R.R. Martin"} },
                new Question { Id = 2, QuestionText = "What is the capital of Australia?", CorrectAnswer = "Canberra", IncorrectAnswers = new []{"Sydney","Melbourne", "Canberra", "Brisbane"} },
                new Question { Id = 3, QuestionText = "Which planet is closest to the sun?", CorrectAnswer = "Mercury", IncorrectAnswers = new []{"Venus","Earth", "Mercury", "Mars"} },
                new Question { Id = 4, QuestionText = "Who painted the Mona Lisa?", CorrectAnswer = "Leonardo da Vinci", IncorrectAnswers = new []{"Vincent van Gogh","Pablo Picasso", "Claude Monet", "Leonardo da Vinci"} },
            };
        }
    }
}
