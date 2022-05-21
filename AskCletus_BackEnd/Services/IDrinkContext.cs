﻿using AskCletus_BackEnd.Services.DALModels;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services
{
    public interface IDrinkContext: IAddUser, IGetAllUsers, IUpdateUser, IDeleteUser, IGetBars, IGetMyBar, IDeleteBar
    {
    }

    public interface IGetBars
    {
        IEnumerable<UserBar> GetBars();
    }

    public interface IGetMyBar
    {
        UserBar GetMyBar(int userId);
    }

    public interface IDeleteBar
    {
        UserBar DeleteBar(int userId);
    }

    public interface IDeleteUser
    {
        User DeleteUser(int userId);
    }

    public interface IGetAllUsers
    {
        IEnumerable<User> GetAllUsers();
    }

    public interface IAddUser
    {
        User AddUser(User user);
    }
    public interface IUpdateUser
    {
        User UpdateUser(User user);
    }

}//insert interfaces into IDrinkcontext