﻿namespace UserManagementAPI.Models;

public class Person
{
    public Person (string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }
    public string Name { get; private set; }
}