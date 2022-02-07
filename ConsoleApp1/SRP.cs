﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        //According to principle we are declaring this two responsibility methods in other interface/class. 
        //void LogError(string error);
        //bool SendEmail(string emailcontent);
    }
    interface ILogger
    {
        void LogError(string error);
    }
    interface IEmail
    {
        bool SendEmail(string emailcontent);
    }
}
