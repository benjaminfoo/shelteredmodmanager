﻿public interface IPlugin
{
    string Name { get; }

    void initialize();

    void start();


}