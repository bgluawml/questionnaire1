using questionnaire1.Models;

public class Answer
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool IsSelected { get; set; }
    public int QuestionId { get; set; }
    public virtual Question Question { get; set; }
}