﻿//////////////////////////////////////////////////////////////////
//
//   PROGRAMMING ASP.NET CORE
//   Dino Esposito
//   
//   Ch12 - Client-side data binding
//   DataBinding
//

namespace Ch12.DataBinding.Models
{
    public class ViewModelBase
    {
        protected ViewModelBase(string title = "")
        {
            Title = title;
        }

        public static ViewModelBase Default(string title = "")
        {
            var model = new ViewModelBase(title);
            return model;
        }

        public string Title { get; set; }

    }
}