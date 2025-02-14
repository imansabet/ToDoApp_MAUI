﻿using ToDoApp.ViewModels;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        private ToDoViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ToDoViewModel();
            BindingContext = _viewModel;
        }
        private void OnAddClicked(object sender,EventArgs e) 
        {
            var newTaskTitle = NewTaskEntry.Text;
            if (!string.IsNullOrEmpty(newTaskTitle)) 
            {
                _viewModel.AddTodoItem(newTaskTitle);   
                NewTaskEntry.Text = string.Empty;
            }
        }
       

    }
    public class TodoItem 
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

}
