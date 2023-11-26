﻿using Reservoom.ViewModels;
using System;

namespace Reservoom.Stores
{
    public class NavigationStore
    {
        private ViewModelBase? _currentViewModel;

        public ViewModelBase? CurrentViewmodel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action? CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
