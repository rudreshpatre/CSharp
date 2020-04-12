﻿namespace LSPLibrary
{
    public interface IManaged:IEmployee
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}