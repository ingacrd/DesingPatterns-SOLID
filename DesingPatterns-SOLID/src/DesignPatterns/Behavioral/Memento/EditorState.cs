﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.DesignPatterns.Behavioral.Memento
{
    //Memento
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;
        private readonly DateTime _stateCreatedAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _stateCreatedAt = DateTime.Now;
        }
        public string GetTitle() { return _title; }
        public string GetContent() { return _content; }

        public DateTime GetDate() { return _stateCreatedAt; }

        public string GetName()
        {
            return $"{_stateCreatedAt} / {_title}";
        }

    }
}
