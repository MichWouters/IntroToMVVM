using IntroToMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace IntroToMVVM.ViewModels
{
    public class ToDoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }

        public string NewToDoText { get; set; }

        public Command AddToDoCommand => new Command(AddItem);
        public Command DeleteCommand => new Command(RemoveItem);

        public ToDoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>()
            {
               new ToDoItem("Todo 1", false),
               new ToDoItem("Todo 2", false),
               new ToDoItem("Todo 3", false),
            };
        }

        private void AddItem()
        {
            var todo = new ToDoItem(NewToDoText, false);
            ToDoItems.Add(todo);
        }

        private void RemoveItem(object obj)
        {
            var todo = obj as ToDoItem;
            ToDoItems.Remove(todo);
        }
    }
}
