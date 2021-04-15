using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToMVVM.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }

        public string Text { get; set; }

        public bool IsCompleted { get; set; }

        public ToDoItem(string text, bool isCompleted)
        {
            Text = text;
            IsCompleted = isCompleted;
        }
    }
}
