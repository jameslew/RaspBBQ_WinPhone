using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace RaspBBQ_WinPhone.ViewModels
{
    public class BBQStatusViewModel : INotifyPropertyChanged
    {
        private DateTime _startDateTime;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public DateTime StartDateTime
        {
            get
            {
                return _startDateTime;
            }
            set
            {
                if (value != _startDateTime)
                {
                    _startDateTime = value;
                    NotifyPropertyChanged("StartDateTime");
                }
            }
        }

        private double _pitTemp;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public double PitTemp
        {
            get
            {
                return _pitTemp;
            }
            set
            {
                if (value != _pitTemp)
                {
                    _pitTemp = value;
                    NotifyPropertyChanged("PitTemp");
                }
            }
        }

        private double _foodTemp;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public double FoodTemp
        {
            get
            {
                return _foodTemp;
            }
            set
            {
                if (value != _foodTemp)
                {
                    _foodTemp = value;
                    NotifyPropertyChanged("FoodTemp");
                }
            }
        }

        private DateTime _lastUpdate;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public DateTime LastUpdate
        {
            get
            {
                return _lastUpdate;
            }
            set
            {
                if (value != _lastUpdate)
                {
                    _lastUpdate = value;
                    NotifyPropertyChanged("LastUpdate");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}