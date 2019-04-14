﻿using App.Domain.Core.Events;
using System;

namespace App.Domain.Events.Student
{
    public class StudentUpdatedEvent : Event
    {
        public StudentUpdatedEvent(Guid id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}
