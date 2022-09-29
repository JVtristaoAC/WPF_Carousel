﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinect_WPF.ViewModel
{
    public class MenuModel : System.ComponentModel.INotifyPropertyChanged
    {
        public MenuModel()
        {
            DancasDAB = new System.Collections.ObjectModel.ObservableCollection<Model.Danca>();
            DancasDAB.Add(new Model.Danca() { Nome = "Dança da Mãozinha", ImageSource = "/Resources/mao.jpg"});
            DancasDAB.Add(new Model.Danca() { Nome = "Dança 2", ImageSource = "/Resources/psy.jpg" });
            DancasDAB.Add(new Model.Danca() { Nome = "Dança 3", ImageSource = "/Resources/dinamite.jpg" });


            SelectedDancaDAB = DancasDAB[0];
        }

        private System.Collections.ObjectModel.ObservableCollection<Model.Danca> _dancasDAB;
        public System.Collections.ObjectModel.ObservableCollection<Model.Danca> DancasDAB
        {
            get
            {
                return _dancasDAB;
            }
            set
            {
                _dancasDAB = value;
                NotifyPropertyChanged("DancasDAB");
            }
        }

        private Model.Danca _selectedDancaDAB;
        public Model.Danca SelectedDancaDAB
        {
            get
            {
                return _selectedDancaDAB;
            }
            set
            {
                _selectedDancaDAB = value;
                NotifyPropertyChanged("SelectedDancaDAB");
            }
        }

        #region INotifyPropertyChanged

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged
    }
}