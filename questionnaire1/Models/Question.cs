﻿namespace questionnaire1.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
