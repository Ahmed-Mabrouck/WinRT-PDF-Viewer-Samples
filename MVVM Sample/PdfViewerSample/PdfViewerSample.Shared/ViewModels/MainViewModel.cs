using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PdfViewerSample.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Uri pdf;

        public Uri Pdf
        {
            get { return pdf; }
            set { pdf = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Pdf))); }
        }

        public MainViewModel()
        {
            Pdf = new Uri("ms-appx:///sample.pdf");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
