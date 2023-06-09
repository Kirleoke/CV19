﻿using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel   
    {
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";

        public string Title
        {
            get => _Title;
           /* set { 
            
                *//*if (Equals(_Title, value)) return;
                _Title = value;
                OnPropertyChanged();*//*

                Set(ref _Title, value);
            }*/
            set => Set(ref _Title, value);          
            
        }

        #endregion

        #region Status : string - Статус программы

        /// <summary>Статус программы</summary>
        private string _Status = "Готов!";

        /// <summary>Статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #endregion

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecute(object p)
        {

        }

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(CanCloseApplicationCommandExecute, OnCloseApplicationCommandExecute);
            #endregion
        }
    }
}
