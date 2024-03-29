﻿using System.Threading.Tasks;

namespace PortApplication.Services.Interfaces
{
    public interface IAlertService
    {
        Task DisplayAlert(string title, string message, string cancel);

        Task<bool> DisplayAlert(string title, string message, string accept, string cancel);
    }
}
